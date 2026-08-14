using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntfysh_client.Updater
{
    /// <summary>
    /// 负责下载新版 zip、解压，并生成替换脚本完成"自我更新"
    /// </summary>
    public static class UpdaterService
    {
        /// <summary>
        /// 下载并解压更新包，返回新版本文件所在目录
        /// </summary>
        public static async Task<string> DownloadAndExtractAsync(
            string downloadUrl,
            long expectedSize,
            IProgress<double>? progress,
            CancellationToken cancellationToken)
        {
            string tempRoot = Path.Combine(Path.GetTempPath(), "ntfy-pusher-update", Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(tempRoot);
            string zipPath = Path.Combine(tempRoot, "update.zip");

            try
            {
                // 1. 下载
                using var client = new HttpClient { Timeout = TimeSpan.FromMinutes(10) };
                client.DefaultRequestHeaders.UserAgent.ParseAdd("ntfy-pusher-update-checker");

                using HttpResponseMessage response = await client.GetAsync(
                    downloadUrl, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                response.EnsureSuccessStatusCode();

                long total = response.Content.Headers.ContentLength ?? expectedSize;

                using Stream contentStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                using var fileStream = new FileStream(zipPath, FileMode.Create, FileAccess.Write, FileShare.None, 81920, useAsync: true);
                byte[] buffer = new byte[81920];
                long downloaded = 0;
                int read;
                while ((read = await contentStream.ReadAsync(buffer, 0, buffer.Length, cancellationToken).ConfigureAwait(false)) > 0)
                {
                    await fileStream.WriteAsync(buffer, 0, read, cancellationToken).ConfigureAwait(false);
                    downloaded += read;
                    if (total > 0)
                        progress?.Report((double)downloaded / total);
                }

                // 2. 大小校验（防止传输被截断）
                if (expectedSize > 0 && downloaded != expectedSize)
                    throw new IOException($"更新包大小不符（应为 {expectedSize} 字节，实际 {downloaded} 字节）");

                // 3. 解压
                string extractDir = Path.Combine(tempRoot, "new");
                ZipFile.ExtractToDirectory(zipPath, extractDir);

                // 4. GitHub 自动打包的 zip 常带一层根目录，此时直接取该目录
                string[] dirs = Directory.GetDirectories(extractDir);
                if (dirs.Length == 1 && Directory.GetFiles(extractDir).Length == 0)
                    return dirs[0];

                return extractDir;
            }
            catch
            {
                TryDeleteDirectory(tempRoot);
                throw;
            }
        }

        /// <summary>
        /// 生成替换脚本并启动它。脚本会等待本程序退出，用新文件覆盖旧文件，
        /// 然后沿用原启动参数重新启动程序。调用后请立即让程序退出。
        /// </summary>
        public static void ApplyUpdateAndExit(string newFilesDir)
        {
            string appDir = Path.GetDirectoryName(Application.ExecutablePath)
                ?? throw new InvalidOperationException("无法确定程序所在目录");
            string exePath = Application.ExecutablePath;
            string scriptDir = Path.GetDirectoryName(newFilesDir)
                ?? throw new InvalidOperationException("无法确定更新临时目录");

            // 把当前启动参数逐行写入文件（例如 --start-in-tray）。
            // 注意：powershell.exe -File 模式下命令行里的 @(...) 数组字面量不会被解析，
            // 因此用文件传递参数，脚本读取后作为数组交给 Start-Process。
            string[] args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            string argsFilePath = Path.Combine(scriptDir, "restart-args.txt");
            File.WriteAllLines(argsFilePath, args, new UTF8Encoding(true));

            string scriptPath = Path.Combine(scriptDir, "apply-update.ps1");
            File.WriteAllText(scriptPath, BuildUpdateScript(), new UTF8Encoding(true));

            var psi = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                Arguments =
                    $"-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File \"{scriptPath}\" " +
                    $"-WaitPid {Environment.ProcessId} " +
                    $"-NewDir \"{newFilesDir}\" " +
                    $"-AppDir \"{appDir}\" " +
                    $"-ExePath \"{exePath}\"",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        /// <summary>
        /// 更新脚本：等待旧进程退出 → 覆盖文件 → 重启程序 → 清理临时目录。
        /// 日志写入 %TEMP%\ntfy-pusher-update-log.txt 供排查。
        /// </summary>
        private static string BuildUpdateScript()
        {
            return @"param(
    [Parameter(Mandatory = $true)][int]$WaitPid,
    [Parameter(Mandatory = $true)][string]$NewDir,
    [Parameter(Mandatory = $true)][string]$AppDir,
    [Parameter(Mandatory = $true)][string]$ExePath
)
$ErrorActionPreference = 'Continue'
$logFile = Join-Path $env:TEMP 'ntfy-pusher-update-log.txt'
""update started: $(Get-Date -Format o)"" | Out-File -FilePath $logFile -Encoding utf8

# 1. Wait for the old process to exit
try {
    $proc = Get-Process -Id $WaitPid -ErrorAction Stop
    $proc.WaitForExit() | Out-Null
} catch {
    Start-Sleep -Seconds 3
}
Start-Sleep -Milliseconds 1200

# 2. Overwrite old files with new ones
try {
    Copy-Item -Path (Join-Path $NewDir '*') -Destination $AppDir -Recurse -Force -ErrorAction Stop
    ""copy ok"" | Out-File -FilePath $logFile -Append -Encoding utf8
} catch {
    ""copy failed: $_"" | Out-File -FilePath $logFile -Append -Encoding utf8
}

# 3. Restart the app (original launch args are read from restart-args.txt, one per line)
Start-Sleep -Milliseconds 500
try {
    $ExeArgs = @()
    $argsFile = Join-Path (Split-Path -Parent $NewDir) 'restart-args.txt'
    if (Test-Path -LiteralPath $argsFile) {
        $ExeArgs = @(Get-Content -LiteralPath $argsFile -Encoding UTF8)
    }
    if ($ExeArgs.Count -gt 0) {
        Start-Process -FilePath $ExePath -ArgumentList $ExeArgs
    } else {
        Start-Process -FilePath $ExePath
    }
} catch {
    ""restart failed: $_"" | Out-File -FilePath $logFile -Append -Encoding utf8
}

# 4. Clean up the temp dir (the log file stays in %TEMP%)
Start-Sleep -Seconds 2
try { Remove-Item -LiteralPath (Split-Path -Parent $NewDir) -Recurse -Force -ErrorAction SilentlyContinue } catch {}
";
        }

        private static void TryDeleteDirectory(string path)
        {
            try { Directory.Delete(path, recursive: true); } catch { /* 忽略清理失败 */ }
        }
    }
}

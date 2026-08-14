using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace ntfysh_client.Updater
{
    /// <summary>
    /// 更新检查结果
    /// </summary>
    public class UpdateCheckResult
    {
        /// <summary>检查是否成功（false 时查看 ErrorMessage）</summary>
        public bool CheckSucceeded { get; set; }

        /// <summary>是否存在新版本</summary>
        public bool UpdateAvailable { get; set; }

        /// <summary>检查失败原因（已本地化的人类可读文本）</summary>
        public string? ErrorMessage { get; set; }

        /// <summary>当前程序版本，如 1.0.0</summary>
        public string CurrentVersion { get; set; } = "";

        /// <summary>远端最新版本，如 1.1.0</summary>
        public string? LatestVersion { get; set; }

        /// <summary>更新说明（Markdown 文本）</summary>
        public string? ReleaseNotes { get; set; }

        /// <summary>GitHub Release 页面地址</summary>
        public string? ReleasePageUrl { get; set; }

        /// <summary>更新包下载地址（优先 zip，其次 exe）</summary>
        public string? AssetDownloadUrl { get; set; }

        /// <summary>更新包大小（字节）</summary>
        public long AssetSizeBytes { get; set; }

        /// <summary>更新包文件名</summary>
        public string? AssetName { get; set; }
    }

    /// <summary>
    /// 通过 GitHub Releases API 检查更新
    /// </summary>
    public static class UpdateChecker
    {
        private const string RepoOwner = "H2O-MERO";
        private const string RepoName = "ntfy-pusher-Windows";
        private const string LatestReleaseUrl =
            $"https://api.github.com/repos/{RepoOwner}/{RepoName}/releases/latest";

        // 复用同一个 HttpClient 以复用连接；GitHub API 强制要求 User-Agent
        private static readonly HttpClient HttpClient = CreateHttpClient();

        private static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(20);
            client.DefaultRequestHeaders.UserAgent.ParseAdd("ntfy-pusher-update-checker");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
            return client;
        }

        /// <summary>
        /// 当前程序集版本号（去掉末尾无意义的修订号，如 1.0.0.0 → 1.0.0）
        /// </summary>
        public static string GetCurrentVersion()
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version ?? new Version(1, 0, 0);
            return FormatVersion(version);
        }

        /// <summary>
        /// 调用 GitHub API 检查是否有新版本。任何网络/解析错误都不会抛出，
        /// 而是记录在返回结果的 ErrorMessage 中。
        /// </summary>
        public static async Task<UpdateCheckResult> CheckForUpdatesAsync()
        {
            var result = new UpdateCheckResult { CurrentVersion = GetCurrentVersion() };

            try
            {
                using HttpResponseMessage response = await HttpClient
                    .GetAsync(LatestReleaseUrl)
                    .ConfigureAwait(false);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    result.ErrorMessage = LocalizationHelper.GetGlobalString("UpdateChecker.NoReleaseYet");
                    return result;
                }

                if (!response.IsSuccessStatusCode)
                {
                    result.ErrorMessage = $"HTTP {(int)response.StatusCode}";
                    return result;
                }

                string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                GitHubRelease? release = JsonConvert.DeserializeObject<GitHubRelease>(json);
                if (release is null)
                {
                    result.ErrorMessage = LocalizationHelper.GetGlobalString("UpdateChecker.BadResponse");
                    return result;
                }

                if (!TryParseVersionTag(release.TagName, out Version latestVersion))
                {
                    result.ErrorMessage = $"无法解析版本号: {release.TagName}";
                    return result;
                }

                result.LatestVersion = FormatVersion(latestVersion);
                result.ReleaseNotes = release.Body;
                result.ReleasePageUrl = release.HtmlUrl;

                if (!TryParseVersionTag(result.CurrentVersion, out Version currentVersion))
                {
                    result.ErrorMessage = $"无法解析当前版本号: {result.CurrentVersion}";
                    return result;
                }

                result.UpdateAvailable = latestVersion > currentVersion;

                // 挑选更新包：优先 zip（本程序自替换用），其次 exe
                if (result.UpdateAvailable && release.Assets is not null)
                {
                    GitHubAsset? asset =
                        release.Assets.FirstOrDefault(a =>
                            a.Name?.EndsWith(".zip", StringComparison.OrdinalIgnoreCase) == true)
                        ?? release.Assets.FirstOrDefault(a =>
                            a.Name?.EndsWith(".exe", StringComparison.OrdinalIgnoreCase) == true);

                    if (asset is not null && !string.IsNullOrEmpty(asset.BrowserDownloadUrl))
                    {
                        result.AssetDownloadUrl = asset.BrowserDownloadUrl;
                        result.AssetSizeBytes = asset.Size;
                        result.AssetName = asset.Name;
                    }
                }

                result.CheckSucceeded = true;
            }
            catch (Exception ex) when (ex is HttpRequestException or TaskCanceledException or JsonException)
            {
                result.ErrorMessage = ex.Message;
            }

            return result;
        }

        /// <summary>
        /// 把 tag（如 v1.2.3 / 1.2.3 / V1.2.3）解析成 System.Version
        /// </summary>
        private static bool TryParseVersionTag(string? tag, out Version version)
        {
            version = new Version(0, 0);
            if (string.IsNullOrWhiteSpace(tag)) return false;

            string cleaned = tag.Trim().TrimStart('v', 'V');
            if (Version.TryParse(cleaned, out Version? parsed) && parsed is not null)
            {
                version = parsed;
                return true;
            }
            return false;
        }

        private static string FormatVersion(Version version)
        {
            string text = $"{version.Major}.{version.Minor}.{version.Build}";
            if (version.Revision > 0) text += $".{version.Revision}";
            return text;
        }

        private class GitHubRelease
        {
            [JsonProperty("tag_name")]
            public string? TagName { get; set; }

            [JsonProperty("body")]
            public string? Body { get; set; }

            [JsonProperty("html_url")]
            public string? HtmlUrl { get; set; }

            [JsonProperty("assets")]
            public List<GitHubAsset>? Assets { get; set; }
        }

        private class GitHubAsset
        {
            [JsonProperty("name")]
            public string? Name { get; set; }

            [JsonProperty("browser_download_url")]
            public string? BrowserDownloadUrl { get; set; }

            [JsonProperty("size")]
            public long Size { get; set; }
        }
    }
}

using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntfysh_client.Updater
{
    /// <summary>
    /// 下载进度对话框（纯代码构建，避免改动设计器）
    /// </summary>
    public class UpdateDownloadDialog : Form
    {
        private readonly ProgressBar _progressBar;
        private readonly Label _statusLabel;
        private readonly Button _cancelButton;
        private readonly CancellationTokenSource _cancellationTokenSource = new();

        public UpdateDownloadDialog()
        {
            Text = LocalizationHelper.GetGlobalString("UpdateDialog.Title");
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 116);

            _statusLabel = new Label
            {
                Text = LocalizationHelper.GetGlobalString("UpdateDialog.StatusDownloading"),
                Location = new Point(14, 14),
                AutoSize = true
            };
            _progressBar = new ProgressBar
            {
                Location = new Point(14, 42),
                Size = new Size(392, 23),
                Minimum = 0,
                Maximum = 100
            };
            _cancelButton = new Button
            {
                Text = LocalizationHelper.GetGlobalString("UpdateDialog.Cancel"),
                Location = new Point(311, 78),
                Size = new Size(95, 30)
            };
            _cancelButton.Click += (_, _) => _cancellationTokenSource.Cancel();

            Controls.Add(_statusLabel);
            Controls.Add(_progressBar);
            Controls.Add(_cancelButton);
        }

        /// <summary>
        /// 执行下载任务并更新进度条。返回 true 表示下载完成（结果在 NewFilesDirectory），
        /// false 表示用户取消。下载失败时抛出异常，由调用方处理。
        /// </summary>
        public async Task<bool> RunDownloadAsync(Func<IProgress<double>, CancellationToken, Task<string>> downloadWork)
        {
            var progress = new Progress<double>(p =>
            {
                int value = (int)(p * 100);
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                _progressBar.Value = value;
            });

            Task<string> workTask = downloadWork(progress, _cancellationTokenSource.Token);

            try
            {
                NewFilesDirectory = await workTask;
            }
            catch (OperationCanceledException)
            {
                return false;
            }

            return true;
        }

        /// <summary>下载并解压后的新版本文件目录（仅下载成功时有值）</summary>
        public string? NewFilesDirectory { get; private set; }
    }
}

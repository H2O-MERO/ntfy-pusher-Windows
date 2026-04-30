using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ntfysh_client.Notifications;

namespace ntfysh_client
{
    static class Program
    {
        private static readonly NotificationListener NotificationListener = new();
        public static SettingsModel Settings { get; set; } = null!;

        /// <summary>
        /// 应用程序主入口点
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // 标准化命令行参数
            args = args.Select(a => a.ToLower()).ToArray();

            // 帮助菜单（退出程序）
            if (args.Contains("-h") || args.Contains("--help"))
            {
                MessageBox.Show(
                    "Help:\n    -h\n    --help\n\nStart in tray:\n    -t\n    --start-in-tray\n\nAllow multiple instances:\n    -m\n    --allow-multiple-instances",
                    "Help Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool startInTray = args.Contains("-t") || args.Contains("--start-in-tray");
            bool allowMultipleInstances = args.Contains("-m") || args.Contains("--allow-multiple-instances");

            // 检查多实例
            if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly()!.Location)).Length > 1)
            {
                if (!allowMultipleInstances)
                {
                    MessageBox.Show(
                        "Another instance is already running.\n\nUse -m or --allow-multiple-instances if you wish to start a second duplicate instance.\n\nThis instance will now close.",
                        "Multiple Instances", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 1. 加载设置
            Settings = SettingsManager.LoadSettings();

            // 2. 应用多语言
            LocalizationHelper.ApplyLanguage(Settings.Language);

            // 3. 启动界面
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(NotificationListener, startInTray));
        }
    }
}
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using Newtonsoft.Json;
using ntfysh_client.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;

namespace ntfysh_client
{
    public partial class MainForm : Form
    {
        private readonly NotificationListener _notificationListener;
        private bool _startInTray;
        private bool _trueExit;
        private NotificationDialog _notificationDialog;

        private readonly Dictionary<string, string> _toastMessages = new Dictionary<string, string>();

        public MainForm(NotificationListener notificationListener, bool startInTray = false)
        {
            _notificationListener = notificationListener;
            _startInTray = startInTray;
            _notificationListener.OnNotificationReceive += OnNotificationReceive;
            _notificationListener.OnConnectionMultiAttemptFailure += OnConnectionMultiAttemptFailure;
            _notificationListener.OnConnectionCredentialsFailure += OnConnectionCredentialsFailure;

            ToastNotificationManagerCompat.OnActivated += OnToastActivated;

            InitializeComponent();
        }

        private void OnToastActivated(ToastNotificationActivatedEventArgsCompat e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                var args = ToastArguments.Parse(e.Argument);
                if (args.TryGetValue("action", out string action) && action == "copy")
                {
                    if (args.TryGetValue("tag", out string tag) && _toastMessages.TryGetValue(tag, out string message))
                    {
                        try
                        {
                            Clipboard.SetText(message);
                            //Debug.WriteLine($"复制到剪贴板: {message}");
                        }
                        catch (Exception ex)
                        {
                            // Debug.WriteLine($"复制失败: {ex.Message}");
                        }
                        finally
                        {
                            _toastMessages.Remove(tag);
                        }
                    }
                }
            });
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyIcon.Dispose();
            ToastNotificationManagerCompat.OnActivated -= OnToastActivated;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTopics();

            _notificationDialog = new NotificationDialog();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (_startInTray)
            {
                _startInTray = false;

                /*
                 * TODO This little workaround prevents the window from appearing with a flash, but the taskbar icon appears for a moment.
                 *
                 * TODO This is because we must call SetVisibleCore(true) for the initial load events in the MainForm to fire, which is what triggers the listener
                 */
                Opacity = 0;
                base.SetVisibleCore(true);
                base.SetVisibleCore(false);
                Opacity = 1;

                return;
            }

            base.SetVisibleCore(value);
        }

        private void CopyToClipboard(string text)
        {
            try
            {
                Thread clipboardThread = new Thread(() =>
                {
                    try
                    {
                        Clipboard.SetText(text);
                        Debug.WriteLine($"复制到剪贴板: {text}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"复制失败: {ex.Message}");
                    }
                });

                clipboardThread.SetApartmentState(ApartmentState.STA);
                clipboardThread.IsBackground = true;
                clipboardThread.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"创建复制线程失败: {ex.Message}");
            }
        }

        private void OnNotificationReceive(object sender, NotificationReceiveEventArgs e)
        {
            ToolTipIcon priorityIcon = e.Priority switch
            {
                NotificationPriority.Max => ToolTipIcon.Error,
                NotificationPriority.High => ToolTipIcon.Warning,
                NotificationPriority.Default => ToolTipIcon.Info,
                NotificationPriority.Low => ToolTipIcon.Info,
                NotificationPriority.Min => ToolTipIcon.None,
                _ => throw new ArgumentOutOfRangeException("Unknown priority received")
            };

            string finalTitle = string.IsNullOrWhiteSpace(e.Title) ? $"{e.Sender.TopicId}@{e.Sender.ServerUrl}" : e.Title;

            if (Program.Settings.NotificationsMethod == SettingsModel.NotificationsType.NativeWindows)
            {
                //notifyIcon.ShowBalloonTip((int)TimeSpan.FromSeconds((double)Program.Settings.Timeout).TotalMilliseconds, finalTitle, e.Message, priorityIcon);
                //use toast for pushing cotifications

                string tag = Guid.NewGuid().ToString();
                _toastMessages[tag] = e.Message;

                if (Program.Settings.NativeNotificationsAutoCopyToClipboard)
                {
                    CopyToClipboard(e.Message);
                }

                string buttonText = Program.Settings.NativeNotificationsAutoCopyToClipboard
                    ? "已自动复制到剪切板"
                    : "复制内容";

                new ToastContentBuilder()
                    .AddText(finalTitle)
                    .AddText(e.Message)
                    .AddButton(new ToastButton()
                        .SetContent(buttonText)              // ← 动态文本
                        .AddArgument("action", "copy")
                        .AddArgument("tag", tag)
                        .SetBackgroundActivation())
                    .SetToastDuration(ToastDuration.Short)
                    .SetToastScenario(priorityIcon == ToolTipIcon.Error ? ToastScenario.Alarm : ToastScenario.Default)
                    .Show(toast =>
                    {
                        double timeoutSeconds = (double)Convert.ToDecimal(Program.Settings.Timeout);
                        toast.ExpirationTime = DateTime.Now.AddSeconds(timeoutSeconds);
                    });
            }
            else
            {

                _notificationDialog.ShowNotification(
                    title: finalTitle,
                    message: e.Message,
                    timeoutSeconds: (int)Program.Settings.Timeout,
                    icon: priorityIcon,
                    showTimeOutBar: Program.Settings.CustomTrayNotificationsShowTimeoutBar,
                    showInDarkMode: Program.Settings.CustomTrayNotificationsShowInDarkMode,
                    playNotificationSound: Program.Settings.CustomTrayNotificationsPlayDefaultWindowsSound
                );
            }
        }

        private void OnConnectionMultiAttemptFailure(NotificationListener sender, SubscribedTopic topic)
        {
            MessageBox.Show($"Connecting to topic ID '{topic.TopicId}' on server '{topic.ServerUrl}' failed after multiple attempts.\n\nThis topic ID will be ignored and you will not receive notifications for it until you restart the application.", "Connection Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnConnectionCredentialsFailure(NotificationListener sender, SubscribedTopic topic)
        {
            string reason = string.IsNullOrWhiteSpace(topic.Username) ? "credentials are required but were not provided" : "the entered credentials are incorrect";

            MessageBox.Show($"Connecting to topic ID '{topic.TopicId}' on server '{topic.ServerUrl}' failed because {reason}.\n\nThis topic ID will be ignored and you will not receive notifications for it until you correct the credentials.", "Connection Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void subscribeNewTopic_Click(object sender, EventArgs e)
        {
            using SubscribeDialog dialog = new SubscribeDialog(无订阅的主题);
            DialogResult result = dialog.ShowDialog();

            //Do not subscribe on cancelled dialog
            if (result != DialogResult.OK) return;

            //Convert the reconnection values to ints
            int reconnectAttempts = Convert.ToInt32(Math.Ceiling(Program.Settings.ReconnectAttempts));
            int reconnectAttemptDelay = Convert.ToInt32(Math.Ceiling(Program.Settings.ReconnectAttemptDelay));

            //Subscribe
            if (dialog.UseWebsockets)
            {
                _notificationListener.SubscribeToTopicUsingWebsocket(dialog.Unique, dialog.TopicId, dialog.ServerUrl, dialog.Username, dialog.Password, reconnectAttempts, reconnectAttemptDelay);
            }
            else
            {
                _notificationListener.SubscribeToTopicUsingLongHttpJson(dialog.Unique, dialog.TopicId, dialog.ServerUrl, dialog.Username, dialog.Password, reconnectAttempts, reconnectAttemptDelay);
            }

            //Add to the user visible list
            无订阅的主题.Items.Add(dialog.Unique);

            //Save the topics persistently
            SaveTopicsToFile();
        }

        private async void removeSelectedTopics_Click(object sender, EventArgs e)
        {
            while (无订阅的主题.SelectedIndex > -1)
            {
                string topicUniqueString = (string)无订阅的主题.Items[无订阅的主题.SelectedIndex];

                await _notificationListener.UnsubscribeFromTopicAsync(topicUniqueString);
                无订阅的主题.Items.Remove(topicUniqueString);
            }

            SaveTopicsToFile();
        }
        private void UpdateAutoStart()
        {
            const string runKeyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";
            string appName = "ntfysh_client";   // 或 Application.ProductName，确保唯一
            string execPath = Application.ExecutablePath;

            using RegistryKey? rk = Registry.CurrentUser.OpenSubKey(runKeyPath, writable: true);
            if (rk == null) return;

            if (Program.Settings.AutoStartEnabled)
            {
                rk.SetValue(appName, execPath);
            }
            else
            {
                try
                {
                    rk.DeleteValue(appName, throwOnMissingValue: false);
                }
                catch { /* 忽略可能的权限异常 */ }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using SettingsDialog dialog = new();

            //Load current settings into dialog
            dialog.ReconnectAttempts = Program.Settings.ReconnectAttempts;
            dialog.ReconnectAttemptDelay = Program.Settings.ReconnectAttemptDelay;
            dialog.UseNativeWindowsNotifications = Program.Settings.NotificationsMethod == SettingsModel.NotificationsType.NativeWindows;
            dialog.UseCustomTrayNotifications = Program.Settings.NotificationsMethod == SettingsModel.NotificationsType.CustomTray;
            dialog.CustomTrayNotificationsShowTimeoutBar = Program.Settings.CustomTrayNotificationsShowTimeoutBar;
            dialog.CustomTrayNotificationsShowInDarkMode = Program.Settings.CustomTrayNotificationsShowInDarkMode;
            dialog.CustomTrayNotificationsPlayDefaultWindowsSound = Program.Settings.CustomTrayNotificationsPlayDefaultWindowsSound;
            dialog.Timeout = Program.Settings.Timeout; // set timeout last so bounds are setup before setting value
            dialog.NativeNotificationsAutoCopyToClipboard = Program.Settings.NativeNotificationsAutoCopyToClipboard;
            dialog.AutoStartEnabled = Program.Settings.AutoStartEnabled;
            dialog.Language = Program.Settings.Language;


            //Show dialog
            DialogResult result = dialog.ShowDialog();

            //Do not save on cancelled dialog
            if (result != DialogResult.OK) return;

            //Read new settings from dialog
            Program.Settings.Timeout = dialog.Timeout;
            Program.Settings.ReconnectAttempts = dialog.ReconnectAttempts;
            Program.Settings.ReconnectAttemptDelay = dialog.ReconnectAttemptDelay;
            Program.Settings.NotificationsMethod = (dialog.UseNativeWindowsNotifications) ? SettingsModel.NotificationsType.NativeWindows : SettingsModel.NotificationsType.CustomTray;
            Program.Settings.CustomTrayNotificationsShowTimeoutBar = dialog.CustomTrayNotificationsShowTimeoutBar;
            Program.Settings.CustomTrayNotificationsShowInDarkMode = dialog.CustomTrayNotificationsShowInDarkMode;
            Program.Settings.CustomTrayNotificationsPlayDefaultWindowsSound = dialog.CustomTrayNotificationsPlayDefaultWindowsSound;
            Program.Settings.NativeNotificationsAutoCopyToClipboard = dialog.NativeNotificationsAutoCopyToClipboard;
            Program.Settings.AutoStartEnabled = dialog.AutoStartEnabled;
            Program.Settings.Language = dialog.Language;

            UpdateAutoStart();
            SettingsManager.SaveSettings(Program.Settings);

            string currentCulture = Thread.CurrentThread.CurrentUICulture.Name;
            if (!string.Equals(currentCulture, dialog.Language, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("语言更改将在程序重启后生效。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void notificationTopics_SelectedValueChanged(object sender, EventArgs e)
        {
            removeSelectedTopics.Enabled = 无订阅的主题.SelectedIndices.Count > 0;
        }

        private void notificationTopics_Click(object sender, EventArgs e)
        {
            MouseEventArgs ev = (MouseEventArgs)e;
            int clickedItemIndex = 无订阅的主题.IndexFromPoint(new Point(ev.X, ev.Y));

            if (clickedItemIndex == -1) 无订阅的主题.ClearSelected();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseEv = (MouseEventArgs)e;

            if (mouseEv.Button != MouseButtons.Left) return;

            Visible = !Visible;
            BringToFront();
        }

        private void showControlWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
            BringToFront();
        }

        private string GetTopicsFilePath()
        {
            string binaryDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException("Unable to determine path for application");
            return Path.Combine(binaryDirectory ?? throw new InvalidOperationException("Unable to determine path for topics file"), "topics.json");
        }

        private string GetLegacyTopicsFilePath()
        {
            string binaryDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException("Unable to determine path for application");
            return Path.Combine(binaryDirectory ?? throw new InvalidOperationException("Unable to determine path for legacy topics file"), "topics.txt");
        }

        private void SaveTopicsToFile()
        {
            string topicsSerialised = JsonConvert.SerializeObject(_notificationListener.SubscribedTopicsByUnique.Select(st => st.Value).ToList(), Formatting.Indented);

            File.WriteAllText(GetTopicsFilePath(), topicsSerialised);
        }


        private void LoadTopics()
        {
            string legacyTopicsPath = GetLegacyTopicsFilePath();
            string topicsFilePath = GetTopicsFilePath();

            //If we have an old format topics file. Convert it to the new format!
            if (File.Exists(legacyTopicsPath))
            {
                //Read old format
                List<string> legacyTopics = new List<string>();

                using (StreamReader reader = new StreamReader(legacyTopicsPath))
                {
                    while (!reader.EndOfStream)
                    {
                        string? legacyTopic = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(legacyTopic)) legacyTopics.Add(legacyTopic);
                    }
                }

                //Assemble new format
                List<SubscribedTopic> newTopics = legacyTopics.Select(lt => new SubscribedTopic(lt, "https://ntfy.sh", null, null)).ToList();

                string newFormatSerialised = JsonConvert.SerializeObject(newTopics, Formatting.Indented);

                //Write new format
                File.WriteAllText(topicsFilePath, newFormatSerialised);

                //Delete old format
                File.Delete(legacyTopicsPath);
            }

            //Check if we have any topics file on disk to load
            if (!File.Exists(topicsFilePath)) return;

            //We have a topics file. Load it!
            string topicsSerialised = File.ReadAllText(topicsFilePath);

            //Check if the file is empty
            if (string.IsNullOrWhiteSpace(topicsSerialised))
            {
                //The file is empty. May as well remove it and consider it nonexistent
                File.Delete(topicsFilePath);
                return;
            }

            //Deserialise the topics
            List<SubscribedTopic>? topics = JsonConvert.DeserializeObject<List<SubscribedTopic>>(topicsSerialised);

            if (topics is null)
            {
                //TODO Deserialise error!
                return;
            }

            //Convert the reconnection values to ints
            int reconnectAttempts = Convert.ToInt32(Math.Ceiling(Program.Settings.ReconnectAttempts));
            int reconnectAttemptDelay = Convert.ToInt32(Math.Ceiling(Program.Settings.ReconnectAttemptDelay));

            //Load them in
            foreach (SubscribedTopic topic in topics)
            {
                string[] parts = topic.ServerUrl.Split("://", 2);

                switch (parts[0].ToLower())
                {
                    case "ws":
                    case "wss":
                        _notificationListener.SubscribeToTopicUsingWebsocket($"{topic.TopicId}@{topic.ServerUrl}", topic.TopicId, topic.ServerUrl, topic.Username, topic.Password, reconnectAttempts, reconnectAttemptDelay);
                        break;

                    case "http":
                    case "https":
                        _notificationListener.SubscribeToTopicUsingLongHttpJson($"{topic.TopicId}@{topic.ServerUrl}", topic.TopicId, topic.ServerUrl, topic.Username, topic.Password, reconnectAttempts, reconnectAttemptDelay);
                        break;

                    default:
                        continue;
                }

                无订阅的主题.Items.Add($"{topic.TopicId}@{topic.ServerUrl}");
            }
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Let it close
            if (_trueExit) return;

            if (e.CloseReason != CloseReason.UserClosing) return;

            Visible = false;
            e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _trueExit = true;
            Close();
        }

        private void ntfyshWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://ntfy.sh/")
            {
                UseShellExecute = true
            });
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AboutBox d = new AboutBox();
            d.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _trueExit = true;
            Close();
        }

        private void notificationTopics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class LocalizationHelper
    {
        public static void ApplyLanguage(string cultureName)
        {
            try
            {
                var culture = new CultureInfo(cultureName);
                Thread.CurrentThread.CurrentUICulture = culture;
                Thread.CurrentThread.CurrentCulture = culture;
            }
            catch (CultureNotFoundException)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            }
        }
        private static ResourceManager _globalResMgr =
            new ResourceManager("ntfysh_client.Properties.Resources", Assembly.GetExecutingAssembly());
        public static string GetGlobalString(string key)
        {
            try
            {
                return _globalResMgr.GetString(key);
            }
            catch
            {
                return $"[{key}]";
            }
        }
    }
}

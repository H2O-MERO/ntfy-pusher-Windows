using System;
using System.Windows.Forms;
using static ntfysh_client.SettingsModel;

namespace ntfysh_client
{
    public partial class SettingsDialog : Form
    {
        public NotificationsType NotificationsMethod { get; set; }

        public decimal Timeout
        {
            get => timeout.Value;
            set => timeout.Value = value;
        }

        public decimal ReconnectAttempts
        {
            get => reconnectAttempts.Value;
            set => reconnectAttempts.Value = value;
        }

        public decimal ReconnectAttemptDelay
        {
            get => reconnectAttemptDelay.Value;
            set => reconnectAttemptDelay.Value = value;
        }

        #region: Native vs custom notifications options. Because these are in a group box, these are mutualy exclusive.
        public bool UseNativeWindowsNotifications
        {
            get => useNativeWindowsNotifications.Checked;
            set
            {
                useNativeWindowsNotifications.Checked = value;
                groupNativeNotification.Enabled = value;   
                NotificationsMethod = value ? NotificationsType.NativeWindows : NotificationsType.CustomTray;
            }
        }

        public bool UseCustomTrayNotifications
        {
            get => useCustomTrayNotifications.Checked;
            set
            {
                useCustomTrayNotifications.Checked = value;
                groupCustomNotificationSettings.Enabled = value;
                NotificationsMethod = (value) ? NotificationsType.NativeWindows : NotificationsType.CustomTray;
            }
        }
        #endregion

        #region: Custom tray notification options
        public bool CustomTrayNotificationsShowTimeoutBar
        {
            get => customNotificationsShowTimeoutBar.Checked;
            set => customNotificationsShowTimeoutBar.Checked = value;
        }

        public bool CustomTrayNotificationsShowInDarkMode
        {
            get => customNotificationsShowInDarkMode.Checked;
            set => customNotificationsShowInDarkMode.Checked = value;
        }

        public bool CustomTrayNotificationsPlayDefaultWindowsSound
        {
            get => customNotificationsPlayWindowsNotificationAudio.Checked;
            set => customNotificationsPlayWindowsNotificationAudio.Checked = value;
        }
        #endregion

        #region: Native notification options
        public bool NativeNotificationsAutoCopyToClipboard
        {
            get => nativeNotificationAutoCopy.Checked;
            set => nativeNotificationAutoCopy.Checked = value;
        }
        #endregion

        public SettingsDialog()
        {
            InitializeComponent();
            SetNotificationsUiElements();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SetNotificationsUiElements()
        {
            groupCustomNotificationSettings.Enabled = useCustomTrayNotifications.Checked;
            timeoutLabel.Text = useCustomTrayNotifications.Checked ? _customNotificationsTimeout : _windowsNotificationsTimeout;
        }

        private void UseCustomTrayNotifications_CheckedChanged(object sender, EventArgs e)
        {
            SetNotificationsUiElements();
        }

        private const string _windowsNotificationsTimeout = "通知提示超时（秒，可能因系统辅助功能设置而被忽略）:";
        private const string _customNotificationsTimeout = "通知提示超时（秒，设为0则需手动关闭通知）:";

        private void SettingsDialog_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void customNotificationsPlayWindowsNotificationAudio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timeoutLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

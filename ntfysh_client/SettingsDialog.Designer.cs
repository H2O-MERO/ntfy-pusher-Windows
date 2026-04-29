
using System;

namespace ntfysh_client
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPanel = new System.Windows.Forms.Panel();
            cancelButton = new System.Windows.Forms.Button();
            saveButton = new System.Windows.Forms.Button();
            timeoutLabel = new System.Windows.Forms.Label();
            timeout = new System.Windows.Forms.NumericUpDown();
            reconnectAttempts = new System.Windows.Forms.NumericUpDown();
            reconnectAttemptsLabel = new System.Windows.Forms.Label();
            reconnectAttemptDelay = new System.Windows.Forms.NumericUpDown();
            reconnectAttemptDelayLabel = new System.Windows.Forms.Label();
            nativeVersusCustomNotificationsGroupBox = new System.Windows.Forms.GroupBox();
            useCustomTrayNotifications = new System.Windows.Forms.RadioButton();
            useNativeWindowsNotifications = new System.Windows.Forms.RadioButton();
            groupCustomNotificationSettings = new System.Windows.Forms.GroupBox();
            customNotificationsPlayWindowsNotificationAudio = new System.Windows.Forms.CheckBox();
            customNotificationsShowInDarkMode = new System.Windows.Forms.CheckBox();
            customNotificationsShowTimeoutBar = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            groupNativeNotification = new System.Windows.Forms.GroupBox();
            nativeNotificationAutoCopy = new System.Windows.Forms.CheckBox();
            checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reconnectAttempts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reconnectAttemptDelay).BeginInit();
            nativeVersusCustomNotificationsGroupBox.SuspendLayout();
            groupCustomNotificationSettings.SuspendLayout();
            groupNativeNotification.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPanel
            // 
            buttonPanel.BackColor = System.Drawing.SystemColors.Control;
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Controls.Add(saveButton);
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            buttonPanel.Location = new System.Drawing.Point(0, 467);
            buttonPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new System.Drawing.Size(531, 58);
            buttonPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(363, 18);
            cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 26);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "取消";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(444, 18);
            saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(75, 26);
            saveButton.TabIndex = 1;
            saveButton.Text = "保存";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Location = new System.Drawing.Point(13, 10);
            timeoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new System.Drawing.Size(296, 17);
            timeoutLabel.TabIndex = 3;
            timeoutLabel.Text = "通知提示超时（秒，使用-1表示需要手动关闭通知）：";
            timeoutLabel.Click += timeoutLabel_Click;
            // 
            // timeout
            // 
            timeout.Location = new System.Drawing.Point(13, 32);
            timeout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            timeout.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            timeout.Name = "timeout";
            timeout.Size = new System.Drawing.Size(506, 23);
            timeout.TabIndex = 4;
            // 
            // reconnectAttempts
            // 
            reconnectAttempts.Location = new System.Drawing.Point(12, 83);
            reconnectAttempts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            reconnectAttempts.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttempts.Name = "reconnectAttempts";
            reconnectAttempts.Size = new System.Drawing.Size(506, 23);
            reconnectAttempts.TabIndex = 6;
            // 
            // reconnectAttemptsLabel
            // 
            reconnectAttemptsLabel.AutoSize = true;
            reconnectAttemptsLabel.Location = new System.Drawing.Point(12, 61);
            reconnectAttemptsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reconnectAttemptsLabel.Name = "reconnectAttemptsLabel";
            reconnectAttemptsLabel.Size = new System.Drawing.Size(260, 17);
            reconnectAttemptsLabel.TabIndex = 5;
            reconnectAttemptsLabel.Text = "最大重新连接重试尝试次数（需要重新启动）：";
            // 
            // reconnectAttemptDelay
            // 
            reconnectAttemptDelay.Location = new System.Drawing.Point(12, 134);
            reconnectAttemptDelay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            reconnectAttemptDelay.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttemptDelay.Name = "reconnectAttemptDelay";
            reconnectAttemptDelay.Size = new System.Drawing.Size(506, 23);
            reconnectAttemptDelay.TabIndex = 8;
            // 
            // reconnectAttemptDelayLabel
            // 
            reconnectAttemptDelayLabel.AutoSize = true;
            reconnectAttemptDelayLabel.Location = new System.Drawing.Point(12, 112);
            reconnectAttemptDelayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            reconnectAttemptDelayLabel.Name = "reconnectAttemptDelayLabel";
            reconnectAttemptDelayLabel.Size = new System.Drawing.Size(224, 17);
            reconnectAttemptDelayLabel.TabIndex = 7;
            reconnectAttemptDelayLabel.Text = "尝试之间的延迟（秒，需要重新启动）：";
            // 
            // nativeVersusCustomNotificationsGroupBox
            // 
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useCustomTrayNotifications);
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useNativeWindowsNotifications);
            nativeVersusCustomNotificationsGroupBox.Location = new System.Drawing.Point(12, 166);
            nativeVersusCustomNotificationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nativeVersusCustomNotificationsGroupBox.Name = "nativeVersusCustomNotificationsGroupBox";
            nativeVersusCustomNotificationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nativeVersusCustomNotificationsGroupBox.Size = new System.Drawing.Size(506, 76);
            nativeVersusCustomNotificationsGroupBox.TabIndex = 9;
            nativeVersusCustomNotificationsGroupBox.TabStop = false;
            // 
            // useCustomTrayNotifications
            // 
            useCustomTrayNotifications.AutoSize = true;
            useCustomTrayNotifications.Location = new System.Drawing.Point(6, 45);
            useCustomTrayNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            useCustomTrayNotifications.Name = "useCustomTrayNotifications";
            useCustomTrayNotifications.Size = new System.Drawing.Size(283, 21);
            useCustomTrayNotifications.TabIndex = 1;
            useCustomTrayNotifications.TabStop = true;
            useCustomTrayNotifications.Text = "使用ntfysh-windows自定义托盘通知（不推荐）";
            useCustomTrayNotifications.UseVisualStyleBackColor = true;
            useCustomTrayNotifications.CheckedChanged += UseCustomTrayNotifications_CheckedChanged;
            // 
            // useNativeWindowsNotifications
            // 
            useNativeWindowsNotifications.AutoSize = true;
            useNativeWindowsNotifications.Location = new System.Drawing.Point(6, 17);
            useNativeWindowsNotifications.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            useNativeWindowsNotifications.Name = "useNativeWindowsNotifications";
            useNativeWindowsNotifications.Size = new System.Drawing.Size(199, 21);
            useNativeWindowsNotifications.TabIndex = 0;
            useNativeWindowsNotifications.TabStop = true;
            useNativeWindowsNotifications.Text = "使用Windows原生通知（推荐）";
            useNativeWindowsNotifications.UseVisualStyleBackColor = true;
            // 
            // groupCustomNotificationSettings
            // 
            groupCustomNotificationSettings.Controls.Add(customNotificationsPlayWindowsNotificationAudio);
            groupCustomNotificationSettings.Controls.Add(customNotificationsShowInDarkMode);
            groupCustomNotificationSettings.Controls.Add(customNotificationsShowTimeoutBar);
            groupCustomNotificationSettings.Location = new System.Drawing.Point(12, 276);
            groupCustomNotificationSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupCustomNotificationSettings.Name = "groupCustomNotificationSettings";
            groupCustomNotificationSettings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupCustomNotificationSettings.Size = new System.Drawing.Size(504, 98);
            groupCustomNotificationSettings.TabIndex = 10;
            groupCustomNotificationSettings.TabStop = false;
            // 
            // customNotificationsPlayWindowsNotificationAudio
            // 
            customNotificationsPlayWindowsNotificationAudio.AutoSize = true;
            customNotificationsPlayWindowsNotificationAudio.Location = new System.Drawing.Point(6, 69);
            customNotificationsPlayWindowsNotificationAudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            customNotificationsPlayWindowsNotificationAudio.Name = "customNotificationsPlayWindowsNotificationAudio";
            customNotificationsPlayWindowsNotificationAudio.Size = new System.Drawing.Size(152, 21);
            customNotificationsPlayWindowsNotificationAudio.TabIndex = 2;
            customNotificationsPlayWindowsNotificationAudio.Text = "播放Windows通知声音";
            customNotificationsPlayWindowsNotificationAudio.UseVisualStyleBackColor = true;
            customNotificationsPlayWindowsNotificationAudio.CheckedChanged += customNotificationsPlayWindowsNotificationAudio_CheckedChanged;
            // 
            // customNotificationsShowInDarkMode
            // 
            customNotificationsShowInDarkMode.AutoSize = true;
            customNotificationsShowInDarkMode.Location = new System.Drawing.Point(6, 42);
            customNotificationsShowInDarkMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            customNotificationsShowInDarkMode.Name = "customNotificationsShowInDarkMode";
            customNotificationsShowInDarkMode.Size = new System.Drawing.Size(147, 21);
            customNotificationsShowInDarkMode.TabIndex = 1;
            customNotificationsShowInDarkMode.Text = "在深色模式下显示通知";
            customNotificationsShowInDarkMode.UseVisualStyleBackColor = true;
            // 
            // customNotificationsShowTimeoutBar
            // 
            customNotificationsShowTimeoutBar.AutoSize = true;
            customNotificationsShowTimeoutBar.Location = new System.Drawing.Point(6, 16);
            customNotificationsShowTimeoutBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            customNotificationsShowTimeoutBar.Name = "customNotificationsShowTimeoutBar";
            customNotificationsShowTimeoutBar.Size = new System.Drawing.Size(159, 21);
            customNotificationsShowTimeoutBar.TabIndex = 0;
            customNotificationsShowTimeoutBar.Text = "在通知中显示超时进度条";
            customNotificationsShowTimeoutBar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 257);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 17);
            label1.TabIndex = 11;
            label1.Text = "自定义托盘通知设置";
            // 
            // groupNativeNotification
            // 
            groupNativeNotification.Controls.Add(nativeNotificationAutoCopy);
            groupNativeNotification.Location = new System.Drawing.Point(12, 380);
            groupNativeNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupNativeNotification.Name = "groupNativeNotification";
            groupNativeNotification.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            groupNativeNotification.Size = new System.Drawing.Size(504, 51);
            groupNativeNotification.TabIndex = 3;
            groupNativeNotification.TabStop = false;
            groupNativeNotification.Text = "Windows原生通知设置";
            groupNativeNotification.Enter += groupBox1_Enter;
            // 
            // nativeNotificationAutoCopy
            // 
            nativeNotificationAutoCopy.AutoSize = true;
            nativeNotificationAutoCopy.Location = new System.Drawing.Point(6, 21);
            nativeNotificationAutoCopy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            nativeNotificationAutoCopy.Name = "nativeNotificationAutoCopy";
            nativeNotificationAutoCopy.Size = new System.Drawing.Size(123, 21);
            nativeNotificationAutoCopy.TabIndex = 0;
            nativeNotificationAutoCopy.Text = "自动复制通知内容";
            nativeNotificationAutoCopy.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoStart
            // 
            checkBoxAutoStart.AutoSize = true;
            checkBoxAutoStart.Location = new System.Drawing.Point(18, 436);
            checkBoxAutoStart.Name = "checkBoxAutoStart";
            checkBoxAutoStart.Size = new System.Drawing.Size(99, 21);
            checkBoxAutoStart.TabIndex = 12;
            checkBoxAutoStart.Text = "开机自动启动";
            checkBoxAutoStart.UseVisualStyleBackColor = true;
            checkBoxAutoStart.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(531, 525);
            Controls.Add(checkBoxAutoStart);
            Controls.Add(groupNativeNotification);
            Controls.Add(label1);
            Controls.Add(groupCustomNotificationSettings);
            Controls.Add(nativeVersusCustomNotificationsGroupBox);
            Controls.Add(reconnectAttemptDelay);
            Controls.Add(reconnectAttemptDelayLabel);
            Controls.Add(reconnectAttempts);
            Controls.Add(reconnectAttemptsLabel);
            Controls.Add(timeout);
            Controls.Add(timeoutLabel);
            Controls.Add(buttonPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "设置";
            Load += SettingsDialog_Load;
            buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)timeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)reconnectAttempts).EndInit();
            ((System.ComponentModel.ISupportInitialize)reconnectAttemptDelay).EndInit();
            nativeVersusCustomNotificationsGroupBox.ResumeLayout(false);
            nativeVersusCustomNotificationsGroupBox.PerformLayout();
            groupCustomNotificationSettings.ResumeLayout(false);
            groupCustomNotificationSettings.PerformLayout();
            groupNativeNotification.ResumeLayout(false);
            groupNativeNotification.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Label timeoutLabel;
        private System.Windows.Forms.NumericUpDown timeout;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown reconnectAttempts;
        private System.Windows.Forms.Label reconnectAttemptsLabel;
        private System.Windows.Forms.NumericUpDown reconnectAttemptDelay;
        private System.Windows.Forms.Label reconnectAttemptDelayLabel;
        private System.Windows.Forms.GroupBox nativeVersusCustomNotificationsGroupBox;
        private System.Windows.Forms.RadioButton useCustomTrayNotifications;
        private System.Windows.Forms.RadioButton useNativeWindowsNotifications;
        private System.Windows.Forms.GroupBox groupCustomNotificationSettings;
        private System.Windows.Forms.CheckBox customNotificationsShowTimeoutBar;
        private System.Windows.Forms.CheckBox customNotificationsShowInDarkMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox customNotificationsPlayWindowsNotificationAudio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupNativeNotification;
        private System.Windows.Forms.CheckBox nativeNotificationAutoCopy;
        private System.Windows.Forms.CheckBox checkBoxAutoStart;
    }
}
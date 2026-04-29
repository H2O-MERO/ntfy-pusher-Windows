
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
            buttonPanel.Location = new System.Drawing.Point(0, 632);
            buttonPanel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new System.Drawing.Size(834, 82);
            buttonPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.Location = new System.Drawing.Point(570, 26);
            cancelButton.Margin = new System.Windows.Forms.Padding(5);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(118, 37);
            cancelButton.TabIndex = 2;
            cancelButton.Text = "取消";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(698, 26);
            saveButton.Margin = new System.Windows.Forms.Padding(5);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(118, 37);
            saveButton.TabIndex = 1;
            saveButton.Text = "保存";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Location = new System.Drawing.Point(20, 14);
            timeoutLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new System.Drawing.Size(443, 24);
            timeoutLabel.TabIndex = 3;
            timeoutLabel.Text = "通知提示超时（秒，使用-1表示需要手动关闭通知）：";
            timeoutLabel.Click += timeoutLabel_Click;
            // 
            // timeout
            // 
            timeout.Location = new System.Drawing.Point(20, 45);
            timeout.Margin = new System.Windows.Forms.Padding(5);
            timeout.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            timeout.Name = "timeout";
            timeout.Size = new System.Drawing.Size(795, 30);
            timeout.TabIndex = 4;
            // 
            // reconnectAttempts
            // 
            reconnectAttempts.Location = new System.Drawing.Point(19, 117);
            reconnectAttempts.Margin = new System.Windows.Forms.Padding(5);
            reconnectAttempts.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttempts.Name = "reconnectAttempts";
            reconnectAttempts.Size = new System.Drawing.Size(795, 30);
            reconnectAttempts.TabIndex = 6;
            // 
            // reconnectAttemptsLabel
            // 
            reconnectAttemptsLabel.AutoSize = true;
            reconnectAttemptsLabel.Location = new System.Drawing.Point(19, 86);
            reconnectAttemptsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            reconnectAttemptsLabel.Name = "reconnectAttemptsLabel";
            reconnectAttemptsLabel.Size = new System.Drawing.Size(388, 24);
            reconnectAttemptsLabel.TabIndex = 5;
            reconnectAttemptsLabel.Text = "最大重新连接重试尝试次数（需要重新启动）：";
            // 
            // reconnectAttemptDelay
            // 
            reconnectAttemptDelay.Location = new System.Drawing.Point(19, 189);
            reconnectAttemptDelay.Margin = new System.Windows.Forms.Padding(5);
            reconnectAttemptDelay.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttemptDelay.Name = "reconnectAttemptDelay";
            reconnectAttemptDelay.Size = new System.Drawing.Size(795, 30);
            reconnectAttemptDelay.TabIndex = 8;
            // 
            // reconnectAttemptDelayLabel
            // 
            reconnectAttemptDelayLabel.AutoSize = true;
            reconnectAttemptDelayLabel.Location = new System.Drawing.Point(19, 158);
            reconnectAttemptDelayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            reconnectAttemptDelayLabel.Name = "reconnectAttemptDelayLabel";
            reconnectAttemptDelayLabel.Size = new System.Drawing.Size(334, 24);
            reconnectAttemptDelayLabel.TabIndex = 7;
            reconnectAttemptDelayLabel.Text = "尝试之间的延迟（秒，需要重新启动）：";
            // 
            // nativeVersusCustomNotificationsGroupBox
            // 
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useCustomTrayNotifications);
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useNativeWindowsNotifications);
            nativeVersusCustomNotificationsGroupBox.Location = new System.Drawing.Point(19, 235);
            nativeVersusCustomNotificationsGroupBox.Margin = new System.Windows.Forms.Padding(5);
            nativeVersusCustomNotificationsGroupBox.Name = "nativeVersusCustomNotificationsGroupBox";
            nativeVersusCustomNotificationsGroupBox.Padding = new System.Windows.Forms.Padding(5);
            nativeVersusCustomNotificationsGroupBox.Size = new System.Drawing.Size(795, 107);
            nativeVersusCustomNotificationsGroupBox.TabIndex = 9;
            nativeVersusCustomNotificationsGroupBox.TabStop = false;
            // 
            // useCustomTrayNotifications
            // 
            useCustomTrayNotifications.AutoSize = true;
            useCustomTrayNotifications.Location = new System.Drawing.Point(9, 64);
            useCustomTrayNotifications.Margin = new System.Windows.Forms.Padding(5);
            useCustomTrayNotifications.Name = "useCustomTrayNotifications";
            useCustomTrayNotifications.Size = new System.Drawing.Size(423, 28);
            useCustomTrayNotifications.TabIndex = 1;
            useCustomTrayNotifications.TabStop = true;
            useCustomTrayNotifications.Text = "使用ntfysh-windows自定义托盘通知（不推荐）";
            useCustomTrayNotifications.UseVisualStyleBackColor = true;
            useCustomTrayNotifications.CheckedChanged += UseCustomTrayNotifications_CheckedChanged;
            // 
            // useNativeWindowsNotifications
            // 
            useNativeWindowsNotifications.AutoSize = true;
            useNativeWindowsNotifications.Location = new System.Drawing.Point(9, 24);
            useNativeWindowsNotifications.Margin = new System.Windows.Forms.Padding(5);
            useNativeWindowsNotifications.Name = "useNativeWindowsNotifications";
            useNativeWindowsNotifications.Size = new System.Drawing.Size(294, 28);
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
            groupCustomNotificationSettings.Location = new System.Drawing.Point(19, 389);
            groupCustomNotificationSettings.Margin = new System.Windows.Forms.Padding(5);
            groupCustomNotificationSettings.Name = "groupCustomNotificationSettings";
            groupCustomNotificationSettings.Padding = new System.Windows.Forms.Padding(5);
            groupCustomNotificationSettings.Size = new System.Drawing.Size(792, 139);
            groupCustomNotificationSettings.TabIndex = 10;
            groupCustomNotificationSettings.TabStop = false;
            // 
            // customNotificationsPlayWindowsNotificationAudio
            // 
            customNotificationsPlayWindowsNotificationAudio.AutoSize = true;
            customNotificationsPlayWindowsNotificationAudio.Location = new System.Drawing.Point(9, 97);
            customNotificationsPlayWindowsNotificationAudio.Margin = new System.Windows.Forms.Padding(5);
            customNotificationsPlayWindowsNotificationAudio.Name = "customNotificationsPlayWindowsNotificationAudio";
            customNotificationsPlayWindowsNotificationAudio.Size = new System.Drawing.Size(223, 28);
            customNotificationsPlayWindowsNotificationAudio.TabIndex = 2;
            customNotificationsPlayWindowsNotificationAudio.Text = "播放Windows通知声音";
            customNotificationsPlayWindowsNotificationAudio.UseVisualStyleBackColor = true;
            customNotificationsPlayWindowsNotificationAudio.CheckedChanged += customNotificationsPlayWindowsNotificationAudio_CheckedChanged;
            // 
            // customNotificationsShowInDarkMode
            // 
            customNotificationsShowInDarkMode.AutoSize = true;
            customNotificationsShowInDarkMode.Location = new System.Drawing.Point(9, 59);
            customNotificationsShowInDarkMode.Margin = new System.Windows.Forms.Padding(5);
            customNotificationsShowInDarkMode.Name = "customNotificationsShowInDarkMode";
            customNotificationsShowInDarkMode.Size = new System.Drawing.Size(216, 28);
            customNotificationsShowInDarkMode.TabIndex = 1;
            customNotificationsShowInDarkMode.Text = "在深色模式下显示通知";
            customNotificationsShowInDarkMode.UseVisualStyleBackColor = true;
            // 
            // customNotificationsShowTimeoutBar
            // 
            customNotificationsShowTimeoutBar.AutoSize = true;
            customNotificationsShowTimeoutBar.Location = new System.Drawing.Point(9, 22);
            customNotificationsShowTimeoutBar.Margin = new System.Windows.Forms.Padding(5);
            customNotificationsShowTimeoutBar.Name = "customNotificationsShowTimeoutBar";
            customNotificationsShowTimeoutBar.Size = new System.Drawing.Size(234, 28);
            customNotificationsShowTimeoutBar.TabIndex = 0;
            customNotificationsShowTimeoutBar.Text = "在通知中显示超时进度条";
            customNotificationsShowTimeoutBar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 363);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 24);
            label1.TabIndex = 11;
            label1.Text = "自定义托盘通知设置";
            // 
            // groupNativeNotification
            // 
            groupNativeNotification.Controls.Add(nativeNotificationAutoCopy);
            groupNativeNotification.Location = new System.Drawing.Point(19, 536);
            groupNativeNotification.Name = "groupNativeNotification";
            groupNativeNotification.Size = new System.Drawing.Size(792, 72);
            groupNativeNotification.TabIndex = 3;
            groupNativeNotification.TabStop = false;
            groupNativeNotification.Text = "Windows原生通知设置";
            groupNativeNotification.Enter += groupBox1_Enter;
            // 
            // nativeNotificationAutoCopy
            // 
            nativeNotificationAutoCopy.AutoSize = true;
            nativeNotificationAutoCopy.Location = new System.Drawing.Point(9, 29);
            nativeNotificationAutoCopy.Name = "nativeNotificationAutoCopy";
            nativeNotificationAutoCopy.Size = new System.Drawing.Size(270, 28);
            nativeNotificationAutoCopy.TabIndex = 0;
            nativeNotificationAutoCopy.Text = "自动复制通知内容";
            nativeNotificationAutoCopy.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(834, 714);
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
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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
    }
}
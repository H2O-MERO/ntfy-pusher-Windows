
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
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
            comboBoxLanguage = new System.Windows.Forms.ComboBox();
            languageLabel = new System.Windows.Forms.Label();
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
            resources.ApplyResources(buttonPanel, "buttonPanel");
            buttonPanel.BackColor = System.Drawing.SystemColors.Control;
            buttonPanel.Controls.Add(cancelButton);
            buttonPanel.Controls.Add(saveButton);
            buttonPanel.Name = "buttonPanel";
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // timeoutLabel
            // 
            resources.ApplyResources(timeoutLabel, "timeoutLabel");
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Click += timeoutLabel_Click;
            // 
            // timeout
            // 
            resources.ApplyResources(timeout, "timeout");
            timeout.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            timeout.Name = "timeout";
            // 
            // reconnectAttempts
            // 
            resources.ApplyResources(reconnectAttempts, "reconnectAttempts");
            reconnectAttempts.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttempts.Name = "reconnectAttempts";
            // 
            // reconnectAttemptsLabel
            // 
            resources.ApplyResources(reconnectAttemptsLabel, "reconnectAttemptsLabel");
            reconnectAttemptsLabel.Name = "reconnectAttemptsLabel";
            // 
            // reconnectAttemptDelay
            // 
            resources.ApplyResources(reconnectAttemptDelay, "reconnectAttemptDelay");
            reconnectAttemptDelay.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            reconnectAttemptDelay.Name = "reconnectAttemptDelay";
            // 
            // reconnectAttemptDelayLabel
            // 
            resources.ApplyResources(reconnectAttemptDelayLabel, "reconnectAttemptDelayLabel");
            reconnectAttemptDelayLabel.Name = "reconnectAttemptDelayLabel";
            // 
            // nativeVersusCustomNotificationsGroupBox
            // 
            resources.ApplyResources(nativeVersusCustomNotificationsGroupBox, "nativeVersusCustomNotificationsGroupBox");
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useCustomTrayNotifications);
            nativeVersusCustomNotificationsGroupBox.Controls.Add(useNativeWindowsNotifications);
            nativeVersusCustomNotificationsGroupBox.Name = "nativeVersusCustomNotificationsGroupBox";
            nativeVersusCustomNotificationsGroupBox.TabStop = false;
            // 
            // useCustomTrayNotifications
            // 
            resources.ApplyResources(useCustomTrayNotifications, "useCustomTrayNotifications");
            useCustomTrayNotifications.Name = "useCustomTrayNotifications";
            useCustomTrayNotifications.TabStop = true;
            useCustomTrayNotifications.UseVisualStyleBackColor = true;
            useCustomTrayNotifications.CheckedChanged += UseCustomTrayNotifications_CheckedChanged;
            // 
            // useNativeWindowsNotifications
            // 
            resources.ApplyResources(useNativeWindowsNotifications, "useNativeWindowsNotifications");
            useNativeWindowsNotifications.Name = "useNativeWindowsNotifications";
            useNativeWindowsNotifications.TabStop = true;
            useNativeWindowsNotifications.UseVisualStyleBackColor = true;
            // 
            // groupCustomNotificationSettings
            // 
            resources.ApplyResources(groupCustomNotificationSettings, "groupCustomNotificationSettings");
            groupCustomNotificationSettings.Controls.Add(customNotificationsPlayWindowsNotificationAudio);
            groupCustomNotificationSettings.Controls.Add(customNotificationsShowInDarkMode);
            groupCustomNotificationSettings.Controls.Add(customNotificationsShowTimeoutBar);
            groupCustomNotificationSettings.Name = "groupCustomNotificationSettings";
            groupCustomNotificationSettings.TabStop = false;
            // 
            // customNotificationsPlayWindowsNotificationAudio
            // 
            resources.ApplyResources(customNotificationsPlayWindowsNotificationAudio, "customNotificationsPlayWindowsNotificationAudio");
            customNotificationsPlayWindowsNotificationAudio.Name = "customNotificationsPlayWindowsNotificationAudio";
            customNotificationsPlayWindowsNotificationAudio.UseVisualStyleBackColor = true;
            customNotificationsPlayWindowsNotificationAudio.CheckedChanged += customNotificationsPlayWindowsNotificationAudio_CheckedChanged;
            // 
            // customNotificationsShowInDarkMode
            // 
            resources.ApplyResources(customNotificationsShowInDarkMode, "customNotificationsShowInDarkMode");
            customNotificationsShowInDarkMode.Name = "customNotificationsShowInDarkMode";
            customNotificationsShowInDarkMode.UseVisualStyleBackColor = true;
            // 
            // customNotificationsShowTimeoutBar
            // 
            resources.ApplyResources(customNotificationsShowTimeoutBar, "customNotificationsShowTimeoutBar");
            customNotificationsShowTimeoutBar.Name = "customNotificationsShowTimeoutBar";
            customNotificationsShowTimeoutBar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // groupNativeNotification
            // 
            resources.ApplyResources(groupNativeNotification, "groupNativeNotification");
            groupNativeNotification.Controls.Add(nativeNotificationAutoCopy);
            groupNativeNotification.Name = "groupNativeNotification";
            groupNativeNotification.TabStop = false;
            groupNativeNotification.Enter += groupBox1_Enter;
            // 
            // nativeNotificationAutoCopy
            // 
            resources.ApplyResources(nativeNotificationAutoCopy, "nativeNotificationAutoCopy");
            nativeNotificationAutoCopy.Name = "nativeNotificationAutoCopy";
            nativeNotificationAutoCopy.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoStart
            // 
            resources.ApplyResources(checkBoxAutoStart, "checkBoxAutoStart");
            checkBoxAutoStart.Name = "checkBoxAutoStart";
            checkBoxAutoStart.UseVisualStyleBackColor = true;
            checkBoxAutoStart.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBoxLanguage
            // 
            resources.ApplyResources(comboBoxLanguage, "comboBoxLanguage");
            comboBoxLanguage.Name = "comboBoxLanguage";
            comboBoxLanguage.SelectedIndexChanged += languageComboBox_SelectedIndexChanged;
            // 
            // languageLabel
            // 
            resources.ApplyResources(languageLabel, "languageLabel");
            languageLabel.Name = "languageLabel";
            languageLabel.Click += label3_Click;
            // 
            // SettingsDialog
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(languageLabel);
            Controls.Add(comboBoxLanguage);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
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
        private System.Windows.Forms.ComboBox comboBoxLanguage; 
        private System.Windows.Forms.Label languageLabel;
    }
}
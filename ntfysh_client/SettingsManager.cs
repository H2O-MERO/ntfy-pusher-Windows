using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ntfysh_client
{
    public static class SettingsManager
    {
        private static string GetSettingsFilePath()
        {
            string binaryDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                ?? throw new InvalidOperationException("无法确定应用程序目录");
            return Path.Combine(binaryDirectory, "settings.json");
        }

        private static SettingsModel GetDefaultSettings() => new()
        {
            Revision = 3,
            Timeout = 5,
            ReconnectAttempts = 10,
            ReconnectAttemptDelay = 3,
            NotificationsMethod = SettingsModel.NotificationsType.NativeWindows,
            CustomTrayNotificationsShowTimeoutBar = true,
            CustomTrayNotificationsShowInDarkMode = false,
            CustomTrayNotificationsPlayDefaultWindowsSound = true,
            NativeNotificationsAutoCopyToClipboard = false,
            AutoStartEnabled = false,
            Language = "zh-CN"
        };

        private static void MergeSettingsRevisions(SettingsModel older, SettingsModel newer)
        {
            if (older.Revision < 1)
            {
                older.ReconnectAttempts = newer.ReconnectAttempts;
                older.ReconnectAttemptDelay = newer.ReconnectAttemptDelay;
            }
            if (older.Revision < 2)
            {
                older.NotificationsMethod = newer.NotificationsMethod;
                older.CustomTrayNotificationsShowTimeoutBar = newer.CustomTrayNotificationsShowTimeoutBar;
                older.CustomTrayNotificationsShowInDarkMode = newer.CustomTrayNotificationsShowInDarkMode;
                older.CustomTrayNotificationsPlayDefaultWindowsSound = newer.CustomTrayNotificationsPlayDefaultWindowsSound;
            }
            if (older.Revision < 3)
            {
                older.NativeNotificationsAutoCopyToClipboard = newer.NativeNotificationsAutoCopyToClipboard;
                older.AutoStartEnabled = newer.AutoStartEnabled;
                older.Language = newer.Language;
            }
            older.Revision = newer.Revision;
        }

        public static SettingsModel LoadSettings()
        {
            string settingsFilePath = GetSettingsFilePath();
            SettingsModel defaultSettings = GetDefaultSettings();

            if (!File.Exists(settingsFilePath))
            {
                SaveSettings(defaultSettings);
                return defaultSettings;
            }

            string settingsSerialised = File.ReadAllText(settingsFilePath);
            if (string.IsNullOrWhiteSpace(settingsSerialised))
            {
                SaveSettings(defaultSettings);
                return defaultSettings;
            }

            SettingsModel? settings = JsonConvert.DeserializeObject<SettingsModel>(settingsSerialised);
            if (settings is null)
            {
                SaveSettings(defaultSettings);
                return defaultSettings;
            }

            if (settings.Revision < defaultSettings.Revision)
            {
                MergeSettingsRevisions(settings, defaultSettings);
                SaveSettings(settings);
            }

            return settings;
        }

        public static void SaveSettings(SettingsModel settings)
        {
            string settingsFilePath = GetSettingsFilePath();
            string settingsSerialised = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(settingsFilePath, settingsSerialised);
        }
    }
}
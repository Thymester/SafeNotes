// File: SafeNotes/CustomConfig.cs
using System;
using System.IO;
using Newtonsoft.Json;

namespace SafeNotes
{
    public class CustomConfig
    {
        private static readonly string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SafeNotes", "config.json");

        public string UserPassword { get; set; } = string.Empty;
        public string YourName { get; set; } = string.Empty;
        public string EntryText { get; set; } = string.Empty;
        public string NotepadSaveText { get; set; } = string.Empty;
        public bool SaveDate { get; set; } = true;
        public bool DisableNotifications { get; set; } = false;
        public bool LightMode { get; set; } = false;
        public bool IsUserLoggedIn { get; set; } = false;
        public bool FirstTimeOpened { get; set; } = true;
        public bool RequirePinCode { get; set; } = false;
        public string PinCode { get; set; } = string.Empty;
        public string Entries { get; set; } = string.Empty;
        public bool IsRestartingForUpdate { get; set; } = false;
        public bool MinimizeToTray { get; set; } = false;
        public bool AutoLockSetting { get; set; } = false;
        public bool OneMinLockSetting { get; set; } = false;
        public bool TwoMinLockSetting { get; set; } = false;
        public bool ThreeMinLockSetting { get; set; } = false;
        public bool FiveMinLockSetting { get; set; } = false;
        public bool TenMinLockSetting { get; set; } = false;

        public static CustomConfig Load()
        {
            if (File.Exists(configFilePath))
            {
                string json = File.ReadAllText(configFilePath);
                return JsonConvert.DeserializeObject<CustomConfig>(json);
            }
            return new CustomConfig();
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            Directory.CreateDirectory(Path.GetDirectoryName(configFilePath));
            File.WriteAllText(configFilePath, json);
        }
    }
}

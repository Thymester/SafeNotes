// File: SafeNotes/CustomConfig.cs
using System;
using System.IO;
using Newtonsoft.Json;

namespace SafeNotes
{
    public class CustomConfig
    {
        private static readonly string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SafeNotes", "config.json");

        public string setUserPassword { get; set; }
        public string setYourName { get; set; }
        public string setEntryText { get; set; }
        public string notepadSaveText { get; set; }
        public bool setLightMode { get; set; }
        public bool setSaveDate { get; set; }
        public bool setIsUserLoggedIn { get; set; }
        public string setEntriesShow { get; set; }
        public string setEntriesHide { get; set; }
        public bool firstTimeOpened { get; set; }

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

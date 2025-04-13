using System;
using System.IO;
using Newtonsoft.Json;

public static class SettingsManager
{
    private static readonly string AppDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SafeNotes");
    private static readonly string SettingsFilePath = Path.Combine(AppDataFolder, "appsettings.json");

    public static AppSettings LoadSettings()
    {
        if (!Directory.Exists(AppDataFolder))
        {
            Directory.CreateDirectory(AppDataFolder);
        }

        if (File.Exists(SettingsFilePath))
        {
            string json = File.ReadAllText(SettingsFilePath);
            return JsonConvert.DeserializeObject<AppSettings>(json);
        }
        else
        {
            return new AppSettings();
        }
    }

    public static void SaveSettings(AppSettings settings)
    {
        if (!Directory.Exists(AppDataFolder))
        {
            Directory.CreateDirectory(AppDataFolder);
        }

        string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
        File.WriteAllText(SettingsFilePath, json);
    }
}

// File: SafeNotes/Utilities.cs
using System;
using System.IO;
using System.Linq;

namespace SafeNotes
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        private void UpdateEntriesCountAndSaveToFile()
        {
            // Update the savedEntriesCount label
            SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();
        }

        private string FindManagerPath(string managerName)
        {
            string[] paths = {
                Path.Combine("C:\\Program Files", managerName, managerName + ".exe"),
                Path.Combine("C:\\Program Files (x86)", managerName, managerName + ".exe")
            };

            // Check in Program Files and Program Files (x86)
            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            // Check AppData\Local and all subdirectories
            string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), managerName);
            if (Directory.Exists(appDataPath))
            {
                string[] exeFiles = Directory.GetFiles(appDataPath, "*.exe", SearchOption.AllDirectories)
                             .Where(f => Path.GetFileName(f).ToLower().Contains(managerName.ToLower()))
                             .ToArray();
                if (exeFiles.Length > 0)
                {
                    return exeFiles[0];
                }
            }
            return null;
        }

        private string GetManagerArgs(string managerName)
        {
            switch (managerName)
            {
                case "Bitwarden":
                    return "--password" + UserPassword.Text;
                case "KeePass Password Safe 2":
                    return "\"-pw=\"" + UserPassword.Text + "\"";
                case "1Password":
                    return "--password" + UserPassword.Text;
                case "LastPass":
                    return "--password" + UserPassword.Text;
                case "ProtonPass":
                    return "--password" + UserPassword.Text;
                case "NordPass":
                    return "--password" + UserPassword.Text;
                case "Dashlane":
                    return "--password" + UserPassword.Text;
                case "Zoho Vault":
                    return "--password" + UserPassword.Text;
                case "RoboForm":
                    return "--password" + UserPassword.Text;
                case "Sticky Password":
                    return "--password" + UserPassword.Text;
                case "Keeper":
                    return "--password" + UserPassword.Text;
                case "Enpass":
                    return "--password" + UserPassword.Text;
                case "Total Password":
                    return "--password" + UserPassword.Text;
                default:
                    return null;
            }
        }
    }
}

// File: SafeNotes/Utilities.cs
using System;
using System.IO;

namespace SafeNotes
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        private void UpdateEntriesCountAndSaveToFile()
        {
            // Update the savedEntriesCount label
            SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();

            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(exeDirectory, "entries.txt");

            // Now save all entries to a txt file in the location of the application's .exe
            string[] entries = new string[EntriesListBox.Items.Count];
            for (int i = 0; i < EntriesListBox.Items.Count; i++)
            {
                // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                entries[i] = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
            }
            System.IO.File.WriteAllLines(filePath, entries);
        }

        private string FindManagerPath(string managerName)
        {
            string[] paths = {
            "C:\\Program Files\\" + managerName + "\\" + managerName + ".exe",
            "C:\\Program Files (x86)\\" + managerName + "\\" + managerName + ".exe"
            };

            foreach (string path in paths)
            {
                if (File.Exists(path))
                {
                    return path;
                }
            }

            return null;
        }

        private string GetManagerArgs(string managerName)
        {
            switch (managerName)
            {
                case "Bitwarden":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "KeePass Password Safe 2":
                    return "\" -user=\"" + UserPassword.Text + "\" -pw=\"" + UserConfirmPassword.Text + "\"";
                case "1Password":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "LastPass":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "ProtonPass":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "NordPass":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Dashlane":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Zoho Vault":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "RoboForm":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Sticky Password":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Keeper":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Enpass":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                case "Total Password":
                    return "--username " + UserPassword.Text + " --password " + UserConfirmPassword.Text;
                default:
                    return null;
            }
        }
    }
}

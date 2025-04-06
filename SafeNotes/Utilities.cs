// File: SafeNotes/Utilities.cs
using System;
using System.IO;

namespace SafeNotes
{
    public partial class mainForm : MaterialSkin.Controls.MaterialForm
    {
        private void UpdateEntriesCountAndSaveToFile()
        {
            // Update the savedEntriesCount label
            savedEntriesCount.Text = "Saved entries: " + entriesListBox.Items.Count.ToString();

            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(exeDirectory, "entries.txt");

            // Now save all entries to a txt file in the location of the application's .exe
            string[] entries = new string[entriesListBox.Items.Count];
            for (int i = 0; i < entriesListBox.Items.Count; i++)
            {
                // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                entries[i] = entriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
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
                    return "--username " + userPassword.Text + " --password " + userConfirmPassword.Text;
                case "KeePass Password Safe 2":
                    return "\" -user=\"" + userPassword.Text + "\" -pw=\"" + userConfirmPassword.Text + "\"";
                case "1Password":
                    return "--username " + userPassword.Text + " --password " + userConfirmPassword.Text;
                case "LastPass":
                    return "--username " + userPassword.Text + " --password " + userConfirmPassword.Text;
                case "ProtonPass":
                    return "--username " + userPassword.Text + " --password " + userConfirmPassword.Text;
                case "NordPass":
                    return "--username " + userPassword.Text + " --password " + userConfirmPassword.Text;
                default:
                    return null;
            }
        }
    }
}

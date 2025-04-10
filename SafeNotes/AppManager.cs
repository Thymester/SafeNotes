// File: SafeNotes/EventHandlers.cs
using MaterialSkin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace SafeNotes
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        private async void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "SafeNotes - v" + Application.ProductVersion;
            LoginTabSelector.Visible = false;

            if (!Properties.Settings.Default.setIsUserLoggedIn)
            {
                LoginTabSelector.Visible = false;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                UserLoginButton.Text = "Login";
                UserConfirmPassword.Visible = false;
                UserPassword.Location = new System.Drawing.Point(300, 150);
            }

            if (UserLoginButton.Text == "Register")
            {
                PasswordGenBox.Visible = true;
                RegenPassButton.Visible = true;
            }

            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.setYourName))
            {
                YourNameBox.ReadOnly = false;
            }
            else
            {
                YourNameBox.ReadOnly = true;
            }

            var updater = new EventHandlerClass();
            await updater.CheckForUpdatesAsync();

            JournalEntryBox.Text = Properties.Settings.Default.setEntryText;
            YourNameBox.Text = Properties.Settings.Default.setYourName;
            NotepadTextBox.Text = Properties.Settings.Default.notepadSaveText;
            LightModeCheckbox.Checked = Properties.Settings.Default.setLightMode;
            ApplyDateCheckbox.Checked = Properties.Settings.Default.setSaveDate;
            Properties.Settings.Default.setEntriesShow = Properties.Settings.Default.setEntriesHide;
            Properties.Settings.Default.firstTimeOpened = Properties.Settings.Default.firstTimeOpened;
        }
        
        private const int MaxEntries = 100;

        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            if (EntriesListBox.Items.Count >= MaxEntries)
            {
                MessageBox.Show($"You cannot add more than {MaxEntries} entries.", "Entry Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SaveEntryButton.Text == "Save Edit")
            {
                if (JournalEntryBox.Text != "")
                {
                    EditEntryButton.Size = new Size(107, 36);
                    // Ensure that an item is selected
                    if (EntriesListBox.SelectedItems.Count > 0)
                    {
                        // Modify the text of the selected item in the entriesListBox
                        string editedText = JournalEntryBox.Text;
                        if (ApplyDateCheckbox.Checked)
                        {
                            // Add the new date and time to the edited text
                            editedText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + editedText;

                            // Show a notification that the entry has been edited
                            Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                            notiPopup.TitleText = "SafeNotes";
                            notiPopup.ContentText = "Entry edited";
                            notiPopup.Popup();
                        }

                        EntriesListBox.SelectedItems[0].Text = editedText;
                        // Reset button text to "Save Entry" after editing
                        SaveEntryButton.Text = "Save Entry";
                        // Clear the journal entry box
                        JournalEntryBox.Text = "";
                        // Show the editEntryButton again
                        EditEntryButton.Show();
                        // Update the entries count label and save entries to file
                        UpdateEntriesCountAndSaveToFile();
                        // Programmatically switch to the "Journal Entries" tab
                        TabControl.SelectedTab = JournalEntriesPage;
                        // Enable the tabControl
                        JournalTabSelector.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot save an empty entry.", "Empty Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (DecryptionStatusLabel.Text != "Decrypting..." && SaveEntryButton.Text == "Save Entry")
            {
                if (JournalEntryBox.Text != "")
                {
                    // Add new entry
                    string newEntryText = JournalEntryBox.Text;
                    if (ApplyDateCheckbox.Checked)
                    {
                        newEntryText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + newEntryText;

                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "Entry added";
                        notiPopup.Popup();
                    }

                    // Add the new entry to the entriesListBox
                    EntriesListBox.Items.Add(newEntryText);
                    // Clear the journal entry box
                    JournalEntryBox.Text = "";
                    // Update the entries count label and save entries to file
                    UpdateEntriesCountAndSaveToFile();

                    if (EntriesListBox.Items.Count > 1)
                    {
                        DeleteEntriesButton.Enabled = true;
                    }
                    else
                    {
                        DeleteEntriesButton.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("You cannot save an empty entry.", "Empty Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            if (ChangeNameButton.Text == "Save name")
            {
                // If the contents of the yourNameBox is empty, show a message box with the text "You cannot save an empty name"
                if (string.IsNullOrWhiteSpace(YourNameBox.Text))
                {
                    MessageBox.Show("You can not save an empty name.", "Empty name", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    // Save the text in the yourNameBox to setYourName setting when the name is saved
                    YourNameBox.ReadOnly = true;
                    ChangeNameButton.Text = "Change name";
                    ChangeNameButton.Visible = false;
                    ChangeNameButton.Visible = true;
                    Properties.Settings.Default.setYourName = YourNameBox.Text;
                    Properties.Settings.Default.Save();

                    // Show a notification that the name has been saved
                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Name saved";
                    notiPopup.Popup();
                }
            }
            else if (ChangeNameButton.Text == "Change name")
            {
                YourNameBox.Text = "";
                YourNameBox.ReadOnly = false;
                ChangeNameButton.Text = "Save name";
                ChangeNameButton.Visible = false;
                ChangeNameButton.Visible = true;
                Properties.Settings.Default.setYourName = YourNameBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void JournalEntryPage_Click(object sender, EventArgs e)
        {
            this.ActiveControl = JournalEntryBox;
        }

        private void JournalEntryBox_TextChanged(object sender, System.EventArgs e)
        {
            if (JournalEntryBox.Text.Contains("\n"))
            {
                // Restrict columns in the JournalEntryBox
                JournalEntryBox.Text = JournalEntryBox.Text.Replace("\n", "");
                JournalEntryBox.SelectionStart = JournalEntryBox.Text.Length;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ensure the JournalEntryPage is selected before closing and encrypting
            if (TabControl.SelectedTab != JournalEntryPage)
            {
                TabControl.SelectedTab = JournalEntryPage;
                Application.DoEvents(); // Ensure the tab change is processed
            }

            // Show the decryption status label with encryption message
            DecryptionStatusLabel.Text = "Encrypting files...";
            DecryptionStatusLabel.Visible = true;
            Application.DoEvents(); // Ensure the label is updated immediately

            if (File.Exists("entries.txt") && Properties.Settings.Default.setEntriesShow == null && Properties.Settings.Default.setEntriesShow == null)
            {
                File.Delete("entries.txt");
            }

            if (!string.IsNullOrWhiteSpace(NotepadTextBox.Text))
            {
                // If NotepadTextBox.Text is not empty, ask user if they want to save the notepad
                DialogResult dialogResult = MessageBox.Show("Do you want to save your notepad before closing the application?", "Save notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    SaveNotepadButton.PerformClick();
                    NotepadTextBox.Text = null;
                    Application.Exit();
                }
                if (dialogResult == DialogResult.No)
                {
                    NotepadTextBox.Text = null;
                    Application.Exit();
                }
            }

            if (EntriesListBox.Items.Count != 0)
            {
                // Save the text in the entries.txt file and then hide the text in the file with *'s
                string[] entries = new string[EntriesListBox.Items.Count];
                for (int i = 0; i < EntriesListBox.Items.Count; i++)
                {
                    // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                    string entryText = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                    entries[i] = EncryptString(entryText, Properties.Settings.Default.setSaltedDecryptionKey);
                }
                File.WriteAllLines("entries.txt", entries);
                // Save the text in the entries.txt file in the setEntriesHide setting
                Properties.Settings.Default.setEntriesHide = File.ReadAllText("entries.txt");
                Properties.Settings.Default.Save();
                string[] lines = File.ReadAllLines("entries.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    lines[i] = lines[i].Replace(lines[i], "******** - Please refrain from editing this file as any changes made may result in the loss of your saved entries.");
                }
                File.WriteAllLines("entries.txt", lines);
            }

            if (ResetAccountCheckbox.Checked == true)
            {
                Properties.Settings.Default.setUserPassword = "";
                Properties.Settings.Default.setEntriesHide = "";
                Properties.Settings.Default.setEntriesShow = "";
                Properties.Settings.Default.setYourName = "";
                Properties.Settings.Default.setEntryText = "";
                Properties.Settings.Default.notepadSaveText = "";
                Properties.Settings.Default.setSaltedDecryptionKey = "";
                Properties.Settings.Default.setSaveDate = true;
                Properties.Settings.Default.firstTimeOpened = true;
                Properties.Settings.Default.setIsUserLoggedIn = false;
                Properties.Settings.Default.setLightMode = false;
                // Delete the entries.txt file
                File.Delete("entries.txt");
                Properties.Settings.Default.Save();
            }

            // Hide the decryption status label after encryption is done
            DecryptionStatusLabel.Visible = false;
        }

        private void EntriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When the user double clicks on an entry in the entriesListBox, show a message box asking if the user wants to delete the entry
            if (EntriesListBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this entry?", "SafeNotes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Remove the selected item from the entriesListBox
                    EntriesListBox.Items.Remove(EntriesListBox.SelectedItems[0]);
                    // Now save this entry to a txt file in the location of the applications .exe
                    string[] entries = new string[EntriesListBox.Items.Count];
                    // Update the savedEntriesCount label
                    SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();
                    for (int i = 0; i < EntriesListBox.Items.Count; i++)
                    {
                        // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                        entries[i] = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                    }
                    File.WriteAllLines("entries.txt", entries);

                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Entry deleted";
                    notiPopup.Popup();
                }
            }
        }

        private void LightModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // If lightModeCheckbox is checked, save the value to setLightMode setting. When the value is saved, change the form and all the modules to light mode
            if (LightModeCheckbox.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Properties.Settings.Default.setLightMode = true;
                Properties.Settings.Default.Save();
            }
            else if (LightModeCheckbox.Checked == false)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                Properties.Settings.Default.setLightMode = false;
                Properties.Settings.Default.Save();
            }
        }

        private void ApplyDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ApplyDateCheckbox.Checked == true)
            {
                Properties.Settings.Default.setSaveDate = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.setSaveDate = false;
                Properties.Settings.Default.Save();
            }
        }

        private void SettingsPage_Click(object sender, EventArgs e)
        {
            // If the settingsPage is clicked, unfocus from everything and focus on the settingsPage
            this.ActiveControl = SettingsPage;
        }

        private void ResetLoginStatusButton_Click(object sender, EventArgs e)
        {
            // Reload the application and reset the login status
            Properties.Settings.Default.setIsUserLoggedIn = false;
            Application.Restart();
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserPassword.Text) && string.IsNullOrWhiteSpace(UserConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // If the userLoginButton.Text is "Register", apply the text in userPassword to the setPassword setting as long as userPassword and userConfirmPassword match
            else if (UserLoginButton.Text == "Register" && string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                if (UserPassword.Text == UserConfirmPassword.Text)
                {
                    string hashedPassword = HashPassword(UserPassword.Text);
                    Properties.Settings.Default.setUserPassword = hashedPassword;
                    Properties.Settings.Default.setSaltedDecryptionKey = HashPassword(hashedPassword + "SaltValue");
                    Properties.Settings.Default.Save();
                    UserConfirmPassword.Visible = false;
                    UserLoginButton.Text = "Login";
                    UserPassword.Location = new System.Drawing.Point(300, 150);
                }
            }
            else if (UserLoginButton.Text == "Login" && !string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                string hashedInputPassword = HashPassword(UserPassword.Text);
                if (hashedInputPassword == Properties.Settings.Default.setUserPassword)
                {
                    // Show that the user is logged in and make the entriesListBox visible
                    Properties.Settings.Default.setIsUserLoggedIn = true;
                    EntriesListBox.Visible = true;
                    UserLoginButton.Enabled = false;
                    LoginTabSelector.Enabled = true;
                    TabControl.TabPages.Remove(LoginPage);
                    // If the entries.txt file exists, load the entries into the entriesListBox from the setEntriesShow setting
                    if (File.Exists("entries.txt"))
                    {
                        // Load text from setEntriesShow setting into the entries.txt file and then load the entries from the entries.txt file into the entriesListBox
                        File.WriteAllText("entries.txt", Properties.Settings.Default.setEntriesShow);
                        // Add the entries from the entries.txt file to the entriesListBox
                        string[] entries = File.ReadAllLines("entries.txt");
                        foreach (string entry in entries)
                        {
                            try
                            {
                                string decryptedText = DecryptString(entry, Properties.Settings.Default.setSaltedDecryptionKey);
                                EntriesListBox.Items.Add(decryptedText);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error decrypting entry: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (EntriesListBox.Items.Count > 1)
                    {
                        DeleteEntriesButton.Visible = true;
                    }
                }
                else if (UserPassword.Text == Properties.Settings.Default.setUserPassword)
                {
                    // Hash the plain text password and save it
                    Properties.Settings.Default.setUserPassword = HashPassword(UserPassword.Text);
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Password has been hashed for security.", "Password Hashed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserLoginButton.PerformClick(); // Retry login with hashed password
                }
                else
                {
                    MessageBox.Show("The password does not match the record on file...", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Update the savedEntriesCount label
                SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();
                // Update the charsInNotepad label
                CharsInNotepad.Text = "Characters: " + NotepadTextBox.Text.Length.ToString();

                // Update the columnInNotepad label, if the notepadTextBox.Text is empty, set the columnInNotepad label to 0
                if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
                {
                    ColumnInNotepad.Text = "Columns: 0";
                }
                else
                {
                    // Update the columnInNotepad label
                    ColumnInNotepad.Text = "Columns: " + NotepadTextBox.Text.Split('\n').Length.ToString();
                }
            }
            // If the userConfirmPassword is not the same as the userPassword, show a message box
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword) && UserPassword.Text != UserConfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Mismatched passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the tab key is pressed, focus on the userConfirmPassword TextBox
            if (e.KeyChar == (char)Keys.Tab)
            {
                UserConfirmPassword.Focus();
            }
            // If the user pressed the enter key, click the userLoginButton
            if (e.KeyChar == (char)Keys.Enter)
            {
                UserLoginButton.PerformClick();
            }
        }

        private void UserConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed, click the userLoginButton
            if (e.KeyChar == (char)Keys.Enter)
            {
                UserLoginButton.PerformClick();
            }
        }

        private void UserPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTips.Show(UserPassword.HelperText, UserPassword);
        }

        private void UserConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTips.Show(UserConfirmPassword.HelperText, UserConfirmPassword);
        }

        private void LeftMenuNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // If the user clicks on the themeSetPage in the leftMenuNav, hide applyDateToEntryCheckbox, resetAccountOnCloseCheckbox and resetLoginStatusButton
            if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[0])
            {
                LightModeCheckbox.Visible = true;

                ApplyDateCheckbox.Visible = false;
                ResetAccountCheckbox.Visible = false;
                ResetLoginStatusButton.Visible = false;
            }
            else if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[1])
            {
                ApplyDateCheckbox.Visible = true;

                LightModeCheckbox.Visible = false;
                ResetAccountCheckbox.Visible = false;
                ResetLoginStatusButton.Visible = false;
            }
            else if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[2])
            {
                ResetAccountCheckbox.Visible = true;
                ResetLoginStatusButton.Visible = true;

                ApplyDateCheckbox.Visible = false;
                LightModeCheckbox.Visible = false;
            }
        }

        private void DeleteEntriesButton_Click(object sender, EventArgs e)
        {
            // If there are entries in the entriesListBox, delete them all
            if (EntriesListBox.Items.Count > 0)
            {
                // Ask the user if they really want to delete the entries
                DialogResult deleteEntries = MessageBox.Show("Are you sure you want to delete all entries?", "Delete Entries", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteEntries == DialogResult.Yes)
                {
                    EntriesListBox.Items.Clear();
                    // Save the entries to the setEntriesShow setting
                    Properties.Settings.Default.setEntriesShow = "";
                    Properties.Settings.Default.Save();
                    // Upodate the savedEntriesCount label
                    SavedEntriesCount.Text = "Saved Entries: " + EntriesListBox.Items.Count;

                    if (Properties.Settings.Default.setIsUserLoggedIn == true)
                    {
                        File.Delete("entries.txt");
                    }

                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Entries deleted";
                    notiPopup.Popup();
                }

                if (EntriesListBox.Items.Count == 0 && File.Exists("entries.txt") == false)
                {
                    DeleteEntriesButton.Visible = false;
                }
            }
        }

        private void UserConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            UserConfirmPassword.SelectAll();
        }

        private void RegenPassButton_Click(object sender, EventArgs e)
        {
            // Generate a random password and set it to the passwordGenBox for the user
            string password = "";
            Random random = new Random();
            // Generate the passworrd length according to the value in the passwordLengthSlider
            for (int i = 0; i < PasswordLengthSlider.Value; i++)
            {
                password += (char)random.Next(33, 126);
            }
            UsePassButton.Visible = true;
            PasswordGenBox.Text = password;
        }

        private void UsePassButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordGenBox.Text))
            {
                MessageBox.Show("There is no password that has been generated, please generate a password first.", "No Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Checks if any of the supported password managers are installed
            string[] supportedManagers = { "Bitwarden", "KeePass Password Safe 2", "1Password", "LastPass", "ProtonPass", "NordPass" };
            string managerToOpen = null;
            foreach (string manager in supportedManagers)
            {
                string path = FindManagerPath(manager);
                if (!string.IsNullOrEmpty(path))
                {
                    managerToOpen = manager;
                    break;
                }
            }

            if (managerToOpen != null)
            {
                DialogResult savePassword = MessageBox.Show("Do you want to save your password to " + managerToOpen + "?", "Save Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (savePassword == DialogResult.Yes)
                {
                    string managerPath = FindManagerPath(managerToOpen);
                    if (managerPath != null)
                    {
                        string args = GetManagerArgs(managerToOpen);
                        if (!string.IsNullOrEmpty(args))
                        {
                            Process.Start(managerPath, args);
                            UserPassword.Text = PasswordGenBox.Text;
                            UserConfirmPassword.Text = PasswordGenBox.Text;
                            Clipboard.SetText(PasswordGenBox.Text);
                        }
                    }
                }
                else
                {
                    UserPassword.Text = PasswordGenBox.Text;
                    UserConfirmPassword.Text = PasswordGenBox.Text;
                }
            }
            else
            {
                MessageBox.Show("None of the supported password managers are installed.\n\nRemember to save your password!", "Password Manager Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserPassword.Text = PasswordGenBox.Text;
                UserConfirmPassword.Text = PasswordGenBox.Text;
            }
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            // If the entriesListBox does not have any items, disable the deleteEntriesButton
            if (EntriesListBox.Items.Count <= 1)
            {
                DeleteEntriesButton.Visible = false;
            }
            else
            {
                DeleteEntriesButton.Visible = true;
            }

            // Check if the user has a password set, if they do, make the passwordGenBox, regenPassButton and usePassButton invisible
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                PasswordGenBox.Visible = false;
                RegenPassButton.Visible = false;
                UsePassButton.Visible = false;
                PasswordLengthSlider.Visible = false;
            }
            else
            {
                PasswordGenBox.Visible = true;
                RegenPassButton.Visible = true;
                PasswordLengthSlider.Visible = true;
            }
        }

        private void PasswordGenBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Copy the passwordGenBox text to the clipboard
            Clipboard.SetText(PasswordGenBox.Text);
            // Tell the user they copied the password to the clipboard using the passwordCopiedLabel.
            PasswordCopiedLabel.Visible = true;
            PasswordGenBox.SelectAll();
            PasswordCopiedLabel.Text = "Password copied to clipboard";
            // Hides the passwordCopiedLabel after 3 seconds by activating a timer
            LabelVisibilityTimer.Start();
        }

        private void LabelVisibilityTimer_Tick(object sender, EventArgs e)
        {
            PasswordCopiedLabel.Visible = false;
        }

        private void NotepadTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.notepadSaveText = NotepadTextBox.Text;
            // If the notepadTextBox text changes, change the charsInNotepad label to equal the amount of text in the notepadTextBox
            CharsInNotepad.Text = "Characters: " + NotepadTextBox.Text.Length.ToString();

            // Update the columnInNotepad label, if the notepadTextBox.Text is empty, set the columnInNotepad label to 0
            if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
            {
                ColumnInNotepad.Text = "Columns: 0";
            }
            else
            {
                // Update the columnInNotepad label
                ColumnInNotepad.Text = "Columns: " + NotepadTextBox.Text.Split('\n').Length.ToString();
            }

            // If the text is empty, change the title of the app to its default
            if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
            {
                // Change the title of the form
                this.Text = "SafeNotes";

                // Add the build version of the application to the title
                this.Text += " - v" + Application.ProductVersion;
            }
        }

        private void SaveNotepadButton_Click(object sender, EventArgs e)
        {
            // If the notepadSaveText is empty, tell the user they cannot save an empty file
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.notepadSaveText))
            {
                MessageBox.Show("You cannot save an empty file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Ask the user where they want to save the file to 
                SaveFileDialog saveNotepad = new SaveFileDialog();
                saveNotepad.Filter = "Text File (*.txt)|*.txt";
                saveNotepad.Title = "Save Notepad";
                saveNotepad.ShowDialog();
                // If the user clicks the save button, save the file to the location they chose
                if (!string.IsNullOrWhiteSpace(saveNotepad.FileName))
                {
                    File.WriteAllText(saveNotepad.FileName, Properties.Settings.Default.notepadSaveText);
                    if (NotepadTitle.Visible == true)
                    {
                        NotepadTitle.Text = "Notepad saved...";
                        NotepadTextBox.Text = "";
                        NotepadTitle.Visible = false;

                        // Show a notification that the file has been saved
                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "Notepad saved to " + saveNotepad.FileName;
                        notiPopup.Popup();
                    }
                }
            }
        }

        private void Notepad_Click(object sender, EventArgs e)
        {
            this.ActiveControl = NotepadPage;
        }

        private void SavedEntriesCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have " + EntriesListBox.Items.Count.ToString() + " saved entries. ", "Saved Entries", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Ask the user where they want to open the file from
            OpenFileDialog openNotepad = new OpenFileDialog();
            openNotepad.Filter = "Text File (*.txt)|*.txt";
            openNotepad.Title = "Open Notepad";
            openNotepad.ShowDialog();
            // Change the title of the app on the notepadPage to the name of the file + " - SafeNotes"
            NotepadTitle.Visible = true;
            NotepadTitle.Text = "Opened File: " + openNotepad.SafeFileName;
            // If the user clicks the open button, open the file from the location they chose
            if (!string.IsNullOrWhiteSpace(openNotepad.FileName))
            {
                try
                {
                    string fileContent = File.ReadAllText(openNotepad.FileName);

                    // If the file is more than 32767 characters, do not open it and tell the user it is too big
                    if (fileContent.Length > 32767)
                    {
                        MessageBox.Show("The file you are trying to open is too big, please open a file that is 32767 characters or less.", "File Too Big", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NotepadTitle.Visible = false;
                    }
                    else
                    {
                        NotepadTextBox.Text = fileContent;

                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "You have successfully opened " + openNotepad.SafeFileName;
                        notiPopup.Popup();
                    }

                    // If the file is empty, tell the user they cannot open an empty file
                    if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
                    {
                        MessageBox.Show("You cannot open an empty file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        NotepadTitle.Visible = false;
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An error occurred while trying to open the file: {ex.Message}", "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NotepadTitle.Visible = false;
                }
            }
        }

        private void ClearNotepadButton_Click(object sender, EventArgs e)
        {
            NotepadTextBox.Text = "";
            NotepadTitle.Visible = false;

            Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
            notiPopup.TitleText = "SafeNotes";
            notiPopup.ContentText = "Notepad cleared";
            notiPopup.Popup();
        }

        private void CharsInNotepad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have used " + NotepadTextBox.Text.Length.ToString() + " character(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ColumnInNotepad_Click(object sender, EventArgs e)
        {
            // If the user clicks the label, display the amount of colums used in the notepadTextBox.
            // If the notepadTextBox is empty, display 0
            if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
            {
                MessageBox.Show("You have used 0 column(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have used " + NotepadTextBox.Text.Split('\n').Length.ToString() + " column(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NotepadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the user clicks CTRL + O, open a file from the location they chose
            if (e.KeyChar == (char)15)
            {
                // Ask the user where they want to open the file from
                OpenFileDialog openNotepad = new OpenFileDialog();
                openNotepad.Filter = "Text File (*.txt)|*.txt";
                openNotepad.Title = "Open Notepad";
                openNotepad.ShowDialog();
                // If the user clicks the open button, open the file from the location they chose
                if (!string.IsNullOrWhiteSpace(openNotepad.FileName))
                {
                    // If the file is more than 32767 characters, do not open it and tell the user it is too big
                    if (File.ReadAllText(openNotepad.FileName).Length > 32767)
                    {
                        MessageBox.Show("The file you are trying to open is too big, please open a file that is less than 32768 characters.", "File Too Big", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Change the title of the form
                        this.Text = "SafeNotes";

                        // Add the build version of the application to the title
                        this.Text += " - v" + Application.ProductVersion;
                        return;
                    }
                    else
                    {
                        NotepadTextBox.Text = File.ReadAllText(openNotepad.FileName);
                        NotepadTitle.Visible = true;
                        NotepadTitle.Text = "Opened File: " + openNotepad.SafeFileName;
                    }
                    // If the file is empty, tell the user they cannot open an empty file
                    if (string.IsNullOrWhiteSpace(NotepadTextBox.Text))
                    {
                        MessageBox.Show("You cannot open an empty file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Change the title of the form
                        this.Text = "SafeNotes";

                        // Add the build version of the application to the title
                        this.Text += " - v" + Application.ProductVersion;
                    }
                }
            }

            // If the user clicks CTRL + N, clear the text in the notepadTextBox and ask the user where they want to create the file
            if (e.KeyChar == (char)14)
            {
                // Ask the user where they want to save the file to 
                SaveFileDialog newNotepad = new SaveFileDialog();
                newNotepad.Filter = "Text File (*.txt)|*.txt";
                newNotepad.Title = "New Notepad";
                newNotepad.ShowDialog();
                // If the user clicks the save button, save the file to the location they chose
                if (!string.IsNullOrWhiteSpace(newNotepad.FileName))
                {
                    File.WriteAllText(newNotepad.FileName, Properties.Settings.Default.notepadSaveText);
                }
            }

            // If the user clicks CTRL + S, save the file to the location they chose
            if (e.KeyChar == (char)19)
            {
                // Ask the user where they want to save the file to 
                SaveFileDialog saveNotepad = new SaveFileDialog();
                saveNotepad.Filter = "Text File (*.txt)|*.txt";
                saveNotepad.Title = "Save Notepad";
                saveNotepad.ShowDialog();
                // If the user clicks the save button, save the file to the location they chose
                if (!string.IsNullOrWhiteSpace(saveNotepad.FileName))
                {
                    File.WriteAllText(saveNotepad.FileName, Properties.Settings.Default.notepadSaveText);
                }
            }
        }

        private void NotepadTitle_Click(object sender, EventArgs e)
        {
            NotepadPage.Focus();
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            // Ensure that an item is selected
            if (EntriesListBox.SelectedItems.Count > 0)
            {
                // Programmatically switch to the "Journal" tab
                TabControl.SelectedTab = JournalEntryPage;
                // Get the selected item
                ListViewItem selectedItem = EntriesListBox.SelectedItems[0];
                // Populate journalEntryBox with the text of the selected entry (without date and time)
                string selectedText = selectedItem.Text;
                int index = selectedText.IndexOf(" - ");
                if (index != -1)
                {
                    JournalEntryBox.Text = selectedText.Substring(index + 3);
                }

                // Set focus to the journalEntryBox
                JournalEntryBox.Focus();
                // Hide the editEntryButton
                EditEntryButton.Hide();
                // Disable the tabControl
                JournalTabSelector.Enabled = false;
                // Change the button text to indicate editing
                SaveEntryButton.Text = "Save Edit";
                EditEntryButton.Size = new Size(107, 36);
            }
        }

        private void EntriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable the editEntryButton if an item is selected in the entriesListBox
            EditEntryButton.Enabled = EntriesListBox.SelectedItems.Count > 0;
            EditEntryButton.Visible = EntriesListBox.SelectedItems.Count > 0;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private string EncryptString(string plainText, string saltedDecryptionKey)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    // Generate a unique salt for this encryption
                    byte[] salt = new byte[16];
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(salt);
                    }

                    var key = new Rfc2898DeriveBytes(saltedDecryptionKey, salt, 10000);
                    aes.Key = key.GetBytes(32); // AES-256 requires a 32-byte key
                    aes.GenerateIV(); // Generate a random IV

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Prepend the salt and IV to the ciphertext
                        ms.Write(salt, 0, salt.Length);
                        ms.Write(aes.IV, 0, aes.IV.Length);

                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter sw = new StreamWriter(cs))
                            {
                                sw.Write(plainText);
                            }
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show($"Cryptographic error: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private string DecryptString(string cipherText, string saltedDecryptionKey)
        {
            try
            {
                // Show the decryption status label
                DecryptionStatusLabel.Text = "Decrypting...";
                DecryptionStatusLabel.Visible = true;
                Application.DoEvents();
                DecryptionStatusLabel.Text = "";

                using (Aes aes = Aes.Create())
                {
                    byte[] fullCipher = Convert.FromBase64String(cipherText);

                    // Extract the salt and IV from the beginning of the ciphertext
                    byte[] salt = new byte[16];
                    byte[] iv = new byte[aes.BlockSize / 8];
                    byte[] cipherBytes = new byte[fullCipher.Length - salt.Length - iv.Length];

                    Array.Copy(fullCipher, 0, salt, 0, salt.Length);
                    Array.Copy(fullCipher, salt.Length, iv, 0, iv.Length);
                    Array.Copy(fullCipher, salt.Length + iv.Length, cipherBytes, 0, cipherBytes.Length);

                    var key = new Rfc2898DeriveBytes(saltedDecryptionKey, salt, 10000);
                    aes.Key = key.GetBytes(32); // AES 32bit
                    aes.IV = iv;

                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream ms = new MemoryStream(cipherBytes))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader sr = new StreamReader(cs))
                            {
                                string decryptedText = sr.ReadToEnd();
                                // Hide the decryption status label
                                DecryptionStatusLabel.Visible = false;
                                return decryptedText;
                            }
                        }
                    }
                }
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show($"Cryptographic error: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DecryptionStatusLabel.Visible = false;
                return null;
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format error: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DecryptionStatusLabel.Visible = false;
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DecryptionStatusLabel.Visible = false;
                return null;
            }
        }
    }
}
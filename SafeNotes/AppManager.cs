// File: SafeNotes/EventHandlers.cs
using MaterialSkin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Linq;

namespace SafeNotes
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        private AppSettings _settings;

        private async void MainForm_Load(object sender, EventArgs e)
        {
            _settings = SettingsManager.LoadSettings();

            // Reset the IsRestartingForUpdate flag on application start
            if (_settings.IsRestartingForUpdate)
            {
                _settings.IsRestartingForUpdate = false;
                SettingsManager.SaveSettings(_settings);
            }

            if (_settings.UserPassword == String.Empty)
            {
                PasswordStrength.Visible = true;
                PasswordStrength.Text = "Strength: 0/5\nTime to crack: Unknown";
            }
            else
            {
                PasswordStrength.Visible = false;
            }

            NotepadTitle.Text = null;
            LeftSettingsNav.SelectedNode = LeftSettingsNav.Nodes[0];

            this.Text = "SafeNotes - v" + Application.ProductVersion;
            LoginTabSelector.Visible = false;

            if (!_settings.IsUserLoggedIn)
            {
                LoginTabSelector.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(_settings.UserPassword))
            {
                UserLoginButton.Text = "Register";
                UserConfirmPassword.Visible = true;
                UserPassword.Location = new System.Drawing.Point(300, 100);
                PasswordGenBox.Visible = true;
                RegenPassButton.Visible = true;
                UsePassButton.Visible = true;
                PasswordLengthSlider.Visible = true;
            }

            if (!string.IsNullOrWhiteSpace(_settings.UserPassword))
            {
                UserLoginButton.Text = "Login";
                UserConfirmPassword.Visible = false;
                UserPassword.Location = new System.Drawing.Point(300, 150);
            }

            if (string.IsNullOrWhiteSpace(_settings.YourName))
            {
                YourNameBox.ReadOnly = false;
                ChangeNameButton.Text = "Save name";
            }
            else
            {
                YourNameBox.ReadOnly = true;
                ChangeNameButton.Text = "Change name";
            }

            var updater = new EventHandlerClass(_settings);
            await updater.CheckForUpdatesAsync();

            JournalEntryBox.Text = _settings.EntryText;
            YourNameBox.Text = _settings.YourName;
            NotepadTextBox.Text = _settings.NotepadSaveText;
            LightModeCheckbox.Checked = _settings.LightMode;
            ApplyDateCheckbox.Checked = _settings.SaveDate;
            DisableNotificationsCheckbox.Checked = _settings.DisableNotifications;
            RequirePinToLogin.Checked = _settings.RequirePinCode;
        }

        private void RequirePenToLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (RequirePinToLogin.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(_settings.UserPassword))
                {
                    UserPassword.Location = new System.Drawing.Point(300, 100);
                    UserPINCodeField.Visible = true;

                    _settings.RequirePinCode = true;
                    SettingsManager.SaveSettings(_settings);
                }
            }
            if (RequirePinToLogin.Checked == false && _settings.PinCode != null)
            {
                DialogResult RemovePINCode = MessageBox.Show("Are you sure you wish to disable your PIN?", "Disable PIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (RemovePINCode == DialogResult.Yes)
                {
                    UserPINCodeField.Visible = false;
                    RequirePinToLogin.Checked = false;
                    _settings.RequirePinCode = false;
                    _settings.PinCode = null;
                    SettingsManager.SaveSettings(_settings);
                }
                else
                {
                    RequirePinToLogin.Checked = true;
                }
            }
        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength(UserPassword.Text);
        }

        private void PasswordGenBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength(PasswordGenBox.Text);
        }

        private void UpdatePasswordStrength(string password)
        {
            int score = CalculatePasswordStrength(password);
            string timeToCrack = EstimateTimeToCrack(score);
            // Calculate scores for both UserPassword and PasswordGenBox
            int userPasswordScore = CalculatePasswordStrength(UserPassword.Text);
            int passwordGenBoxScore = CalculatePasswordStrength(PasswordGenBox.Text);
            // Determine the higher score and update PasswordStrength.Text accordingly
            if (userPasswordScore > passwordGenBoxScore)
            {
                score = userPasswordScore;
                timeToCrack = EstimateTimeToCrack(score);
            }
            else
            {
                score = passwordGenBoxScore;
                timeToCrack = EstimateTimeToCrack(score);
            }
            PasswordStrength.Text = $"Strength: {score}/5\nTime to crack: {timeToCrack}";
            PasswordStrength.ForeColor = GetStrengthColor(score);
        }

        private int CalculatePasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return 0;

            int score = 0;

            // Length
            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;

            // Complexity
            if (Regex.IsMatch(password, @"[a-z]")) score++;
            if (Regex.IsMatch(password, @"[A-Z]")) score++;
            if (Regex.IsMatch(password, @"[0-9]")) score++;
            if (Regex.IsMatch(password, @"[!@#$%^&*(),.?""{}|<>]")) score++;

            return Math.Min(score, 5); // Max score is 5
        }

        private string EstimateTimeToCrack(int score)
        {
            switch (score)
            {
                case 0: return "Instantly";
                case 1: return "Seconds";
                case 2: return "Minutes";
                case 3: return "Hours";
                case 4: return "Days";
                case 5: return "Years";
                default: return "Unknown";
            }
        }

        private Color GetStrengthColor(int score)
        {
            switch (score)
            {
                case 0: return Color.Red;
                case 1: return Color.OrangeRed;
                case 2: return Color.Orange;
                case 3: return Color.YellowGreen;
                case 4: return Color.Green;
                case 5: return Color.DarkGreen;
                default: return Color.Gray;
            }
        }

        private bool EntriesEncryptedButtonClicked = false;

        private void EncryptEntriesButton_Click(object sender, System.EventArgs e)
        {
            // Encrypt the entries in the entriesListBox and remove them from the list
            if (EntriesListBox.Items.Count >= 1)
            {
                // Ask the user if they really want to encrypt the entries
                DialogResult encryptEntries = MessageBox.Show("Are you sure you want to encrypt all entries?", "Encrypt Entries", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (encryptEntries == DialogResult.Yes)
                {
                    // Encrypt the entries and remove them from the list
                    string[] entries = new string[EntriesListBox.Items.Count];
                    for (int i = 0; i < EntriesListBox.Items.Count; i++)
                    {
                        string entryText = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                        string encryptedText = EncryptString(entryText, ConvertToUnsecureString(securePassword));
                        entries[i] = EncryptString(entryText, ConvertToUnsecureString(securePassword));
                        _settings.Entries = string.Join(",", entries);
                    }
                    EntriesListBox.Clear();
                    SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();
                    EntriesEncryptedButtonClicked = true;
                    SaveEntryButton.Enabled = false;
                    ChangeNameButton.Enabled = false;
                    OpenFileButton.Enabled = false;
                    SaveNotepadButton.Enabled = false;
                    ClearNotepadButton.Enabled = false;
                    ImportEntriesButton.Enabled = false;
                    ExportEntriesButton.Enabled = false;
                    EncryptEntriesButton.Enabled = false;
                    NotepadTextBox.Text = null;

                    MessageBox.Show("SafeNotes application entered lockdown mode.\n\nIf you wish to disable Lockdown Mode, you must restart SafeNotes.", "Lockdown Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (encryptEntries == DialogResult.No)
                {
                    EncryptEntriesButton.Visible = false;
                    EncryptEntriesButton.Visible = true;
                }
            } 
            else
            {
                MessageBox.Show("You have no entries to encrypt.", "No Entries", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EncryptEntriesButton.Visible = false;
                EncryptEntriesButton.Visible = true;
            }
        }

        private const int MaxEntries = 200;

        private bool shouldExit = false;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_settings.IsRestartingForUpdate)
            {
                // Skip saving settings if the application is restarting for an update
                return;
            }

            if (EntriesEncryptedButtonClicked == false)
            {
                _settings.EntryText = JournalEntryBox.Text;
                _settings.YourName = YourNameBox.Text;
                _settings.NotepadSaveText = NotepadTextBox.Text;
                _settings.LightMode = LightModeCheckbox.Checked;
                _settings.SaveDate = ApplyDateCheckbox.Checked;
                _settings.DisableNotifications = DisableNotificationsCheckbox.Checked;

                try
                {
                    if (_settings.IsUserLoggedIn)
                    {
                        if (securePassword == null)
                        {
                            MessageBox.Show("Secure password is not set. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        SaveEntries();
                    }

                    // Check if decryption is in progress
                    if (DecryptionStatusLabel.Text == "Decrypting...")
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please wait until the decryption process is complete.", "Decryption in Progress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Ensure the JournalEntryPage is selected before closing and encrypting
                    if (TabControl.SelectedTab != JournalEntryPage)
                    {
                        TabControl.SelectedTab = JournalEntryPage;
                        Application.DoEvents();
                    }

                    // Show the decryption status label with encryption message
                    DecryptionStatusLabel.Text = "Encrypting files...";
                    DecryptionStatusLabel.Visible = true;
                    Application.DoEvents();

                    if (!string.IsNullOrWhiteSpace(NotepadTextBox.Text) && !shouldExit)
                    {
                        if (!string.IsNullOrWhiteSpace(NotepadTitle.Text))
                        {
                            DialogResult dialogResult = MessageBox.Show("Do you want to save your notepad before closing the application?", "Save notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                e.Cancel = true;
                                SaveFileDialog saveFileDialog = new SaveFileDialog
                                {
                                    Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                                    Title = "Save your notepad file",
                                    FileName = NotepadTitle.Text.Replace("Opened File: ", "") + ".txt",
                                    DefaultExt = ".txt",
                                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                                };

                                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                                {
                                    File.WriteAllText(saveFileDialog.FileName, NotepadTextBox.Text);
                                    NotepadTextBox.Text = null;
                                    shouldExit = true;
                                    Close();
                                }
                                else
                                {
                                    NotepadTextBox.Text = null;
                                    shouldExit = true;
                                    Close();
                                }
                                return;
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                NotepadTextBox.Text = null;
                                shouldExit = true;
                                Close();
                                return;
                            }
                        }
                        else
                        {
                            NotepadTextBox.Text = null;
                        }
                    }

                    if (EntriesListBox.Items.Count != 0 && _settings.IsUserLoggedIn)
                    {
                        string[] entries = new string[EntriesListBox.Items.Count];
                        for (int i = 0; i < EntriesListBox.Items.Count; i++)
                        {
                            var item = EntriesListBox.Items[i];
                            if (item == null) continue;

                            string entryText = item.ToString().Replace("ListViewItem: {", "").Replace("}", "").Trim();
                            if (string.IsNullOrWhiteSpace(entryText)) continue;

                            entries[i] = EncryptString(entryText, ConvertToUnsecureString(securePassword));
                        }
                        _settings.Entries = string.Join(",", entries.Where(entry => !string.IsNullOrWhiteSpace(entry)));
                        SettingsManager.SaveSettings(_settings);
                    }

                    if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown)
                    {
                        if (_settings.IsUserLoggedIn)
                        {
                            _settings.IsUserLoggedIn = false;
                            SettingsManager.SaveSettings(_settings);
                            ClearInMemoryPassword();
                        }
                    }

                    DecryptionStatusLabel.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while closing the application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (_settings.IsUserLoggedIn)
            {
                _settings.IsUserLoggedIn = false;
                SettingsManager.SaveSettings(_settings);
                ClearInMemoryPassword();
                DecryptionStatusLabel.Visible = false;
                Application.Exit();
            }
        }

        private void ResetAccountCheckbox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ResetAccountCheckbox.Checked == true)
            {
                DialogResult ResetAccount = MessageBox.Show("Are you sure you wish to reset all of your account's data?", "Reset Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResetAccount == DialogResult.Yes)
                {
                    // Clear all user data
                    UserPassword.Text = string.Empty;
                    UserConfirmPassword.Text = string.Empty;

                    _settings.UserPassword = string.Empty;
                    _settings.Entries = string.Empty;
                    _settings.YourName = null;
                    _settings.EntryText = string.Empty;
                    _settings.NotepadSaveText = string.Empty;
                    _settings.SaveDate = true;
                    _settings.FirstTimeOpened = true;
                    _settings.IsUserLoggedIn = false;
                    _settings.LightMode = false;
                    _settings.RequirePinCode = false;
                    _settings.PinCode = null;

                    // Reset the IsRestartingForUpdate flag to ensure it doesn't interfere
                    _settings.IsRestartingForUpdate = false;

                    // Save the updated settings
                    SettingsManager.SaveSettings(_settings);

                    // Clear in-memory secure password
                    securePassword?.Dispose();
                    securePassword = null;

                    // Update UI to reflect reset state
                    UserLoginButton.Text = "Register";
                    UserConfirmPassword.Visible = true;
                    UserPassword.Location = new System.Drawing.Point(300, 100);
                    PasswordGenBox.Visible = true;
                    RegenPassButton.Visible = true;
                    UsePassButton.Visible = true;
                    PasswordLengthSlider.Visible = true;

                    // Restart the application
                    Application.Restart();
                }
                else
                {
                    ResetAccountCheckbox.Checked = false;
                }
            }
        }

        private void ClearInMemoryPassword()
        {
            securePassword?.Dispose();
            securePassword = null;
        }

        private SecureString securePassword;

        private void SaveEntryButton_Click(object sender, EventArgs e)
        {
            if (EntriesListBox.Items.Count >= MaxEntries)
            {
                MessageBox.Show($"You cannot add more than {MaxEntries} entries.", "Entry Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (SaveEntryButton.Text == "Save Edit")
                {
                    if (!string.IsNullOrWhiteSpace(JournalEntryBox.Text))
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

                                if (DisableNotificationsCheckbox.Checked == false)
                                {
                                    // Show a notification that the entry has been edited
                                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                                    notiPopup.TitleText = "SafeNotes";
                                    notiPopup.ContentText = "Entry edited";
                                    notiPopup.Popup();
                                }
                            }

                            EntriesListBox.SelectedItems[0].Text = editedText;
                            // Reset button text to "Save Entry" after editing
                            SaveEntryButton.Text = "Save Entry";
                            // Clear the journal entry box
                            JournalEntryBox.Text = "";
                            // Show the editEntryButton again
                            EditEntryButton.Show();
                            // Update the entries count label and save entries to settings
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
                else if (DecryptionStatusLabel.Text != "Decrypting..." && SaveEntryButton.Text == "Save Entry")
                {
                    if (!string.IsNullOrWhiteSpace(JournalEntryBox.Text))
                    {
                        // Add new entry
                        string newEntryText = JournalEntryBox.Text;
                        if (ApplyDateCheckbox.Checked)
                        {
                            newEntryText = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + newEntryText;

                            if (DisableNotificationsCheckbox.Checked == false)
                            {
                                // Show a notification that the entry has been edited
                                Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                                notiPopup.TitleText = "SafeNotes";
                                notiPopup.ContentText = "Entry edited";
                                notiPopup.Popup();
                            }
                        }

                        // Add the new entry to the entriesListBox
                        EntriesListBox.Items.Add(newEntryText);
                        // Clear the journal entry box
                        JournalEntryBox.Text = "";
                        // Update the entries count label and save entries to settings
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

                // Save entries using the new SaveEntries method
                SaveEntries();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the entry: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            if (ChangeNameButton.Text == "Save name")
            {
                if (string.IsNullOrWhiteSpace(YourNameBox.Text))
                {
                    MessageBox.Show("You can not save an empty name.", "Empty name", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    YourNameBox.ReadOnly = true;
                    ChangeNameButton.Text = "Change name";
                    _settings.YourName = YourNameBox.Text;
                    SettingsManager.SaveSettings(_settings);
                    ChangeNameButton.Visible = false;
                    ChangeNameButton.Visible = true;

                    if (DisableNotificationsCheckbox.Checked == false)
                    {
                        // Show a notification that the entry has been edited
                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "Entry edited";
                        notiPopup.Popup();
                    }
                }
            }
            else if (ChangeNameButton.Text == "Change name")
            {
                YourNameBox.Text = "";
                YourNameBox.ReadOnly = false;
                ChangeNameButton.Text = "Save name";
                _settings.YourName = YourNameBox.Text;
                SettingsManager.SaveSettings(_settings);
                ChangeNameButton.Visible = false;
                ChangeNameButton.Visible = true;
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

        private void EntriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (EntriesListBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this entry?", "SafeNotes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Remove the selected item from the entriesListBox
                    EntriesListBox.Items.Remove(EntriesListBox.SelectedItems[0]);
                    // Update the savedEntriesCount label
                    SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();

                    // Save the remaining entries to the settings
                    SaveEntries();

                    if (DisableNotificationsCheckbox.Checked == false)
                    {
                        // Show a notification that the entry has been edited
                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "Entry edited";
                        notiPopup.Popup();
                    }
                }
            }
        }

        private void LightModeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            if (LightModeCheckbox.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                _settings.LightMode = true;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                _settings.LightMode = false;
            }
            SettingsManager.SaveSettings(_settings);
        }

        private void ApplyDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SettingsPage_Click(object sender, EventArgs e)
        {
            // If the settingsPage is clicked, unfocus from everything and focus on the settingsPage
            this.ActiveControl = SettingsPage;
        }

        private void ResetLoginStatusButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UserLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserPassword.Text) && string.IsNullOrWhiteSpace(UserConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UserLoginButton.Text == "Register")
            {
                if (UserPassword.Text == UserConfirmPassword.Text)
                {
                    // Check if the password is strong enough
                    // Must be 8 characters long and contain special characters
                    //if (UserPassword.Text.Length < 8 || !System.Text.RegularExpressions.Regex.IsMatch(UserPassword.Text, @"[!@#$%^&*(),.?""{}|<>]"))
                    //{
                    //    MessageBox.Show("Your password must be at least 8 characters long and contain special characters.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}

                    PasswordStrength.Visible = false;

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
                                    Clipboard.SetText(UserPassword.Text);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("None of the supported password managers are installed.\n\nRemember to save your password!", "Password Manager Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserPassword.Text = PasswordGenBox.Text;
                        UserConfirmPassword.Text = PasswordGenBox.Text;
                    }

                    string hashedPassword = HashPassword(UserPassword.Text);
                    _settings.UserPassword = hashedPassword;

                    // Generate a unique salt and store it in setSaltedDecryptionKey
                    byte[] salt = new byte[16];
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(salt);
                    }

                    _settings.FirstTimeOpened = false;
                    SettingsManager.SaveSettings(_settings);
                    UserConfirmPassword.Visible = false;
                    UserLoginButton.Text = "Login";
                    UserPassword.Location = new System.Drawing.Point(300, 150);
                }
                else
                {
                    MessageBox.Show("The passwords do not match.", "Mismatched passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (UserLoginButton.Text == "Login")
            {
                string storedHash = _settings.UserPassword;
                if (VerifyPassword(UserPassword.Text, storedHash))
                {
                    if (_settings.RequirePinCode)
                    {
                        if (string.IsNullOrWhiteSpace(_settings.PinCode))
                        {
                            // Set the pin code if it is empty
                            if (string.IsNullOrWhiteSpace(UserPINCodeField.Text))
                            {
                                MessageBox.Show("Please enter a pin code.", "Pin Code Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else if (!System.Text.RegularExpressions.Regex.IsMatch(UserPINCodeField.Text, @"^\d{4,}$"))
                            {
                                MessageBox.Show("Pin code must be numerical and at least 4 digits long.", "Invalid Pin Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            else
                            {
                                _settings.PinCode = HashPassword(UserPINCodeField.Text);
                                SettingsManager.SaveSettings(_settings);
                            }
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(UserPINCodeField.Text) || !VerifyPassword(UserPINCodeField.Text, _settings.PinCode))
                            {
                                MessageBox.Show("Invalid pin code.", "Pin Code Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Use the entered password for decryption
                    securePassword = ConvertToSecureString(UserPassword.Text);

                    // Show that the user is logged in and make the entriesListBox visible
                    _settings.IsUserLoggedIn = true;
                    EntriesListBox.Visible = true;
                    UserLoginButton.Enabled = false;
                    LoginTabSelector.Enabled = true;
                    TabControl.TabPages.Remove(LoginPage);

                    _settings.FirstTimeOpened = false;
                    SettingsManager.SaveSettings(_settings);

                    // Load the entries from the settings into the entriesListBox
                    if (!string.IsNullOrWhiteSpace(_settings.Entries))
                    {
                        string[] entries = _settings.Entries.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string entry in entries)
                        {
                            string decryptedText = DecryptString(entry, ConvertToUnsecureString(securePassword));
                            if (decryptedText != null)
                            {
                                EntriesListBox.Items.Add(decryptedText);
                            }
                        }
                    }

                    if (EntriesListBox.Items.Count > 1)
                    {
                        DeleteEntriesButton.Visible = true;
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

                    // Clear the password from the TextBox
                    UserPassword.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("The password does not match the record on file...", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                ApplyDateCheckbox.Visible = true;
                DisableNotificationsCheckbox.Visible = true;

                LightModeCheckbox.Visible = false;
                ResetAccountCheckbox.Visible = false;
                ResetLoginStatusButton.Visible = false;
                ImportEntriesButton.Visible = false;
                ExportEntriesButton.Visible = false;
                EncryptEntriesButton.Visible = false;
                SettingsInfoLabel.Visible = false;
                RequirePinToLogin.Visible = false;
            }
            else if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[1])
            {
                ResetAccountCheckbox.Visible = true;
                ResetLoginStatusButton.Visible = true;
                RequirePinToLogin.Visible = true;
                SettingsInfoLabel.Visible = true;

                SettingsInfoLabel.Text = "Require Login PIN: The PIN is in experimental mode and is not implemented fully, meaning the PIN\nmay not be stored and " +
                                         "accessed as securely." + "\n\nNOTE: This will not affect the security of your entries or login status as the PIN will be " +
                                         "required in\nconjunction " + "with your password. Enabling this feature will still come with benefits and strengthen\napp " +
                                         "security. The only fallback is the PIN will be more easily decrypted/dehashed; knowing this PIN\ndoes not mean access to " +
                                         "SafeNotes.";

                ApplyDateCheckbox.Visible = false;
                LightModeCheckbox.Visible = false;
                ImportEntriesButton.Visible = false;
                ExportEntriesButton.Visible = false;
                DisableNotificationsCheckbox.Visible = false;
                EncryptEntriesButton.Visible = false;
            }
            else if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[2])
            {
                ImportEntriesButton.Visible = true;
                ExportEntriesButton.Visible = true;
                EncryptEntriesButton.Visible = true;
                SettingsInfoLabel.Visible = true;

                SettingsInfoLabel.Text = "" +
                                             "Export Entries: This will export your encrypted entries into an entries.txt file for safe backups to\nuse later.\n\n" +
                                             "Import Entries: This will import your previously exported entries; however, you must use the same\npassword used " +
                                             "during exportation.\n\n" +
                                             "Encrypted Entries Button: SafeNotes will automatically encrypt your entries and remove all entries\nfrom your " +
                                             "EntriesListBox, activating Lockdown Mode.";

                ResetAccountCheckbox.Visible = false;
                ResetLoginStatusButton.Visible = false;
                ApplyDateCheckbox.Visible = false;
                LightModeCheckbox.Visible = false;
                DisableNotificationsCheckbox.Visible = false;
                RequirePinToLogin.Visible = false;
            }
            else if (LeftSettingsNav.SelectedNode == LeftSettingsNav.Nodes[3])
            {
                LightModeCheckbox.Visible = true;

                ApplyDateCheckbox.Visible = false;
                ResetAccountCheckbox.Visible = false;
                ResetLoginStatusButton.Visible = false;
                ImportEntriesButton.Visible = false;
                ExportEntriesButton.Visible = false;
                DisableNotificationsCheckbox.Visible = false;
                EncryptEntriesButton.Visible = false;
                SettingsInfoLabel.Visible = false;
                RequirePinToLogin.Visible = false;
            }
        }

        private void ExportEntriesButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("To import after exporting the entries, you need to have the same password used to log into SafeNotes during this export process to import the exported entries.", "Password Mismatch Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Export the entries to a file.
            // Also ask the user where to export it to.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Select a location to export entries to";
            saveFileDialog.FileName = "entries.txt";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string filePath = saveFileDialog.FileName;
            string[] entries = new string[EntriesListBox.Items.Count];
            for (int i = 0; i < EntriesListBox.Items.Count; i++)
            {
                // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                string entryText = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                entries[i] = EncryptString(entryText, ConvertToUnsecureString(securePassword));
            }
            // Save the entries to the file
            File.WriteAllLines(filePath, entries);

            if (DisableNotificationsCheckbox.Checked == false)
            {
                // Show a notification that the entry has been edited
                Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                notiPopup.TitleText = "SafeNotes";
                notiPopup.ContentText = "Entry edited";
                notiPopup.Popup();
            }
            ExportEntriesButton.Visible = false;
            ExportEntriesButton.Visible = true;
        }

        private bool decryptionErrorOccurred = false;

        private void ImportEntriesButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("To import the entries, you must have the same password that was used to log into SafeNotes during the initial export process. If the password does not match, the entries cannot be decrypted and will not be imported.", "Password Mismatch Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Import the entries from a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select a file to import entries from";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                decryptionErrorOccurred = false; // Reset the flag before starting the import process

                foreach (string line in lines)
                {
                    // Decrypt the entry and add it to the entriesListBox
                    string decryptedText = DecryptString(line, ConvertToUnsecureString(securePassword));
                    if (decryptedText != null)
                    {
                        // Do not include "Your Entries:" in the entriesListBox if it is present
                        if (decryptedText.Contains("Your Entries:"))
                        {
                            decryptedText = decryptedText.Replace("Your Entries:", "");
                        }
                        EntriesListBox.Items.Add(decryptedText);
                    }
                }
                // Update the savedEntriesCount label
                SavedEntriesCount.Text = "Saved entries: " + EntriesListBox.Items.Count.ToString();
            }
            ImportEntriesButton.Visible = false;
            ImportEntriesButton.Visible = true;
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
                    // Upodate the savedEntriesCount label
                    SavedEntriesCount.Text = "Saved Entries: " + EntriesListBox.Items.Count;

                    if (DisableNotificationsCheckbox.Checked == false)
                    {
                        // Show a notification that the entry has been edited
                        Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                        notiPopup.TitleText = "SafeNotes";
                        notiPopup.ContentText = "Entry edited";
                        notiPopup.Popup();
                    }
                }
            }
        }

        private void UserConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            UserConfirmPassword.SelectAll();
        }

        private void RegenPassButton_Click(object sender, EventArgs e)
        {
            // Generate a cryptographically secure random password and set it to the PasswordGenBox for the user
            string password = GenerateSecurePassword(PasswordLengthSlider.Value);
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
            if (!string.IsNullOrWhiteSpace(_settings.UserPassword))
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
                UsePassButton.Visible = true;
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
            _settings.NotepadSaveText = NotepadTextBox.Text;
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
            if (string.IsNullOrWhiteSpace(_settings.NotepadSaveText))
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
                    File.WriteAllText(saveNotepad.FileName, _settings.NotepadSaveText);
                    if (NotepadTitle.Visible == true)
                    {
                        NotepadTitle.Text = "Notepad saved...";
                        NotepadTextBox.Text = "";
                        NotepadTitle.Visible = false;

                        if (DisableNotificationsCheckbox.Checked == false)
                        {
                            // Show a notification that the entry has been edited
                            Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                            notiPopup.TitleText = "SafeNotes";
                            notiPopup.ContentText = "Entry edited";
                            notiPopup.Popup();
                        }
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
            OpenFileDialog openNotepad = new OpenFileDialog();
            openNotepad.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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

                        if (DisableNotificationsCheckbox.Checked == false)
                        {
                            // Show a notification that the entry has been edited
                            Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                            notiPopup.TitleText = "SafeNotes";
                            notiPopup.ContentText = "Entry edited";
                            notiPopup.Popup();
                        }
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

            if (DisableNotificationsCheckbox.Checked == false)
            {
                // Show a notification that the entry has been edited
                Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                notiPopup.TitleText = "SafeNotes";
                notiPopup.ContentText = "Entry edited";
                notiPopup.Popup();
            }
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
                    File.WriteAllText(newNotepad.FileName, _settings.NotepadSaveText);
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
                    File.WriteAllText(saveNotepad.FileName, _settings.NotepadSaveText);
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
                string selectedText = selectedItem.Text;

                // Check if the entry contains a date prefix
                int index = selectedText.IndexOf(" - ");
                if (index != -1)
                {
                    // Extract the text after the date and time
                    JournalEntryBox.Text = selectedText.Substring(index + 3);
                }
                else
                {
                    // If no date prefix, use the entire text
                    JournalEntryBox.Text = selectedText;
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
            // Generate a random salt
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var keyDerivationFunction = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256)) // 10,000 iterations
            {
                byte[] hash = keyDerivationFunction.GetBytes(32); // 256-bit hash
                byte[] hashBytes = new byte[48]; // 16 byte salt & a 32 byte hash
                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 32);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private string DeriveKey(string password, byte[] salt, byte[] iv)
        {
            // Combine salt and IV
            byte[] saltAndIv = new byte[salt.Length + iv.Length];
            Array.Copy(salt, 0, saltAndIv, 0, salt.Length);
            Array.Copy(iv, 0, saltAndIv, salt.Length, iv.Length);

            using (var keyDerivationFunction = new Rfc2898DeriveBytes(password, saltAndIv, 10000, HashAlgorithmName.SHA256)) // 10,000 iterations
            {
                return Convert.ToBase64String(keyDerivationFunction.GetBytes(32)); // AES-256 requires a 32-byte key
            }
        }

        private string EncryptString(string plainText, string password)
        {
            try
            {
                using (Aes aes = Aes.Create())
                {
                    // Generate a random salt
                    byte[] salt = new byte[16];
                    using (var rng = new RNGCryptoServiceProvider())
                    {
                        rng.GetBytes(salt);
                    }

                    aes.GenerateIV(); // Generate a random IV
                    var key = DeriveKey(password, salt, aes.IV);
                    aes.Key = Convert.FromBase64String(key);

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

        private string DecryptString(string cipherText, string password)
        {
            if (string.IsNullOrWhiteSpace(cipherText) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

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

                    var key = DeriveKey(password, salt, iv);
                    aes.Key = Convert.FromBase64String(key);
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

        private string ConvertToUnsecureString(SecureString secureString)
        {
            IntPtr unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        private SecureString ConvertToSecureString(string password)
        {
            SecureString secureString = new SecureString();
            foreach (char c in password)
            {
                secureString.AppendChar(c);
            }
            secureString.MakeReadOnly();
            return secureString;
        }

        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            byte[] hashBytes = Convert.FromBase64String(storedHash);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            using (var keyDerivationFunction = new Rfc2898DeriveBytes(enteredPassword, salt, 10000, HashAlgorithmName.SHA256)) // 10,000 iterations
            {
                byte[] hash = keyDerivationFunction.GetBytes(32);
                for (int i = 0; i < 32; i++)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void SaveEntries()
        {
            if (_settings.Entries == null)
            {
                _settings.Entries = string.Empty;
            }

            if (EntriesListBox.Items.Count != 0)
            {
                string[] entries = new string[EntriesListBox.Items.Count];
                for (int i = 0; i < EntriesListBox.Items.Count; i++)
                {
                    string entryText = EntriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                    entries[i] = EncryptString(entryText.Trim(), ConvertToUnsecureString(securePassword));
                }
                _settings.Entries = string.Join(",", entries);
            }
            else
            {
                _settings.Entries = string.Empty;
            }
            SettingsManager.SaveSettings(_settings);
        }

        private string GenerateSecurePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+[]{}|;:,.<>?";
            StringBuilder password = new StringBuilder();
            byte[] randomBytes = new byte[length];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(randomBytes);
            }

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[randomBytes[i] % validChars.Length]);
            }

            return password.ToString();
        }
    }
}
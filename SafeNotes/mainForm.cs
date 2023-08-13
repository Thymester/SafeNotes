using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
 
namespace SafeNotes
{
    public partial class mainForm : MaterialForm
    {
        public mainForm()
        {
            InitializeComponent();

            // Sets the default theme to dark, the theme will not be set if the lightModeCheckbox is checked
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (userLoginButton.Text == "Register")
            {
                passwordGenBox.Visible = true;
                regenPassButton.Visible = true;
            }

            // If yourNameBox is empty, allow the user to change their name
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.setYourName))
            {
                yourNameBox.ReadOnly = false;
            }
            else
            {
                // If yourNameBox is not empty, disable the ability to change their name
                yourNameBox.ReadOnly = true;
            }

            // Change the title of the form
            this.Text = "SafeNotes";

            // Add the build version of the application to the title
            this.Text += " - v" + Application.ProductVersion;

            // Load the settings of the form
            journalEntryBox.Text = Properties.Settings.Default.setEntryText;
            yourNameBox.Text = Properties.Settings.Default.setYourName;
            notepadTextBox.Text = Properties.Settings.Default.notepadSaveText;
            lightModeCheckbox.Checked = Properties.Settings.Default.setLightMode;
            applyDateCheckbox.Checked = Properties.Settings.Default.setSaveDate;
            Properties.Settings.Default.setEntriesShow = Properties.Settings.Default.setEntriesHide;
            Properties.Settings.Default.firstTimeOpened = Properties.Settings.Default.firstTimeOpened;

            // If user is not logged in disable all the tabSelect components
            if (Properties.Settings.Default.setIsUserLoggedIn == false)
            {
                tabSelect.Visible = false;
            }

            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                userLoginButton.Text = "Login";
                userConfirmPassword.Visible = false;
                // Move the userPassword location to 300, 150
                userPassword.Location = new System.Drawing.Point(300, 150);
            }

            // If the user has a name disable the saveNameButton and enable the changeNameButton
            if (!string.IsNullOrWhiteSpace(yourNameBox.Text))
            {
                saveNameButton.Visible = false;
                changeNameButton.Visible = true;
            }
            else
            {
                saveNameButton.Visible = true;
                changeNameButton.Visible = false;
            }
        }

        private void journalEntryBox_TextChanged(object sender, EventArgs e)
        {
            // If the journalEntryBox has a break line in it, remove it. This is to prevent issues with the entries.txt file and the entriesListBox
            journalEntryBox.Text = journalEntryBox.Text.Replace("\n", "");
            // If the user presses enter in the journalEntryBox, remove the last empty space
            journalEntryBox.Text = journalEntryBox.Text.Replace("\r", "");
            // Set the blinking cursor to the end of the text in the journalEntryBox
            journalEntryBox.SelectionStart = journalEntryBox.Text.Length;
            // If journalEntryBox text is changed, save the text to setEntryText setting
            Properties.Settings.Default.setEntryText = journalEntryBox.Text;
            Properties.Settings.Default.Save();
        }

        private void saveEntryButton_Click(object sender, EventArgs e)
        {
            // If applyHourCheckbox and applyDateBox are checked, save the text in the contentsColumn of the entriesListBox with the current date and time in the dateColumn
            // If the contents of the journalEntryBox is empty, show a message box with the text "You cannot save an empty entry"
            if (applyDateCheckbox.Checked == true)
            {
                if (string.IsNullOrWhiteSpace(journalEntryBox.Text))
                {
                    MessageBox.Show("You cannot save an empty entry", "Empty entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    entriesListBox.Items.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " - " + journalEntryBox.Text);
                    journalEntryBox.Text = "";
                    // Now save this entry to a txt file in the location of the applications .exe
                    string[] entries = new string[entriesListBox.Items.Count];
                    for (int i = 0; i < entriesListBox.Items.Count; i++)
                    {
                        // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                        entries[i] = entriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                        // Show the amount of entries in the entriesListBox to the savedEntriesCount label
                        savedEntriesCount.Text = "Saved entries: " + entriesListBox.Items.Count.ToString();
                    }
                    System.IO.File.WriteAllLines("entries.txt", entries);
                    // if there is more than one entry in the entriesListBox, show the deleteEntriesButton
                    if (entriesListBox.Items.Count > 1)
                    {
                        deleteEntriesButton.Visible = true;
                    }
                    // Add the entry to the entryStats chart based on the day it was saved
                    //entryStats.Series["Entries"].Points.Add(DateTime.Now.ToString("dd/MM/yyyy"), entriesListBox.Items.Count);

                    // Create a notification using the notiPopup, which uses Tulpep. Notify the user that the entry has been saved and close the notification after 2 seconds
                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Entry saved";
                    notiPopup.Popup();
                }
            }
            else if (applyDateCheckbox.Checked == false)
            {
                if (string.IsNullOrWhiteSpace(journalEntryBox.Text))
                {
                    MessageBox.Show("You cannot save an empty entry", "Empty entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    entriesListBox.Items.Add(journalEntryBox.Text);
                    journalEntryBox.Text = "";
                    // Now save this entry to a txt file in the location of the applications .exe
                    string[] entries = new string[entriesListBox.Items.Count];
                    for (int i = 0; i < entriesListBox.Items.Count; i++)
                    {
                        // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                        entries[i] = entriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                    }
                    System.IO.File.WriteAllLines("entries.txt", entries);

                    // Create a notification using the notiPopup, which uses Tulpep. Notify the user that the entry has been saved and close the notification after 2 seconds
                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Entry saved";
                    notiPopup.Popup();
                }
            }
        }

        private void saveNameButton_Click(object sender, EventArgs e)
        {
            // If the contents of the yourNameBox is empty, show a message box with the text "You cannot save an empty name"
            if (string.IsNullOrWhiteSpace(yourNameBox.Text))
            {
                MessageBox.Show("You can not save an empty name.", "Empty name", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                // Save the text in the yourNameBox to setYourName setting, when the name is saved, disable the saveNameButton and enable the changeNameButton
                saveNameButton.Visible = false;
                changeNameButton.Visible = true;
                yourNameBox.ReadOnly = true;
                Properties.Settings.Default.setYourName = yourNameBox.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            // When the changeNameButton is clicked, disable the changeNameButton and enable the saveNameButton and also clear the text in the yourNameBox
            changeNameButton.Visible = false;
            saveNameButton.Visible = true;
            yourNameBox.Text = "";
            yourNameBox.ReadOnly = false;
        }

        private void journalEntryPage_Click(object sender, EventArgs e)
        {
            // If the journalEntryPage is clicked, unfocus from everything and focus on the journalEntryBox
            this.ActiveControl = journalEntryBox;
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(notepadTextBox.Text))
            {
                // Show a message box asking the user if they want to save their notepad before closing the application
                // If they select yes, do not close the app, otherwise close the app
                DialogResult dialogResult = MessageBox.Show("Do you want to save your notepad before closing the application?", "Save notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = true;
                    // Perform click on the saveNotepadButton
                    saveNotepadButton.PerformClick();
                    notepadTextBox.Text = "";
                    // Once the notepad has been saved, close the application
                    Application.Exit();
                }
                if (dialogResult == DialogResult.No)
                {
                    notepadTextBox.Text = "";
                    // Close the application
                    Application.Exit();
                }
            }

            // Save the text in the entries.txt file and then hide the text in the file with *'s
            string[] entries = new string[entriesListBox.Items.Count];
            for (int i = 0; i < entriesListBox.Items.Count; i++)
            {
                // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                entries[i] = entriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
            }
            System.IO.File.WriteAllLines("entries.txt", entries);
            // Save the text in the entries.txt file in the setEntriesHide setting
            Properties.Settings.Default.setEntriesHide = System.IO.File.ReadAllText("entries.txt");
            Properties.Settings.Default.Save();
            string[] lines = System.IO.File.ReadAllLines("entries.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(lines[i], "******** - Do not edit this file; your saved entries may be lost if edited.");
            }
            System.IO.File.WriteAllLines("entries.txt", lines);

            // If the resetAccountCheckbox is checked, reset the setUserPassword and setYourName settings
            if (resetAccountCheckbox.Checked == true)
            {
                Properties.Settings.Default.setUserPassword = "";
                Properties.Settings.Default.setYourName = "";

                // Delete the entries.txt file
                System.IO.File.Delete("entries.txt");

                Properties.Settings.Default.Save();
            }
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Change the setIsUserLoggedIn setting to false
            Properties.Settings.Default.setIsUserLoggedIn = false;
            Properties.Settings.Default.Save();

            // Delete the entries.txt file if it is empty or if there are no entries in the entriesListBox but the file exists
            const string filename = "entries.txt";
            if (File.Exists(filename))
            {
                if (new FileInfo(filename).Length == 0)
                {
                    File.Delete(filename);
                }
            }
        }

        private void entriesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When the user double clicks on an entry in the entriesListBox, show a message box asking if the user wants to delete the entry
            if (entriesListBox.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this entry?", "SafeNotes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // If the user clicks yes, remove the selected item from the entriesListBox
                    entriesListBox.Items.Remove(entriesListBox.SelectedItems[0]);
                    // Now save this entry to a txt file in the location of the applications .exe
                    string[] entries = new string[entriesListBox.Items.Count];
                    // Update the savedEntriesCount label
                    savedEntriesCount.Text = "Saved entries: " + entriesListBox.Items.Count.ToString();
                    for (int i = 0; i < entriesListBox.Items.Count; i++)
                    {
                        // Do not include "ListViewItem:" in the txt file, instead say Entry # and the number of the entry
                        entries[i] = entriesListBox.Items[i].ToString().Replace("ListViewItem: {", "").Replace("}", "");
                    }
                    System.IO.File.WriteAllLines("entries.txt", entries);

                    // Create a notification using the notiPopup, which uses Tulpep. Notify the user that the entry has been saved and close the notification after 2 seconds
                    Tulpep.NotificationWindow.PopupNotifier notiPopup = new Tulpep.NotificationWindow.PopupNotifier();
                    notiPopup.TitleText = "SafeNotes";
                    notiPopup.ContentText = "Entry deleted";
                    notiPopup.Popup();
                }
            }
        }

        private void materialCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // If lightModeCheckbox is checked, save the value to setLightMode setting. When the value is saved, change the form and all the modules to light mode
            if (lightModeCheckbox.Checked == true)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                Properties.Settings.Default.setLightMode = true;
                Properties.Settings.Default.Save();
            }
            else if (lightModeCheckbox.Checked == false)
            {
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                Properties.Settings.Default.setLightMode = false;
                Properties.Settings.Default.Save();
            }
        }

        private void applyHourCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // If applyHourCheckbox is checked, save the value to setSaveHour setting. If it is not checked, save the value to setSaveHour setting
            if (applyDateCheckbox.Checked == true)
            {
                Properties.Settings.Default.setSaveDate = true;
                Properties.Settings.Default.Save();
            }
        }

        private void applyDateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (applyDateCheckbox.Checked == true)
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

        private void settingsPage_Click(object sender, EventArgs e)
        {
            // If the settingsPage is clicked, unfocus from everything and focus on the settingsPage
            this.ActiveControl = settingsPage;
        }

        private void resetLoginStatusButton_Click(object sender, EventArgs e)
        {
            // Reload the application and reset the login status
            Properties.Settings.Default.setIsUserLoggedIn = false;
            Application.Restart();
        }

        private void userLoginButton_Click(object sender, EventArgs e)
        {
            // If the button is pressed without anything in the userPassword or userConfirmPassword, show an error message
            if (string.IsNullOrWhiteSpace(userPassword.Text) && string.IsNullOrWhiteSpace(userConfirmPassword.Text))
            {
                MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // If the userLoginButton.Text is "Register", apply the text in userPassword to the setPassword setting as long as userPassword and userConfirmPassword match
            else if (userLoginButton.Text == "Register" && string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                if (userPassword.Text == userConfirmPassword.Text)
                {
                    Properties.Settings.Default.setUserPassword = userPassword.Text;
                    Properties.Settings.Default.Save();
                    userConfirmPassword.Visible = false;
                    userLoginButton.Text = "Login";
                    // Move the userPassword location to 300, 150
                    userPassword.Location = new System.Drawing.Point(300, 150);
                }
            }
            else if (userLoginButton.Text == "Login" && !string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                if (userPassword.Text == Properties.Settings.Default.setUserPassword)
                {
                    // Show that the user is logged in and make the entriesListBox visible
                    Properties.Settings.Default.setIsUserLoggedIn = true;
                    entriesListBox.Visible = true;
                    userLoginButton.Enabled = false;
                    tabSelect.Enabled = true;
                    // Do not show login page when the user is logged in
                    tabControl.TabPages.Remove(loginPage);
                    // If the entries.txt file exists, load the entries into the entriesListBox from the setEntriesShow setting
                    if (File.Exists("entries.txt"))
                    {
                        // Load text from setEntriesShow setting into the entries.txt file and then load the entries from the entries.txt file into the entriesListBox, only add them as a new entry if they begin with a date
                        File.WriteAllText("entries.txt", Properties.Settings.Default.setEntriesShow);
                        // Add the entries from the entries.txt file to the entriesListBox. Only add them as a new entry if they begin with a date (dd/mm/yyyy), add the rest to the last entry
                        string[] entries = File.ReadAllLines("entries.txt");
                        foreach (string entry in entries)
                        {
                            if (entry.StartsWith(DateTime.Now.ToString("dd/MM/yyyy")))
                            {
                                entriesListBox.Items.Add(entry);
                            }
                        }
                    }
                    // If there is more than 1 entry in the entriesListBox, show the deleteEntriesButton
                    if (entriesListBox.Items.Count > 1)
                    {
                        deleteEntriesButton.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("The password does not match the record on file...", "Password Missmatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Update the savedEntriesCount label
                savedEntriesCount.Text = "Saved entries: " + entriesListBox.Items.Count.ToString();
                // Update the charsInNotepad label
                charsInNotepad.Text = "Characters: " + notepadTextBox.Text.Length.ToString();

                // Update the columnInNotepad label, if the notepadTextBox.Text is empty, set the columnInNotepad label to 0
                if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
                {
                    columnInNotepad.Text = "Columns: 0";
                }
                else
                {
                    // Update the columnInNotepad label
                    columnInNotepad.Text = "Columns: " + notepadTextBox.Text.Split('\n').Length.ToString();
                }
            }
            // If the userConfirmPassword is not the same as the userPassword, show a message box
            if (string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword) && userPassword.Text != userConfirmPassword.Text)
            {
                MessageBox.Show("The passwords do not match.", "Mismatched passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void userPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the tab key is pressed, focus on the userConfirmPassword TextBox
            if (e.KeyChar == (char)Keys.Tab)
            {
                userConfirmPassword.Focus();
            }
            // If the user pressed the enter key, click the userLoginButton
            if (e.KeyChar == (char)Keys.Enter)
            {
                userLoginButton.PerformClick();
            }
        }

        private void userConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the enter key is pressed, click the userLoginButton
            if (e.KeyChar == (char)Keys.Enter)
            {
                userLoginButton.PerformClick();
            }
        }

        private void userPassword_MouseHover(object sender, EventArgs e)
        {
            // When the mouse hovers the userPassword textbox, show a baloon tip with the text in the HelperText field
            toolTips.Show(userPassword.HelperText, userPassword);
        }

        private void userConfirmPassword_MouseHover(object sender, EventArgs e)
        {
            // When the mouse hovers the userConfirmPassword textbox, show a baloon wip with the text in the HelperText field
            toolTips.Show(userConfirmPassword.HelperText, userConfirmPassword);
        }

        private void leftMenuNav_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // If the user clicks on the themeSetPage in the leftMenuNav, hide applyDateToEntryCheckbox, resetAccountOnCloseCheckbox and resetLoginStatusButton
            if (leftMenuNav.SelectedNode == leftMenuNav.Nodes[0])
            {
                lightModeCheckbox.Visible = true;

                applyDateCheckbox.Visible = false;
                resetAccountCheckbox.Visible = false;
                resetLoginStatusButton.Visible = false;
            }
            else if (leftMenuNav.SelectedNode == leftMenuNav.Nodes[1])
            {
                applyDateCheckbox.Visible = true;

                lightModeCheckbox.Visible = false;
                resetAccountCheckbox.Visible = false;
                resetLoginStatusButton.Visible = false;
            }
            else if (leftMenuNav.SelectedNode == leftMenuNav.Nodes[2])
            {
                resetAccountCheckbox.Visible = true;
                resetLoginStatusButton.Visible = true;

                applyDateCheckbox.Visible = false;
                lightModeCheckbox.Visible = false;
            }
        }

        private void deleteEntriesButton_Click(object sender, EventArgs e)
        {
            // If there are entries in the entriesListBox, delete them all
            if (entriesListBox.Items.Count > 0)
            {
                // Ask the user if they really want to delete the entries, if they say yes, delete the entries; otherwise, do not delete entries
                DialogResult deleteEntries = MessageBox.Show("Are you sure you want to delete all entries?", "Delete Entries", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteEntries == DialogResult.Yes)
                {
                    entriesListBox.Items.Clear();
                    // Save the entries to the setEntriesShow setting
                    Properties.Settings.Default.setEntriesShow = "";
                    Properties.Settings.Default.Save();
                    // Upodate the savedEntriesCount label
                    savedEntriesCount.Text = "Saved Entries: " + entriesListBox.Items.Count;
                    // Delete the entries.txt file
                    File.Delete("entries.txt");
                }

                if (entriesListBox.Items.Count == 0 && File.Exists("entries.txt") == false)
                {
                    // If there are no entries in the entriesListBox, disable the deleteEntriesButton
                    deleteEntriesButton.Visible = false;
                }
            }
        }

        private void userConfirmPassword_MouseClick(object sender, MouseEventArgs e)
        {
            // If user clicks the userConfirmPassword textBox, all text will be highlighted
            userConfirmPassword.SelectAll();
        }

        private void regenPassButton_Click(object sender, EventArgs e)
        {
            // Generate a random password and set it to the passwordGenBox for the user
            string password = "";
            Random random = new Random();
            // Generate the passworrd length according to the value in the passwordLengthSlider
            for (int i = 0; i < passwordLengthSlider.Value; i++)
            {
                password += (char)random.Next(33, 126);
            }
            usePassButton.Visible = true;
            passwordGenBox.Text = password;
        }

        private void usePassButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordGenBox.Text))
            {
                // Send a error to the user saying there is no password in the passwordGenBox
                MessageBox.Show("There is no password that has been generated, please generate a password first.", "No Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Check if the user has Bitwarden, KeePass, 1Password, LastPass, ProtonPass, or NordPass installed, if one of them are, ask if they want to save their password to their password manager
            if (File.Exists("C:\\Program Files\\Bitwarden\\Bitwarden.exe") || File.Exists("C:\\Program Files (x86)\\Bitwarden\\Bitwarden.exe") || File.Exists("C:\\Program Files\\KeePass Password Safe 2\\KeePass.exe") || File.Exists("C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe") || File.Exists("C:\\Program Files\\1Password\\1Password.exe") || File.Exists("C:\\Program Files (x86)\\1Password\\1Password.exe") || File.Exists("C:\\Program Files\\LastPass\\LastPass.exe") || File.Exists("C:\\Program Files (x86)\\LastPass\\LastPass.exe"))
            {
                DialogResult savePassword = MessageBox.Show("Do you want to save your password to your password manager?", "Save Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (savePassword == DialogResult.Yes)
                {
                    // If the user has Bitwarden installed, save the password to Bitwarden
                    if (File.Exists("C:\\Program Files\\Bitwarden\\Bitwarden.exe") || File.Exists("C:\\Program Files (x86)\\Bitwarden\\Bitwarden.exe"))
                    {
                        Process.Start("C:\\Program Files\\Bitwarden\\Bitwarden.exe", " --username " + userPassword.Text + " --password " + userConfirmPassword.Text);
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                    // If the user has KeePass installed, save the password to KeePass
                    else if (File.Exists("C:\\Program Files\\KeePass Password Safe 2\\KeePass.exe") || File.Exists("C:\\Program Files (x86)\\KeePass Password Safe 2\\KeePass.exe"))
                    {
                        Process.Start("C:\\Program Files\\KeePass Password Safe 2\\KeePass.exe", "\" -user=\"" + userPassword.Text + "\" -pw=\"" + userConfirmPassword.Text + "\"");
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                    // If the user has 1Password installed, save the password to 1Password
                    else if (File.Exists("C:\\Program Files\\1Password\\1Password.exe") || File.Exists("C:\\Program Files (x86)\\1Password\\1Password.exe"))
                    {
                        Process.Start("C:\\Program Files\\1Password\\1Password.exe", " --username " + userPassword.Text + " --password " + userConfirmPassword.Text);
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                    // If the user has LastPass installed, save the password to LastPass
                    else if (File.Exists("C:\\Program Files\\LastPass\\LastPass.exe") || File.Exists("C:\\Program Files (x86)\\LastPass\\LastPass.exe"))
                    {
                        Process.Start("C:\\Program Files\\LastPass\\LastPass.exe", " --username " + userPassword.Text + " --password " + userConfirmPassword.Text);
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                    // If the user has ProtonPass installed, save the password to ProtonPass
                    else if (File.Exists("C:\\Program Files\\ProtonPass\\ProtonPass.exe") || File.Exists("C:\\Program Files (x86)\\ProtonPass\\ProtonPass.exe"))
                    {
                        Process.Start("C:\\Program Files\\ProtonPass\\ProtonPass.exe", " --username " + userPassword.Text + " --password " + userConfirmPassword.Text);
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                    // If the user has NordPass installed, save the password to NordPass
                    else if (File.Exists("C:\\Program Files\\NordPass\\NordPass.exe") || File.Exists("C:\\Program Files (x86)\\NordPass\\NordPass.exe"))
                    {
                        Process.Start("C:\\Program Files\\NordPass\\NordPass.exe", " --username " + userPassword.Text + " --password " + userConfirmPassword.Text);
                        // Paste the password into the userPassword and userConfirmPassword textboxes
                        userPassword.Text = passwordGenBox.Text;
                        userConfirmPassword.Text = passwordGenBox.Text;
                    }
                }
            }
        }

        private void checkTimer_Tick(object sender, EventArgs e)
        {
            // If the entriesListBox does not have any items, disable the deleteEntriesButton
            if (entriesListBox.Items.Count <= 1)
            {
                deleteEntriesButton.Visible = false;
            }

            // Check if the user has a password set, if they do, make the passwordGenBox, regenPassButton and usePassButton invisible
            if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.setUserPassword))
            {
                passwordGenBox.Visible = false;
                regenPassButton.Visible = false;
                usePassButton.Visible = false;
                passwordLengthSlider.Visible = false;
            }
            else
            {
                passwordGenBox.Visible = true;
                regenPassButton.Visible = true;
                passwordLengthSlider.Visible = true;
            }
        }

        private void passwordGenBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Copy the passwordGenBox text to the clipboard
            Clipboard.SetText(passwordGenBox.Text);
            // Tell the user they copied the password to the clipboard using the passwordCopiedLabel. Make the passwordCopiedLabel visible for 3 seconds, do not use Task.Delay because it will freeze the UI
            passwordCopiedLabel.Visible = true;
            // Highlight all the text in the passwordGenBox
            passwordGenBox.SelectAll();
            passwordCopiedLabel.Text = "Password copied to clipboard";
            // Hide the passwordCopiedLabel after 3 seconds
            labelVisibilityTimer.Start();
        }

        private void labelVisibilityTimer_Tick(object sender, EventArgs e)
        {
            // Hide the passwordCopiedLabel
            passwordCopiedLabel.Visible = false;
        }

        private void notepadTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.notepadSaveText = notepadTextBox.Text;

            // If the notepadTextBox text changes, change the charsInNotepad label to equal the amount of text in the notepadTextBox
            charsInNotepad.Text = "Characters: " + notepadTextBox.Text.Length.ToString();

            // Update the columnInNotepad label, if the notepadTextBox.Text is empty, set the columnInNotepad label to 0
            if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
            {
                columnInNotepad.Text = "Columns: 0";
            }
            else
            {
                // Update the columnInNotepad label
                columnInNotepad.Text = "Columns: " + notepadTextBox.Text.Split('\n').Length.ToString();
            }

            // If the text is empty, change the title of the app to its default
            if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
            {
                // Change the title of the form
                this.Text = "SafeNotes";

                // Add the build version of the application to the title
                this.Text += " - v" + Application.ProductVersion;
            }
        }

        private void saveNotepadButton_Click(object sender, EventArgs e)
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
                    if (notepadTitle.Visible == true)
                    {
                        notepadTitle.Visible = false;
                    }
                }
            }
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            // If the notepadPage is clicked, unfocus from everything and focus on the notepadPage
            this.ActiveControl = notepadPage;
        }

        private void savedEntriesCount_Click(object sender, EventArgs e)
        {
            // If the user clicks the savedEntriesCount label, show the number of entries in a messagebox
            MessageBox.Show("You have " + entriesListBox.Items.Count.ToString() + " saved entries. ", "Saved Entries", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            // Ask the user where they want to open the file from
            OpenFileDialog openNotepad = new OpenFileDialog();
            openNotepad.Filter = "Text File (*.txt)|*.txt";
            openNotepad.Title = "Open Notepad";
            openNotepad.ShowDialog();
            // Change the title of the app on the notepadPage to the name of the file + " - SafeNotes"
            notepadTitle.Visible = true;
            notepadTitle.Text = "Opened File: " + openNotepad.SafeFileName;
            // If the user clicks the open button, open the file from the location they chose
            if (!string.IsNullOrWhiteSpace(openNotepad.FileName))
            {
                // If the file is more than 32767 characters, do not open it and tell the user it is too big
                if (File.ReadAllText(openNotepad.FileName).Length > 32767)
                {
                    MessageBox.Show("The file you are trying to open is too big, please open a file that is less than 32768 characters.", "File Too Big", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notepadTitle.Visible = false;
                }
                else
                {
                    notepadTextBox.Text = File.ReadAllText(openNotepad.FileName);
                }
                // If the file is empty, tell the user they cannot open an empty file
                if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
                {
                    MessageBox.Show("You cannot open an empty file.", "Empty File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notepadTitle.Visible = false;
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Clear the text in the notepadTextBox
            notepadTextBox.Text = "";
            notepadTitle.Visible = false;
        }

        private void charsInNotepad_Click(object sender, EventArgs e)
        {
            // if the user clicks the label, display the amount of characters and lines used in the notepadTextBox
            MessageBox.Show("You have used " + notepadTextBox.Text.Length.ToString() + " character(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void columnInNotepad_Click(object sender, EventArgs e)
        {
            // If the user clicks the label, display the amount of colums used in the notepadTextBox; however, if the notepadTextBox is empty, display 0
            if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
            {
                MessageBox.Show("You have used 0 column(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have used " + notepadTextBox.Text.Split('\n').Length.ToString() + " column(s) in your Notepad", "Notepad Stats", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void notepadTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
                        notepadTextBox.Text = File.ReadAllText(openNotepad.FileName);
                    }
                    // If the file is empty, tell the user they cannot open an empty file
                    if (string.IsNullOrWhiteSpace(notepadTextBox.Text))
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

        private void notepadTitle_Click(object sender, EventArgs e)
        {
            // Unfocus from everything and focus to the notepadPage
            notepadPage.Focus();
        }
    }
}
namespace SafeNotes
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Theme");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Account");
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.PasswordCopiedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordLengthSlider = new MaterialSkin.Controls.MaterialSlider();
            this.UsePassButton = new MaterialSkin.Controls.MaterialButton();
            this.RegenPassButton = new MaterialSkin.Controls.MaterialButton();
            this.PasswordGenBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.UserLoginButton = new MaterialSkin.Controls.MaterialButton();
            this.LoginTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.UserConfirmPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.UserPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.JournalEntryPage = new System.Windows.Forms.TabPage();
            this.DecryptionStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SavedEntriesCount = new MaterialSkin.Controls.MaterialLabel();
            this.ChangeNameButton = new MaterialSkin.Controls.MaterialButton();
            this.YourNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveEntryButton = new MaterialSkin.Controls.MaterialButton();
            this.JournalEntryBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.JournalTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.NotepadPage = new System.Windows.Forms.TabPage();
            this.NotepadTitle = new MaterialSkin.Controls.MaterialLabel();
            this.ColumnInNotepad = new MaterialSkin.Controls.MaterialLabel();
            this.CharsInNotepad = new MaterialSkin.Controls.MaterialLabel();
            this.ClearNotepadButton = new MaterialSkin.Controls.MaterialButton();
            this.OpenFileButton = new MaterialSkin.Controls.MaterialButton();
            this.SaveNotepadButton = new MaterialSkin.Controls.MaterialButton();
            this.NotepadTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.NotepadTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.JournalEntriesPage = new System.Windows.Forms.TabPage();
            this.EditEntryButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.EntriesListBox = new MaterialSkin.Controls.MaterialListView();
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContentsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EntriesTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.LeftSettingsNav = new Mook.UI.Windows.Forms.LeftMenuNav();
            this.ResetAccountCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ResetLoginStatusButton = new MaterialSkin.Controls.MaterialButton();
            this.ApplyDateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.LightModeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SettingsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelVisibilityTimer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.JournalEntryPage.SuspendLayout();
            this.NotepadPage.SuspendLayout();
            this.JournalEntriesPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LoginPage);
            this.TabControl.Controls.Add(this.JournalEntryPage);
            this.TabControl.Controls.Add(this.NotepadPage);
            this.TabControl.Controls.Add(this.JournalEntriesPage);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(844, 464);
            this.TabControl.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LoginPage.Controls.Add(this.materialLabel1);
            this.LoginPage.Controls.Add(this.PasswordCopiedLabel);
            this.LoginPage.Controls.Add(this.PasswordLengthSlider);
            this.LoginPage.Controls.Add(this.UsePassButton);
            this.LoginPage.Controls.Add(this.RegenPassButton);
            this.LoginPage.Controls.Add(this.PasswordGenBox);
            this.LoginPage.Controls.Add(this.UserLoginButton);
            this.LoginPage.Controls.Add(this.LoginTabSelector);
            this.LoginPage.Controls.Add(this.UserConfirmPassword);
            this.LoginPage.Controls.Add(this.UserPassword);
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(836, 438);
            this.LoginPage.TabIndex = 4;
            this.LoginPage.Text = "Login";
            // 
            // PasswordCopiedLabel
            // 
            this.PasswordCopiedLabel.AutoSize = true;
            this.PasswordCopiedLabel.Depth = 0;
            this.PasswordCopiedLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordCopiedLabel.Location = new System.Drawing.Point(247, 224);
            this.PasswordCopiedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordCopiedLabel.Name = "PasswordCopiedLabel";
            this.PasswordCopiedLabel.Size = new System.Drawing.Size(1, 0);
            this.PasswordCopiedLabel.TabIndex = 8;
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLengthSlider.Depth = 0;
            this.PasswordLengthSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLengthSlider.Location = new System.Drawing.Point(250, 354);
            this.PasswordLengthSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.RangeMax = 32;
            this.PasswordLengthSlider.Size = new System.Drawing.Size(351, 40);
            this.PasswordLengthSlider.TabIndex = 7;
            this.PasswordLengthSlider.Text = "Password Length";
            this.ToolTips.SetToolTip(this.PasswordLengthSlider, "Changes the amount of characters generated for password.");
            this.PasswordLengthSlider.Value = 16;
            this.PasswordLengthSlider.Visible = false;
            // 
            // UsePassButton
            // 
            this.UsePassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UsePassButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UsePassButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UsePassButton.Depth = 0;
            this.UsePassButton.HighEmphasis = true;
            this.UsePassButton.Icon = null;
            this.UsePassButton.Location = new System.Drawing.Point(250, 309);
            this.UsePassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UsePassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsePassButton.Name = "UsePassButton";
            this.UsePassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UsePassButton.Size = new System.Drawing.Size(131, 36);
            this.UsePassButton.TabIndex = 6;
            this.UsePassButton.Text = "Use Password";
            this.ToolTips.SetToolTip(this.UsePassButton, "Copies the password for use");
            this.UsePassButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UsePassButton.UseAccentColor = false;
            this.UsePassButton.UseVisualStyleBackColor = true;
            this.UsePassButton.Visible = false;
            this.UsePassButton.Click += new System.EventHandler(this.UsePassButton_Click);
            // 
            // RegenPassButton
            // 
            this.RegenPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegenPassButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegenPassButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegenPassButton.Depth = 0;
            this.RegenPassButton.HighEmphasis = true;
            this.RegenPassButton.Icon = null;
            this.RegenPassButton.Location = new System.Drawing.Point(506, 309);
            this.RegenPassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegenPassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegenPassButton.Name = "RegenPassButton";
            this.RegenPassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegenPassButton.Size = new System.Drawing.Size(95, 36);
            this.RegenPassButton.TabIndex = 5;
            this.RegenPassButton.Text = "Generate";
            this.ToolTips.SetToolTip(this.RegenPassButton, "Regenerates a new password");
            this.RegenPassButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegenPassButton.UseAccentColor = false;
            this.RegenPassButton.UseVisualStyleBackColor = true;
            this.RegenPassButton.Visible = false;
            this.RegenPassButton.Click += new System.EventHandler(this.RegenPassButton_Click);
            // 
            // PasswordGenBox
            // 
            this.PasswordGenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordGenBox.AnimateReadOnly = false;
            this.PasswordGenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordGenBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordGenBox.Depth = 0;
            this.PasswordGenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordGenBox.HideSelection = true;
            this.PasswordGenBox.LeadingIcon = null;
            this.PasswordGenBox.Location = new System.Drawing.Point(250, 252);
            this.PasswordGenBox.MaxLength = 32767;
            this.PasswordGenBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PasswordGenBox.Name = "PasswordGenBox";
            this.PasswordGenBox.PasswordChar = '\0';
            this.PasswordGenBox.PrefixSuffixText = null;
            this.PasswordGenBox.ReadOnly = true;
            this.PasswordGenBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordGenBox.SelectedText = "";
            this.PasswordGenBox.SelectionLength = 0;
            this.PasswordGenBox.SelectionStart = 0;
            this.PasswordGenBox.ShortcutsEnabled = true;
            this.PasswordGenBox.Size = new System.Drawing.Size(351, 48);
            this.PasswordGenBox.TabIndex = 4;
            this.PasswordGenBox.TabStop = false;
            this.PasswordGenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordGenBox.TrailingIcon = null;
            this.PasswordGenBox.UseSystemPasswordChar = false;
            this.PasswordGenBox.Visible = false;
            this.PasswordGenBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PasswordGenBox_MouseDoubleClick);
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserLoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserLoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UserLoginButton.Depth = 0;
            this.UserLoginButton.HighEmphasis = true;
            this.UserLoginButton.Icon = null;
            this.UserLoginButton.Location = new System.Drawing.Point(462, 207);
            this.UserLoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserLoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UserLoginButton.Size = new System.Drawing.Size(89, 36);
            this.UserLoginButton.TabIndex = 3;
            this.UserLoginButton.Text = "Register";
            this.UserLoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UserLoginButton.UseAccentColor = false;
            this.UserLoginButton.UseVisualStyleBackColor = true;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // LoginTabSelector
            // 
            this.LoginTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTabSelector.BaseTabControl = this.TabControl;
            this.LoginTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.LoginTabSelector.Depth = 0;
            this.LoginTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LoginTabSelector.Location = new System.Drawing.Point(3, 3);
            this.LoginTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginTabSelector.Name = "LoginTabSelector";
            this.LoginTabSelector.Size = new System.Drawing.Size(830, 25);
            this.LoginTabSelector.TabIndex = 2;
            this.LoginTabSelector.Text = "TabSelect1";
            // 
            // UserConfirmPassword
            // 
            this.UserConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserConfirmPassword.AnimateReadOnly = false;
            this.UserConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserConfirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserConfirmPassword.Depth = 0;
            this.UserConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserConfirmPassword.HelperText = "Password field, used to confirm your password.";
            this.UserConfirmPassword.HideSelection = true;
            this.UserConfirmPassword.Hint = "Confirm password...";
            this.UserConfirmPassword.LeadingIcon = null;
            this.UserConfirmPassword.Location = new System.Drawing.Point(300, 150);
            this.UserConfirmPassword.MaxLength = 32767;
            this.UserConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.UserConfirmPassword.Name = "UserConfirmPassword";
            this.UserConfirmPassword.PasswordChar = '*';
            this.UserConfirmPassword.PrefixSuffixText = null;
            this.UserConfirmPassword.ReadOnly = false;
            this.UserConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserConfirmPassword.SelectedText = "";
            this.UserConfirmPassword.SelectionLength = 0;
            this.UserConfirmPassword.SelectionStart = 0;
            this.UserConfirmPassword.ShortcutsEnabled = true;
            this.UserConfirmPassword.Size = new System.Drawing.Size(251, 48);
            this.UserConfirmPassword.TabIndex = 1;
            this.UserConfirmPassword.TabStop = false;
            this.UserConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserConfirmPassword.TrailingIcon = null;
            this.UserConfirmPassword.UseSystemPasswordChar = false;
            this.UserConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserConfirmPassword_KeyPress);
            this.UserConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserConfirmPassword_MouseClick);
            this.UserConfirmPassword.MouseHover += new System.EventHandler(this.UserConfirmPassword_MouseHover);
            // 
            // UserPassword
            // 
            this.UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPassword.AnimateReadOnly = false;
            this.UserPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserPassword.Depth = 0;
            this.UserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserPassword.HelperText = "Journal password, used for securing Journal Entries.";
            this.UserPassword.HideSelection = true;
            this.UserPassword.Hint = "Password...";
            this.UserPassword.LeadingIcon = null;
            this.UserPassword.Location = new System.Drawing.Point(300, 96);
            this.UserPassword.MaxLength = 32767;
            this.UserPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.PrefixSuffixText = null;
            this.UserPassword.ReadOnly = false;
            this.UserPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserPassword.SelectedText = "";
            this.UserPassword.SelectionLength = 0;
            this.UserPassword.SelectionStart = 0;
            this.UserPassword.ShortcutsEnabled = true;
            this.UserPassword.Size = new System.Drawing.Size(251, 48);
            this.UserPassword.TabIndex = 0;
            this.UserPassword.TabStop = false;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserPassword.TrailingIcon = null;
            this.UserPassword.UseSystemPasswordChar = false;
            this.UserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserPassword_KeyPress);
            this.UserPassword.MouseHover += new System.EventHandler(this.UserPassword_MouseHover);
            // 
            // JournalEntryPage
            // 
            this.JournalEntryPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.JournalEntryPage.Controls.Add(this.DecryptionStatusLabel);
            this.JournalEntryPage.Controls.Add(this.SavedEntriesCount);
            this.JournalEntryPage.Controls.Add(this.ChangeNameButton);
            this.JournalEntryPage.Controls.Add(this.YourNameBox);
            this.JournalEntryPage.Controls.Add(this.SaveEntryButton);
            this.JournalEntryPage.Controls.Add(this.JournalEntryBox);
            this.JournalEntryPage.Controls.Add(this.JournalTabSelector);
            this.JournalEntryPage.Location = new System.Drawing.Point(4, 22);
            this.JournalEntryPage.Name = "JournalEntryPage";
            this.JournalEntryPage.Padding = new System.Windows.Forms.Padding(3);
            this.JournalEntryPage.Size = new System.Drawing.Size(836, 438);
            this.JournalEntryPage.TabIndex = 0;
            this.JournalEntryPage.Text = "Journal";
            this.JournalEntryPage.Click += new System.EventHandler(this.JournalEntryPage_Click);
            // 
            // DecryptionStatusLabel
            // 
            this.DecryptionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DecryptionStatusLabel.Depth = 0;
            this.DecryptionStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DecryptionStatusLabel.Location = new System.Drawing.Point(291, 405);
            this.DecryptionStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DecryptionStatusLabel.Name = "DecryptionStatusLabel";
            this.DecryptionStatusLabel.Size = new System.Drawing.Size(170, 19);
            this.DecryptionStatusLabel.TabIndex = 9;
            this.DecryptionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SavedEntriesCount
            // 
            this.SavedEntriesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedEntriesCount.Depth = 0;
            this.SavedEntriesCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SavedEntriesCount.Location = new System.Drawing.Point(549, 397);
            this.SavedEntriesCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.SavedEntriesCount.Name = "SavedEntriesCount";
            this.SavedEntriesCount.Size = new System.Drawing.Size(170, 19);
            this.SavedEntriesCount.TabIndex = 8;
            this.SavedEntriesCount.Text = "Saved entries: 0";
            this.SavedEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SavedEntriesCount.Click += new System.EventHandler(this.SavedEntriesCount_Click);
            // 
            // ChangeNameButton
            // 
            this.ChangeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangeNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangeNameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChangeNameButton.Depth = 0;
            this.ChangeNameButton.HighEmphasis = true;
            this.ChangeNameButton.Icon = null;
            this.ChangeNameButton.Location = new System.Drawing.Point(160, 396);
            this.ChangeNameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeNameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChangeNameButton.Size = new System.Drawing.Size(125, 36);
            this.ChangeNameButton.TabIndex = 6;
            this.ChangeNameButton.Text = "Save name";
            this.ChangeNameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChangeNameButton.UseAccentColor = false;
            this.ChangeNameButton.UseVisualStyleBackColor = true;
            this.ChangeNameButton.Click += new System.EventHandler(this.ChangeNameButton_Click);
            // 
            // YourNameBox
            // 
            this.YourNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.YourNameBox.AnimateReadOnly = false;
            this.YourNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.YourNameBox.Depth = 0;
            this.YourNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.YourNameBox.Hint = "Your name...";
            this.YourNameBox.LeadingIcon = null;
            this.YourNameBox.Location = new System.Drawing.Point(3, 396);
            this.YourNameBox.MaxLength = 50;
            this.YourNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.YourNameBox.Multiline = false;
            this.YourNameBox.Name = "YourNameBox";
            this.YourNameBox.ReadOnly = true;
            this.YourNameBox.Size = new System.Drawing.Size(150, 36);
            this.YourNameBox.TabIndex = 5;
            this.YourNameBox.Text = "";
            this.YourNameBox.TrailingIcon = null;
            this.YourNameBox.UseTallSize = false;
            // 
            // SaveEntryButton
            // 
            this.SaveEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEntryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveEntryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveEntryButton.Depth = 0;
            this.SaveEntryButton.HighEmphasis = true;
            this.SaveEntryButton.Icon = null;
            this.SaveEntryButton.Location = new System.Drawing.Point(726, 396);
            this.SaveEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveEntryButton.Name = "SaveEntryButton";
            this.SaveEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveEntryButton.Size = new System.Drawing.Size(107, 36);
            this.SaveEntryButton.TabIndex = 2;
            this.SaveEntryButton.Text = "Save Entry";
            this.ToolTips.SetToolTip(this.SaveEntryButton, "Saves your entry into your Journal");
            this.SaveEntryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveEntryButton.UseAccentColor = false;
            this.SaveEntryButton.UseVisualStyleBackColor = true;
            this.SaveEntryButton.Click += new System.EventHandler(this.SaveEntryButton_Click);
            // 
            // JournalEntryBox
            // 
            this.JournalEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JournalEntryBox.AnimateReadOnly = false;
            this.JournalEntryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.JournalEntryBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.JournalEntryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JournalEntryBox.Depth = 0;
            this.JournalEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalEntryBox.HideSelection = true;
            this.JournalEntryBox.Hint = "Your journal...";
            this.JournalEntryBox.Location = new System.Drawing.Point(3, 31);
            this.JournalEntryBox.Margin = new System.Windows.Forms.Padding(1);
            this.JournalEntryBox.MaxLength = 32767;
            this.JournalEntryBox.MouseState = MaterialSkin.MouseState.OUT;
            this.JournalEntryBox.Name = "JournalEntryBox";
            this.JournalEntryBox.PasswordChar = '\0';
            this.JournalEntryBox.ReadOnly = false;
            this.JournalEntryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JournalEntryBox.SelectedText = "";
            this.JournalEntryBox.SelectionLength = 0;
            this.JournalEntryBox.SelectionStart = 0;
            this.JournalEntryBox.ShortcutsEnabled = true;
            this.JournalEntryBox.Size = new System.Drawing.Size(830, 358);
            this.JournalEntryBox.TabIndex = 1;
            this.JournalEntryBox.TabStop = false;
            this.JournalEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JournalEntryBox.UseSystemPasswordChar = false;
            this.JournalEntryBox.TextChanged += new System.EventHandler(this.JournalEntryBox_TextChanged);
            // 
            // JournalTabSelector
            // 
            this.JournalTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JournalTabSelector.BaseTabControl = this.TabControl;
            this.JournalTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.JournalTabSelector.Depth = 0;
            this.JournalTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.JournalTabSelector.Location = new System.Drawing.Point(3, 3);
            this.JournalTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.JournalTabSelector.Name = "JournalTabSelector";
            this.JournalTabSelector.Size = new System.Drawing.Size(830, 24);
            this.JournalTabSelector.TabIndex = 0;
            this.JournalTabSelector.Text = "MaterialTabSelector1";
            // 
            // NotepadPage
            // 
            this.NotepadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.NotepadPage.Controls.Add(this.NotepadTitle);
            this.NotepadPage.Controls.Add(this.ColumnInNotepad);
            this.NotepadPage.Controls.Add(this.CharsInNotepad);
            this.NotepadPage.Controls.Add(this.ClearNotepadButton);
            this.NotepadPage.Controls.Add(this.OpenFileButton);
            this.NotepadPage.Controls.Add(this.SaveNotepadButton);
            this.NotepadPage.Controls.Add(this.NotepadTabSelector);
            this.NotepadPage.Controls.Add(this.NotepadTextBox);
            this.NotepadPage.Location = new System.Drawing.Point(4, 22);
            this.NotepadPage.Name = "NotepadPage";
            this.NotepadPage.Size = new System.Drawing.Size(836, 438);
            this.NotepadPage.TabIndex = 5;
            this.NotepadPage.Text = "Notepad";
            this.NotepadPage.Click += new System.EventHandler(this.Notepad_Click);
            // 
            // NotepadTitle
            // 
            this.NotepadTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NotepadTitle.Depth = 0;
            this.NotepadTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotepadTitle.Location = new System.Drawing.Point(147, 396);
            this.NotepadTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotepadTitle.Name = "NotepadTitle";
            this.NotepadTitle.Size = new System.Drawing.Size(314, 36);
            this.NotepadTitle.TabIndex = 9;
            this.NotepadTitle.Text = "Notepad Title";
            this.NotepadTitle.Visible = false;
            this.NotepadTitle.Click += new System.EventHandler(this.NotepadTitle_Click);
            // 
            // ColumnInNotepad
            // 
            this.ColumnInNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnInNotepad.Depth = 0;
            this.ColumnInNotepad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ColumnInNotepad.Location = new System.Drawing.Point(480, 415);
            this.ColumnInNotepad.MouseState = MaterialSkin.MouseState.HOVER;
            this.ColumnInNotepad.Name = "ColumnInNotepad";
            this.ColumnInNotepad.Size = new System.Drawing.Size(117, 19);
            this.ColumnInNotepad.TabIndex = 8;
            this.ColumnInNotepad.Text = "Columns: 10923";
            this.ColumnInNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColumnInNotepad.Click += new System.EventHandler(this.ColumnInNotepad_Click);
            // 
            // CharsInNotepad
            // 
            this.CharsInNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CharsInNotepad.Depth = 0;
            this.CharsInNotepad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CharsInNotepad.Location = new System.Drawing.Point(467, 396);
            this.CharsInNotepad.MouseState = MaterialSkin.MouseState.HOVER;
            this.CharsInNotepad.Name = "CharsInNotepad";
            this.CharsInNotepad.Size = new System.Drawing.Size(130, 19);
            this.CharsInNotepad.TabIndex = 7;
            this.CharsInNotepad.Text = "Characters: 32767";
            this.CharsInNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CharsInNotepad.Click += new System.EventHandler(this.CharsInNotepad_Click);
            // 
            // ClearNotepadButton
            // 
            this.ClearNotepadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearNotepadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClearNotepadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ClearNotepadButton.Depth = 0;
            this.ClearNotepadButton.HighEmphasis = true;
            this.ClearNotepadButton.Icon = null;
            this.ClearNotepadButton.Location = new System.Drawing.Point(3, 396);
            this.ClearNotepadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClearNotepadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClearNotepadButton.Name = "ClearNotepadButton";
            this.ClearNotepadButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ClearNotepadButton.Size = new System.Drawing.Size(137, 36);
            this.ClearNotepadButton.TabIndex = 6;
            this.ClearNotepadButton.Text = "Clear Notepad";
            this.ClearNotepadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ClearNotepadButton.UseAccentColor = false;
            this.ClearNotepadButton.UseVisualStyleBackColor = true;
            this.ClearNotepadButton.Click += new System.EventHandler(this.ClearNotepadButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenFileButton.Depth = 0;
            this.OpenFileButton.HighEmphasis = true;
            this.OpenFileButton.Icon = null;
            this.OpenFileButton.Location = new System.Drawing.Point(604, 396);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenFileButton.Size = new System.Drawing.Size(92, 36);
            this.OpenFileButton.TabIndex = 5;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenFileButton.UseAccentColor = false;
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveNotepadButton
            // 
            this.SaveNotepadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveNotepadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveNotepadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveNotepadButton.Depth = 0;
            this.SaveNotepadButton.HighEmphasis = true;
            this.SaveNotepadButton.Icon = null;
            this.SaveNotepadButton.Location = new System.Drawing.Point(705, 396);
            this.SaveNotepadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveNotepadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveNotepadButton.Name = "SaveNotepadButton";
            this.SaveNotepadButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveNotepadButton.Size = new System.Drawing.Size(128, 36);
            this.SaveNotepadButton.TabIndex = 4;
            this.SaveNotepadButton.Text = "Save Notepad";
            this.SaveNotepadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveNotepadButton.UseAccentColor = false;
            this.SaveNotepadButton.UseVisualStyleBackColor = true;
            this.SaveNotepadButton.Click += new System.EventHandler(this.SaveNotepadButton_Click);
            // 
            // NotepadTabSelector
            // 
            this.NotepadTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadTabSelector.BaseTabControl = this.TabControl;
            this.NotepadTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.NotepadTabSelector.Depth = 0;
            this.NotepadTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotepadTabSelector.Location = new System.Drawing.Point(3, 3);
            this.NotepadTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotepadTabSelector.Name = "NotepadTabSelector";
            this.NotepadTabSelector.Size = new System.Drawing.Size(830, 24);
            this.NotepadTabSelector.TabIndex = 3;
            this.NotepadTabSelector.Text = "TabSelect1";
            // 
            // NotepadTextBox
            // 
            this.NotepadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotepadTextBox.AnimateReadOnly = false;
            this.NotepadTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NotepadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NotepadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotepadTextBox.Depth = 0;
            this.NotepadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotepadTextBox.HideSelection = true;
            this.NotepadTextBox.Hint = "Aa...";
            this.NotepadTextBox.Location = new System.Drawing.Point(3, 31);
            this.NotepadTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.NotepadTextBox.MaxLength = 32767;
            this.NotepadTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.NotepadTextBox.Name = "NotepadTextBox";
            this.NotepadTextBox.PasswordChar = '\0';
            this.NotepadTextBox.ReadOnly = false;
            this.NotepadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NotepadTextBox.SelectedText = "";
            this.NotepadTextBox.SelectionLength = 0;
            this.NotepadTextBox.SelectionStart = 0;
            this.NotepadTextBox.ShortcutsEnabled = true;
            this.NotepadTextBox.Size = new System.Drawing.Size(830, 364);
            this.NotepadTextBox.TabIndex = 2;
            this.NotepadTextBox.TabStop = false;
            this.NotepadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NotepadTextBox.UseSystemPasswordChar = false;
            this.NotepadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotepadTextBox_KeyPress);
            this.NotepadTextBox.TextChanged += new System.EventHandler(this.NotepadTextBox_TextChanged);
            // 
            // JournalEntriesPage
            // 
            this.JournalEntriesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.JournalEntriesPage.Controls.Add(this.EditEntryButton);
            this.JournalEntriesPage.Controls.Add(this.DeleteEntriesButton);
            this.JournalEntriesPage.Controls.Add(this.EntriesListBox);
            this.JournalEntriesPage.Controls.Add(this.EntriesTabSelector);
            this.JournalEntriesPage.Location = new System.Drawing.Point(4, 22);
            this.JournalEntriesPage.Name = "JournalEntriesPage";
            this.JournalEntriesPage.Size = new System.Drawing.Size(836, 438);
            this.JournalEntriesPage.TabIndex = 2;
            this.JournalEntriesPage.Text = "Journal Entries";
            // 
            // EditEntryButton
            // 
            this.EditEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditEntryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EditEntryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EditEntryButton.Depth = 0;
            this.EditEntryButton.HighEmphasis = true;
            this.EditEntryButton.Icon = null;
            this.EditEntryButton.Location = new System.Drawing.Point(4, 396);
            this.EditEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditEntryButton.Name = "EditEntryButton";
            this.EditEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditEntryButton.Size = new System.Drawing.Size(102, 36);
            this.EditEntryButton.TabIndex = 4;
            this.EditEntryButton.Text = "Edit entry";
            this.ToolTips.SetToolTip(this.EditEntryButton, "Edits the selected entry.");
            this.EditEntryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EditEntryButton.UseAccentColor = false;
            this.EditEntryButton.UseVisualStyleBackColor = true;
            this.EditEntryButton.Visible = false;
            this.EditEntryButton.Click += new System.EventHandler(this.EditEntryButton_Click);
            // 
            // DeleteEntriesButton
            // 
            this.DeleteEntriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteEntriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteEntriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteEntriesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteEntriesButton.Depth = 0;
            this.DeleteEntriesButton.HighEmphasis = true;
            this.DeleteEntriesButton.Icon = null;
            this.DeleteEntriesButton.Location = new System.Drawing.Point(696, 396);
            this.DeleteEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteEntriesButton.Name = "DeleteEntriesButton";
            this.DeleteEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteEntriesButton.Size = new System.Drawing.Size(136, 36);
            this.DeleteEntriesButton.TabIndex = 3;
            this.DeleteEntriesButton.Text = "Delete entries";
            this.ToolTips.SetToolTip(this.DeleteEntriesButton, "Deletes all entered entries");
            this.DeleteEntriesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteEntriesButton.UseAccentColor = false;
            this.DeleteEntriesButton.UseVisualStyleBackColor = true;
            this.DeleteEntriesButton.Visible = false;
            this.DeleteEntriesButton.Click += new System.EventHandler(this.DeleteEntriesButton_Click);
            // 
            // EntriesListBox
            // 
            this.EntriesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesListBox.AutoSizeTable = false;
            this.EntriesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EntriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntriesListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DateCol,
            this.ContentsCol});
            this.EntriesListBox.Depth = 0;
            this.EntriesListBox.FullRowSelect = true;
            this.EntriesListBox.HideSelection = false;
            this.EntriesListBox.Location = new System.Drawing.Point(3, 33);
            this.EntriesListBox.MinimumSize = new System.Drawing.Size(200, 100);
            this.EntriesListBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EntriesListBox.MouseState = MaterialSkin.MouseState.OUT;
            this.EntriesListBox.Name = "EntriesListBox";
            this.EntriesListBox.OwnerDraw = true;
            this.EntriesListBox.Size = new System.Drawing.Size(830, 354);
            this.EntriesListBox.TabIndex = 2;
            this.EntriesListBox.UseCompatibleStateImageBehavior = false;
            this.EntriesListBox.View = System.Windows.Forms.View.Details;
            this.EntriesListBox.Visible = false;
            this.EntriesListBox.SelectedIndexChanged += new System.EventHandler(this.EntriesListBox_SelectedIndexChanged);
            this.EntriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EntriesListBox_MouseDoubleClick);
            // 
            // DateCol
            // 
            this.DateCol.Text = "Date";
            this.DateCol.Width = 175;
            // 
            // ContentsCol
            // 
            this.ContentsCol.Text = "Contents";
            this.ContentsCol.Width = 500;
            // 
            // EntriesTabSelector
            // 
            this.EntriesTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesTabSelector.BaseTabControl = this.TabControl;
            this.EntriesTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.EntriesTabSelector.Depth = 0;
            this.EntriesTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EntriesTabSelector.Location = new System.Drawing.Point(3, 3);
            this.EntriesTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.EntriesTabSelector.Name = "EntriesTabSelector";
            this.EntriesTabSelector.Size = new System.Drawing.Size(830, 24);
            this.EntriesTabSelector.TabIndex = 1;
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingsPage.Controls.Add(this.LeftSettingsNav);
            this.SettingsPage.Controls.Add(this.ResetAccountCheckbox);
            this.SettingsPage.Controls.Add(this.ResetLoginStatusButton);
            this.SettingsPage.Controls.Add(this.ApplyDateCheckbox);
            this.SettingsPage.Controls.Add(this.LightModeCheckbox);
            this.SettingsPage.Controls.Add(this.SettingsTabSelector);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(836, 438);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.Click += new System.EventHandler(this.SettingsPage_Click);
            // 
            // LeftSettingsNav
            // 
            this.LeftSettingsNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.LeftSettingsNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftSettingsNav.CustomModel = true;
            this.LeftSettingsNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSettingsNav.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.LeftSettingsNav.FullRowSelect = true;
            this.LeftSettingsNav.HideSelection = false;
            this.LeftSettingsNav.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.LeftSettingsNav.ItemHeight = 36;
            this.LeftSettingsNav.Location = new System.Drawing.Point(3, 27);
            this.LeftSettingsNav.Name = "LeftSettingsNav";
            this.LeftSettingsNav.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LeftSettingsNav.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("LeftSettingsNav.NodeDownPic")));
            this.LeftSettingsNav.NodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LeftSettingsNav.NodeHeight = 36;
            this.LeftSettingsNav.NodeIsShowSplitLine = true;
            treeNode19.Name = "themeSetPage";
            treeNode19.Text = "Theme";
            treeNode20.Name = "generalSetPage";
            treeNode20.Text = "General";
            treeNode21.Name = "accountSetPage";
            treeNode21.Text = "Account";
            this.LeftSettingsNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21});
            this.LeftSettingsNav.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LeftSettingsNav.NodeSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LeftSettingsNav.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LeftSettingsNav.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("LeftSettingsNav.NodeUpPic")));
            this.LeftSettingsNav.ParentNodeCanSelect = true;
            this.LeftSettingsNav.ShowLines = false;
            this.LeftSettingsNav.ShowPlusMinus = false;
            this.LeftSettingsNav.ShowRootLines = false;
            this.LeftSettingsNav.Size = new System.Drawing.Size(82, 408);
            this.LeftSettingsNav.TabIndex = 17;
            this.LeftSettingsNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LeftMenuNav_AfterSelect);
            // 
            // ResetAccountCheckbox
            // 
            this.ResetAccountCheckbox.AutoSize = true;
            this.ResetAccountCheckbox.Depth = 0;
            this.ResetAccountCheckbox.Location = new System.Drawing.Point(93, 33);
            this.ResetAccountCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.ResetAccountCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ResetAccountCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetAccountCheckbox.Name = "ResetAccountCheckbox";
            this.ResetAccountCheckbox.ReadOnly = false;
            this.ResetAccountCheckbox.Ripple = true;
            this.ResetAccountCheckbox.Size = new System.Drawing.Size(198, 37);
            this.ResetAccountCheckbox.TabIndex = 16;
            this.ResetAccountCheckbox.Text = "Reset account on close";
            this.ToolTips.SetToolTip(this.ResetAccountCheckbox, "Wipes all account data when you close SafeNotes.");
            this.ResetAccountCheckbox.UseVisualStyleBackColor = true;
            this.ResetAccountCheckbox.Visible = false;
            // 
            // ResetLoginStatusButton
            // 
            this.ResetLoginStatusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetLoginStatusButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetLoginStatusButton.Depth = 0;
            this.ResetLoginStatusButton.HighEmphasis = true;
            this.ResetLoginStatusButton.Icon = null;
            this.ResetLoginStatusButton.Location = new System.Drawing.Point(93, 76);
            this.ResetLoginStatusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetLoginStatusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetLoginStatusButton.Name = "ResetLoginStatusButton";
            this.ResetLoginStatusButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ResetLoginStatusButton.Size = new System.Drawing.Size(170, 36);
            this.ResetLoginStatusButton.TabIndex = 15;
            this.ResetLoginStatusButton.Text = "Reset login status";
            this.ToolTips.SetToolTip(this.ResetLoginStatusButton, "Logs you out of SafeNotes.");
            this.ResetLoginStatusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResetLoginStatusButton.UseAccentColor = false;
            this.ResetLoginStatusButton.UseVisualStyleBackColor = true;
            this.ResetLoginStatusButton.Visible = false;
            this.ResetLoginStatusButton.Click += new System.EventHandler(this.ResetLoginStatusButton_Click);
            // 
            // ApplyDateCheckbox
            // 
            this.ApplyDateCheckbox.AutoSize = true;
            this.ApplyDateCheckbox.Depth = 0;
            this.ApplyDateCheckbox.Location = new System.Drawing.Point(93, 33);
            this.ApplyDateCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.ApplyDateCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ApplyDateCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ApplyDateCheckbox.Name = "ApplyDateCheckbox";
            this.ApplyDateCheckbox.ReadOnly = false;
            this.ApplyDateCheckbox.Ripple = true;
            this.ApplyDateCheckbox.Size = new System.Drawing.Size(167, 37);
            this.ApplyDateCheckbox.TabIndex = 14;
            this.ApplyDateCheckbox.Text = "Apply date to entry";
            this.ToolTips.SetToolTip(this.ApplyDateCheckbox, "Applies the date the entry was made in the Entries tab.");
            this.ApplyDateCheckbox.UseVisualStyleBackColor = true;
            this.ApplyDateCheckbox.Visible = false;
            this.ApplyDateCheckbox.CheckedChanged += new System.EventHandler(this.ApplyDateCheckbox_CheckedChanged);
            // 
            // LightModeCheckbox
            // 
            this.LightModeCheckbox.AutoSize = true;
            this.LightModeCheckbox.Depth = 0;
            this.LightModeCheckbox.Location = new System.Drawing.Point(93, 33);
            this.LightModeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.LightModeCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.LightModeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LightModeCheckbox.Name = "LightModeCheckbox";
            this.LightModeCheckbox.ReadOnly = false;
            this.LightModeCheckbox.Ripple = true;
            this.LightModeCheckbox.Size = new System.Drawing.Size(115, 37);
            this.LightModeCheckbox.TabIndex = 12;
            this.LightModeCheckbox.Text = "Light Mode";
            this.ToolTips.SetToolTip(this.LightModeCheckbox, "Burns your eyes...");
            this.LightModeCheckbox.UseVisualStyleBackColor = true;
            this.LightModeCheckbox.Visible = false;
            this.LightModeCheckbox.CheckedChanged += new System.EventHandler(this.LightModeCheckbox_CheckedChanged);
            // 
            // SettingsTabSelector
            // 
            this.SettingsTabSelector.BaseTabControl = this.TabControl;
            this.SettingsTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.SettingsTabSelector.Depth = 0;
            this.SettingsTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SettingsTabSelector.Location = new System.Drawing.Point(3, 3);
            this.SettingsTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.SettingsTabSelector.Name = "SettingsTabSelector";
            this.SettingsTabSelector.Size = new System.Drawing.Size(830, 24);
            this.SettingsTabSelector.TabIndex = 2;
            this.SettingsTabSelector.Text = "MaterialTabSelector2";
            // 
            // TrayIcon
            // 
            this.TrayIcon.Text = "SafeNotes";
            this.TrayIcon.Visible = true;
            // 
            // CheckTimer
            // 
            this.CheckTimer.Enabled = true;
            this.CheckTimer.Interval = 50;
            this.CheckTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // LabelVisibilityTimer
            // 
            this.LabelVisibilityTimer.Interval = 3000;
            this.LabelVisibilityTimer.Tick += new System.EventHandler(this.LabelVisibilityTimer_Tick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(300, 54);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(251, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Je ne sais pas...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.JournalEntryPage.ResumeLayout(false);
            this.JournalEntryPage.PerformLayout();
            this.NotepadPage.ResumeLayout(false);
            this.NotepadPage.PerformLayout();
            this.JournalEntriesPage.ResumeLayout(false);
            this.JournalEntriesPage.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.SettingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage JournalEntryPage;
        private MaterialSkin.Controls.MaterialTabSelector JournalTabSelector;
        private System.Windows.Forms.TabPage JournalEntriesPage;
        private MaterialSkin.Controls.MaterialTabSelector EntriesTabSelector;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 JournalEntryBox;
        private MaterialSkin.Controls.MaterialButton SaveEntryButton;
        private MaterialSkin.Controls.MaterialButton ChangeNameButton;
        private System.Windows.Forms.ColumnHeader DateCol;
        private System.Windows.Forms.ColumnHeader ContentsCol;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.TabPage SettingsPage;
        private MaterialSkin.Controls.MaterialTabSelector SettingsTabSelector;
        public MaterialSkin.Controls.MaterialTextBox YourNameBox;
        private MaterialSkin.Controls.MaterialCheckbox LightModeCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox ApplyDateCheckbox;
        private MaterialSkin.Controls.MaterialButton ResetLoginStatusButton;
        public MaterialSkin.Controls.MaterialListView EntriesListBox;
        private System.Windows.Forms.TabPage LoginPage;
        private MaterialSkin.Controls.MaterialTextBox2 UserConfirmPassword;
        private MaterialSkin.Controls.MaterialTextBox2 UserPassword;
        private MaterialSkin.Controls.MaterialTabSelector LoginTabSelector;
        private MaterialSkin.Controls.MaterialButton UserLoginButton;
        private System.Windows.Forms.ToolTip ToolTips;
        private MaterialSkin.Controls.MaterialCheckbox ResetAccountCheckbox;
        private Mook.UI.Windows.Forms.LeftMenuNav LeftSettingsNav;
        private System.Windows.Forms.Timer CheckTimer;
        private MaterialSkin.Controls.MaterialButton DeleteEntriesButton;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordGenBox;
        private MaterialSkin.Controls.MaterialButton UsePassButton;
        private MaterialSkin.Controls.MaterialButton RegenPassButton;
        private MaterialSkin.Controls.MaterialSlider PasswordLengthSlider;
        private MaterialSkin.Controls.MaterialLabel PasswordCopiedLabel;
        private System.Windows.Forms.Timer LabelVisibilityTimer;
        private System.Windows.Forms.TabPage NotepadPage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 NotepadTextBox;
        private MaterialSkin.Controls.MaterialTabSelector NotepadTabSelector;
        private MaterialSkin.Controls.MaterialLabel SavedEntriesCount;
        private MaterialSkin.Controls.MaterialButton SaveNotepadButton;
        private MaterialSkin.Controls.MaterialButton OpenFileButton;
        private MaterialSkin.Controls.MaterialButton ClearNotepadButton;
        private MaterialSkin.Controls.MaterialLabel CharsInNotepad;
        private MaterialSkin.Controls.MaterialLabel ColumnInNotepad;
        private MaterialSkin.Controls.MaterialLabel NotepadTitle;
        private MaterialSkin.Controls.MaterialButton EditEntryButton;
        private MaterialSkin.Controls.MaterialLabel DecryptionStatusLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}


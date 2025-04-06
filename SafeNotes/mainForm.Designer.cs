namespace SafeNotes
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Theme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Account");
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.loginPage = new System.Windows.Forms.TabPage();
            this.passwordCopiedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLengthSlider = new MaterialSkin.Controls.MaterialSlider();
            this.usePassButton = new MaterialSkin.Controls.MaterialButton();
            this.regenPassButton = new MaterialSkin.Controls.MaterialButton();
            this.passwordGenBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.userLoginButton = new MaterialSkin.Controls.MaterialButton();
            this.tabSelect = new MaterialSkin.Controls.MaterialTabSelector();
            this.userConfirmPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.userPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.journalEntryPage = new System.Windows.Forms.TabPage();
            this.savedEntriesCount = new MaterialSkin.Controls.MaterialLabel();
            this.changeNameButton = new MaterialSkin.Controls.MaterialButton();
            this.yourNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveEntryButton = new MaterialSkin.Controls.MaterialButton();
            this.journalEntryBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tabSelect2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.notepadPage = new System.Windows.Forms.TabPage();
            this.notepadTitle = new MaterialSkin.Controls.MaterialLabel();
            this.columnInNotepad = new MaterialSkin.Controls.MaterialLabel();
            this.charsInNotepad = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.openFileButton = new MaterialSkin.Controls.MaterialButton();
            this.saveNotepadButton = new MaterialSkin.Controls.MaterialButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.notepadTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.journalEntriesPage = new System.Windows.Forms.TabPage();
            this.editEntryButton = new MaterialSkin.Controls.MaterialButton();
            this.deleteEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.entriesListBox = new MaterialSkin.Controls.MaterialListView();
            this.dateCol = new System.Windows.Forms.ColumnHeader();
            this.contentsCol = new System.Windows.Forms.ColumnHeader();
            this.tabSelect3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.leftMenuNav = new Mook.UI.Windows.Forms.LeftMenuNav();
            this.resetAccountCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.resetLoginStatusButton = new MaterialSkin.Controls.MaterialButton();
            this.applyDateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.lightModeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabSelect4 = new MaterialSkin.Controls.MaterialTabSelector();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.labelVisibilityTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl.SuspendLayout();
            this.loginPage.SuspendLayout();
            this.journalEntryPage.SuspendLayout();
            this.notepadPage.SuspendLayout();
            this.journalEntriesPage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.loginPage);
            this.tabControl.Controls.Add(this.journalEntryPage);
            this.tabControl.Controls.Add(this.notepadPage);
            this.tabControl.Controls.Add(this.journalEntriesPage);
            this.tabControl.Controls.Add(this.settingsPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(844, 464);
            this.tabControl.TabIndex = 0;
            // 
            // loginPage
            // 
            this.loginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.loginPage.Controls.Add(this.passwordCopiedLabel);
            this.loginPage.Controls.Add(this.passwordLengthSlider);
            this.loginPage.Controls.Add(this.usePassButton);
            this.loginPage.Controls.Add(this.regenPassButton);
            this.loginPage.Controls.Add(this.passwordGenBox);
            this.loginPage.Controls.Add(this.userLoginButton);
            this.loginPage.Controls.Add(this.tabSelect);
            this.loginPage.Controls.Add(this.userConfirmPassword);
            this.loginPage.Controls.Add(this.userPassword);
            this.loginPage.Location = new System.Drawing.Point(4, 22);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(836, 438);
            this.loginPage.TabIndex = 4;
            this.loginPage.Text = "Login";
            // 
            // passwordCopiedLabel
            // 
            this.passwordCopiedLabel.AutoSize = true;
            this.passwordCopiedLabel.Depth = 0;
            this.passwordCopiedLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordCopiedLabel.Location = new System.Drawing.Point(247, 224);
            this.passwordCopiedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordCopiedLabel.Name = "passwordCopiedLabel";
            this.passwordCopiedLabel.Size = new System.Drawing.Size(1, 0);
            this.passwordCopiedLabel.TabIndex = 8;
            // 
            // passwordLengthSlider
            // 
            this.passwordLengthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLengthSlider.Depth = 0;
            this.passwordLengthSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLengthSlider.Location = new System.Drawing.Point(250, 354);
            this.passwordLengthSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLengthSlider.Name = "passwordLengthSlider";
            this.passwordLengthSlider.RangeMax = 32;
            this.passwordLengthSlider.Size = new System.Drawing.Size(351, 40);
            this.passwordLengthSlider.TabIndex = 7;
            this.passwordLengthSlider.Text = "Password Length";
            this.toolTips.SetToolTip(this.passwordLengthSlider, "Changes the amount of characters generated for password.");
            this.passwordLengthSlider.Value = 16;
            this.passwordLengthSlider.Visible = false;
            // 
            // usePassButton
            // 
            this.usePassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usePassButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usePassButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.usePassButton.Depth = 0;
            this.usePassButton.HighEmphasis = true;
            this.usePassButton.Icon = null;
            this.usePassButton.Location = new System.Drawing.Point(250, 309);
            this.usePassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.usePassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.usePassButton.Name = "usePassButton";
            this.usePassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.usePassButton.Size = new System.Drawing.Size(131, 36);
            this.usePassButton.TabIndex = 6;
            this.usePassButton.Text = "Use Password";
            this.toolTips.SetToolTip(this.usePassButton, "Copies the password for use");
            this.usePassButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.usePassButton.UseAccentColor = false;
            this.usePassButton.UseVisualStyleBackColor = true;
            this.usePassButton.Visible = false;
            this.usePassButton.Click += new System.EventHandler(this.usePassButton_Click);
            // 
            // regenPassButton
            // 
            this.regenPassButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regenPassButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.regenPassButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.regenPassButton.Depth = 0;
            this.regenPassButton.HighEmphasis = true;
            this.regenPassButton.Icon = null;
            this.regenPassButton.Location = new System.Drawing.Point(506, 309);
            this.regenPassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.regenPassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.regenPassButton.Name = "regenPassButton";
            this.regenPassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.regenPassButton.Size = new System.Drawing.Size(95, 36);
            this.regenPassButton.TabIndex = 5;
            this.regenPassButton.Text = "Generate";
            this.toolTips.SetToolTip(this.regenPassButton, "Regenerates a new password");
            this.regenPassButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.regenPassButton.UseAccentColor = false;
            this.regenPassButton.UseVisualStyleBackColor = true;
            this.regenPassButton.Visible = false;
            this.regenPassButton.Click += new System.EventHandler(this.regenPassButton_Click);
            // 
            // passwordGenBox
            // 
            this.passwordGenBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordGenBox.AnimateReadOnly = false;
            this.passwordGenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordGenBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordGenBox.Depth = 0;
            this.passwordGenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordGenBox.HideSelection = true;
            this.passwordGenBox.LeadingIcon = null;
            this.passwordGenBox.Location = new System.Drawing.Point(250, 252);
            this.passwordGenBox.MaxLength = 32767;
            this.passwordGenBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordGenBox.Name = "passwordGenBox";
            this.passwordGenBox.PasswordChar = '\0';
            this.passwordGenBox.PrefixSuffixText = null;
            this.passwordGenBox.ReadOnly = true;
            this.passwordGenBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordGenBox.SelectedText = "";
            this.passwordGenBox.SelectionLength = 0;
            this.passwordGenBox.SelectionStart = 0;
            this.passwordGenBox.ShortcutsEnabled = true;
            this.passwordGenBox.Size = new System.Drawing.Size(351, 48);
            this.passwordGenBox.TabIndex = 4;
            this.passwordGenBox.TabStop = false;
            this.passwordGenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordGenBox.TrailingIcon = null;
            this.passwordGenBox.UseSystemPasswordChar = false;
            this.passwordGenBox.Visible = false;
            this.passwordGenBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.passwordGenBox_MouseDoubleClick);
            // 
            // userLoginButton
            // 
            this.userLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userLoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userLoginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.userLoginButton.Depth = 0;
            this.userLoginButton.HighEmphasis = true;
            this.userLoginButton.Icon = null;
            this.userLoginButton.Location = new System.Drawing.Point(462, 207);
            this.userLoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.userLoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.userLoginButton.Size = new System.Drawing.Size(89, 36);
            this.userLoginButton.TabIndex = 3;
            this.userLoginButton.Text = "Register";
            this.userLoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.userLoginButton.UseAccentColor = false;
            this.userLoginButton.UseVisualStyleBackColor = true;
            this.userLoginButton.Click += new System.EventHandler(this.userLoginButton_Click);
            // 
            // tabSelect
            // 
            this.tabSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelect.BaseTabControl = this.tabControl;
            this.tabSelect.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelect.Depth = 0;
            this.tabSelect.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelect.Location = new System.Drawing.Point(3, 3);
            this.tabSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Size = new System.Drawing.Size(830, 25);
            this.tabSelect.TabIndex = 2;
            this.tabSelect.Text = "tabSelect1";
            // 
            // userConfirmPassword
            // 
            this.userConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userConfirmPassword.AnimateReadOnly = false;
            this.userConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userConfirmPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userConfirmPassword.Depth = 0;
            this.userConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userConfirmPassword.HelperText = "Password field, used to confirm your password.";
            this.userConfirmPassword.HideSelection = true;
            this.userConfirmPassword.Hint = "Confirm password...";
            this.userConfirmPassword.LeadingIcon = null;
            this.userConfirmPassword.Location = new System.Drawing.Point(300, 150);
            this.userConfirmPassword.MaxLength = 32767;
            this.userConfirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.userConfirmPassword.Name = "userConfirmPassword";
            this.userConfirmPassword.PasswordChar = '*';
            this.userConfirmPassword.PrefixSuffixText = null;
            this.userConfirmPassword.ReadOnly = false;
            this.userConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userConfirmPassword.SelectedText = "";
            this.userConfirmPassword.SelectionLength = 0;
            this.userConfirmPassword.SelectionStart = 0;
            this.userConfirmPassword.ShortcutsEnabled = true;
            this.userConfirmPassword.Size = new System.Drawing.Size(251, 48);
            this.userConfirmPassword.TabIndex = 1;
            this.userConfirmPassword.TabStop = false;
            this.userConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userConfirmPassword.TrailingIcon = null;
            this.userConfirmPassword.UseSystemPasswordChar = false;
            this.userConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userConfirmPassword_KeyPress);
            this.userConfirmPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userConfirmPassword_MouseClick);
            this.userConfirmPassword.MouseHover += new System.EventHandler(this.userConfirmPassword_MouseHover);
            // 
            // userPassword
            // 
            this.userPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userPassword.AnimateReadOnly = false;
            this.userPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.userPassword.Depth = 0;
            this.userPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userPassword.HelperText = "Journal password, used for securing Journal Entries.";
            this.userPassword.HideSelection = true;
            this.userPassword.Hint = "Password...";
            this.userPassword.LeadingIcon = null;
            this.userPassword.Location = new System.Drawing.Point(300, 96);
            this.userPassword.MaxLength = 32767;
            this.userPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.PrefixSuffixText = null;
            this.userPassword.ReadOnly = false;
            this.userPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userPassword.SelectedText = "";
            this.userPassword.SelectionLength = 0;
            this.userPassword.SelectionStart = 0;
            this.userPassword.ShortcutsEnabled = true;
            this.userPassword.Size = new System.Drawing.Size(251, 48);
            this.userPassword.TabIndex = 0;
            this.userPassword.TabStop = false;
            this.userPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.userPassword.TrailingIcon = null;
            this.userPassword.UseSystemPasswordChar = false;
            this.userPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userPassword_KeyPress);
            this.userPassword.MouseHover += new System.EventHandler(this.userPassword_MouseHover);
            // 
            // journalEntryPage
            // 
            this.journalEntryPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.journalEntryPage.Controls.Add(this.savedEntriesCount);
            this.journalEntryPage.Controls.Add(this.changeNameButton);
            this.journalEntryPage.Controls.Add(this.yourNameBox);
            this.journalEntryPage.Controls.Add(this.saveEntryButton);
            this.journalEntryPage.Controls.Add(this.journalEntryBox);
            this.journalEntryPage.Controls.Add(this.tabSelect2);
            this.journalEntryPage.Location = new System.Drawing.Point(4, 22);
            this.journalEntryPage.Name = "journalEntryPage";
            this.journalEntryPage.Padding = new System.Windows.Forms.Padding(3);
            this.journalEntryPage.Size = new System.Drawing.Size(836, 438);
            this.journalEntryPage.TabIndex = 0;
            this.journalEntryPage.Text = "Journal";
            this.journalEntryPage.Click += new System.EventHandler(this.journalEntryPage_Click);
            // 
            // savedEntriesCount
            // 
            this.savedEntriesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savedEntriesCount.Depth = 0;
            this.savedEntriesCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.savedEntriesCount.Location = new System.Drawing.Point(549, 397);
            this.savedEntriesCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.savedEntriesCount.Name = "savedEntriesCount";
            this.savedEntriesCount.Size = new System.Drawing.Size(170, 19);
            this.savedEntriesCount.TabIndex = 8;
            this.savedEntriesCount.Text = "Saved entries: 0";
            this.savedEntriesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savedEntriesCount.Click += new System.EventHandler(this.savedEntriesCount_Click);
            // 
            // changeNameButton
            // 
            this.changeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeNameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.changeNameButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.changeNameButton.Depth = 0;
            this.changeNameButton.HighEmphasis = true;
            this.changeNameButton.Icon = null;
            this.changeNameButton.Location = new System.Drawing.Point(160, 396);
            this.changeNameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.changeNameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.changeNameButton.Size = new System.Drawing.Size(103, 36);
            this.changeNameButton.TabIndex = 6;
            this.changeNameButton.Text = "Save name";
            this.changeNameButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.changeNameButton.UseAccentColor = false;
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // yourNameBox
            // 
            this.yourNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yourNameBox.AnimateReadOnly = false;
            this.yourNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yourNameBox.Depth = 0;
            this.yourNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yourNameBox.Hint = "Your name...";
            this.yourNameBox.LeadingIcon = null;
            this.yourNameBox.Location = new System.Drawing.Point(3, 396);
            this.yourNameBox.MaxLength = 50;
            this.yourNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.yourNameBox.Multiline = false;
            this.yourNameBox.Name = "yourNameBox";
            this.yourNameBox.ReadOnly = true;
            this.yourNameBox.Size = new System.Drawing.Size(150, 36);
            this.yourNameBox.TabIndex = 5;
            this.yourNameBox.Text = "";
            this.yourNameBox.TrailingIcon = null;
            this.yourNameBox.UseTallSize = false;
            // 
            // saveEntryButton
            // 
            this.saveEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveEntryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveEntryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveEntryButton.Depth = 0;
            this.saveEntryButton.HighEmphasis = true;
            this.saveEntryButton.Icon = null;
            this.saveEntryButton.Location = new System.Drawing.Point(726, 396);
            this.saveEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveEntryButton.Name = "saveEntryButton";
            this.saveEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveEntryButton.Size = new System.Drawing.Size(107, 36);
            this.saveEntryButton.TabIndex = 2;
            this.saveEntryButton.Text = "Save Entry";
            this.toolTips.SetToolTip(this.saveEntryButton, "Saves your entry into your Journal");
            this.saveEntryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveEntryButton.UseAccentColor = false;
            this.saveEntryButton.UseVisualStyleBackColor = true;
            this.saveEntryButton.Click += new System.EventHandler(this.saveEntryButton_Click);
            // 
            // journalEntryBox
            // 
            this.journalEntryBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.journalEntryBox.AnimateReadOnly = false;
            this.journalEntryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.journalEntryBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.journalEntryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.journalEntryBox.Depth = 0;
            this.journalEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalEntryBox.HideSelection = true;
            this.journalEntryBox.Hint = "Your journal...";
            this.journalEntryBox.Location = new System.Drawing.Point(3, 31);
            this.journalEntryBox.Margin = new System.Windows.Forms.Padding(1);
            this.journalEntryBox.MaxLength = 32767;
            this.journalEntryBox.MouseState = MaterialSkin.MouseState.OUT;
            this.journalEntryBox.Name = "journalEntryBox";
            this.journalEntryBox.PasswordChar = '\0';
            this.journalEntryBox.ReadOnly = false;
            this.journalEntryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.journalEntryBox.SelectedText = "";
            this.journalEntryBox.SelectionLength = 0;
            this.journalEntryBox.SelectionStart = 0;
            this.journalEntryBox.ShortcutsEnabled = true;
            this.journalEntryBox.Size = new System.Drawing.Size(830, 358);
            this.journalEntryBox.TabIndex = 1;
            this.journalEntryBox.TabStop = false;
            this.journalEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.journalEntryBox.UseSystemPasswordChar = false;
            this.journalEntryBox.TextChanged += new System.EventHandler(this.journalEntryBox_TextChanged);
            // 
            // tabSelect2
            // 
            this.tabSelect2.BaseTabControl = this.tabControl;
            this.tabSelect2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelect2.Depth = 0;
            this.tabSelect2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelect2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelect2.Location = new System.Drawing.Point(3, 3);
            this.tabSelect2.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelect2.Name = "tabSelect2";
            this.tabSelect2.Size = new System.Drawing.Size(830, 24);
            this.tabSelect2.TabIndex = 0;
            this.tabSelect2.Text = "materialTabSelector1";
            // 
            // notepadPage
            // 
            this.notepadPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.notepadPage.Controls.Add(this.notepadTitle);
            this.notepadPage.Controls.Add(this.columnInNotepad);
            this.notepadPage.Controls.Add(this.charsInNotepad);
            this.notepadPage.Controls.Add(this.materialButton1);
            this.notepadPage.Controls.Add(this.openFileButton);
            this.notepadPage.Controls.Add(this.saveNotepadButton);
            this.notepadPage.Controls.Add(this.materialTabSelector1);
            this.notepadPage.Controls.Add(this.notepadTextBox);
            this.notepadPage.Location = new System.Drawing.Point(4, 22);
            this.notepadPage.Name = "notepadPage";
            this.notepadPage.Size = new System.Drawing.Size(836, 438);
            this.notepadPage.TabIndex = 5;
            this.notepadPage.Text = "Notepad";
            this.notepadPage.Click += new System.EventHandler(this.notepad_Click);
            // 
            // notepadTitle
            // 
            this.notepadTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.notepadTitle.Depth = 0;
            this.notepadTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notepadTitle.Location = new System.Drawing.Point(147, 396);
            this.notepadTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.notepadTitle.Name = "notepadTitle";
            this.notepadTitle.Size = new System.Drawing.Size(314, 36);
            this.notepadTitle.TabIndex = 9;
            this.notepadTitle.Text = "Notepad Title";
            this.notepadTitle.Visible = false;
            this.notepadTitle.Click += new System.EventHandler(this.notepadTitle_Click);
            // 
            // columnInNotepad
            // 
            this.columnInNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.columnInNotepad.Depth = 0;
            this.columnInNotepad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.columnInNotepad.Location = new System.Drawing.Point(480, 415);
            this.columnInNotepad.MouseState = MaterialSkin.MouseState.HOVER;
            this.columnInNotepad.Name = "columnInNotepad";
            this.columnInNotepad.Size = new System.Drawing.Size(117, 19);
            this.columnInNotepad.TabIndex = 8;
            this.columnInNotepad.Text = "Columns: 10923";
            this.columnInNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.columnInNotepad.Click += new System.EventHandler(this.columnInNotepad_Click);
            // 
            // charsInNotepad
            // 
            this.charsInNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.charsInNotepad.Depth = 0;
            this.charsInNotepad.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.charsInNotepad.Location = new System.Drawing.Point(467, 396);
            this.charsInNotepad.MouseState = MaterialSkin.MouseState.HOVER;
            this.charsInNotepad.Name = "charsInNotepad";
            this.charsInNotepad.Size = new System.Drawing.Size(130, 19);
            this.charsInNotepad.TabIndex = 7;
            this.charsInNotepad.Text = "Characters: 32767";
            this.charsInNotepad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.charsInNotepad.Click += new System.EventHandler(this.charsInNotepad_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(3, 396);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(137, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Clear Notepad";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.openFileButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.openFileButton.Depth = 0;
            this.openFileButton.HighEmphasis = true;
            this.openFileButton.Icon = null;
            this.openFileButton.Location = new System.Drawing.Point(604, 396);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openFileButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.openFileButton.Size = new System.Drawing.Size(92, 36);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "Open File";
            this.openFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.openFileButton.UseAccentColor = false;
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveNotepadButton
            // 
            this.saveNotepadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveNotepadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveNotepadButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveNotepadButton.Depth = 0;
            this.saveNotepadButton.HighEmphasis = true;
            this.saveNotepadButton.Icon = null;
            this.saveNotepadButton.Location = new System.Drawing.Point(705, 396);
            this.saveNotepadButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveNotepadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveNotepadButton.Name = "saveNotepadButton";
            this.saveNotepadButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveNotepadButton.Size = new System.Drawing.Size(128, 36);
            this.saveNotepadButton.TabIndex = 4;
            this.saveNotepadButton.Text = "Save Notepad";
            this.saveNotepadButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveNotepadButton.UseAccentColor = false;
            this.saveNotepadButton.UseVisualStyleBackColor = true;
            this.saveNotepadButton.Click += new System.EventHandler(this.saveNotepadButton_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.tabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(830, 24);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "tabSelect1";
            // 
            // notepadTextBox
            // 
            this.notepadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notepadTextBox.AnimateReadOnly = false;
            this.notepadTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.notepadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.notepadTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.notepadTextBox.Depth = 0;
            this.notepadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notepadTextBox.HideSelection = true;
            this.notepadTextBox.Hint = "Aa...";
            this.notepadTextBox.Location = new System.Drawing.Point(3, 31);
            this.notepadTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.notepadTextBox.MaxLength = 32767;
            this.notepadTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.notepadTextBox.Name = "notepadTextBox";
            this.notepadTextBox.PasswordChar = '\0';
            this.notepadTextBox.ReadOnly = false;
            this.notepadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notepadTextBox.SelectedText = "";
            this.notepadTextBox.SelectionLength = 0;
            this.notepadTextBox.SelectionStart = 0;
            this.notepadTextBox.ShortcutsEnabled = true;
            this.notepadTextBox.Size = new System.Drawing.Size(830, 364);
            this.notepadTextBox.TabIndex = 2;
            this.notepadTextBox.TabStop = false;
            this.notepadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.notepadTextBox.UseSystemPasswordChar = false;
            this.notepadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.notepadTextBox_KeyPress);
            this.notepadTextBox.TextChanged += new System.EventHandler(this.notepadTextBox_TextChanged);
            // 
            // journalEntriesPage
            // 
            this.journalEntriesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.journalEntriesPage.Controls.Add(this.editEntryButton);
            this.journalEntriesPage.Controls.Add(this.deleteEntriesButton);
            this.journalEntriesPage.Controls.Add(this.entriesListBox);
            this.journalEntriesPage.Controls.Add(this.tabSelect3);
            this.journalEntriesPage.Location = new System.Drawing.Point(4, 22);
            this.journalEntriesPage.Name = "journalEntriesPage";
            this.journalEntriesPage.Size = new System.Drawing.Size(836, 438);
            this.journalEntriesPage.TabIndex = 2;
            this.journalEntriesPage.Text = "Journal Entries";
            // 
            // editEntryButton
            // 
            this.editEntryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editEntryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editEntryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editEntryButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editEntryButton.Depth = 0;
            this.editEntryButton.HighEmphasis = true;
            this.editEntryButton.Icon = null;
            this.editEntryButton.Location = new System.Drawing.Point(4, 396);
            this.editEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.editEntryButton.Name = "editEntryButton";
            this.editEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editEntryButton.Size = new System.Drawing.Size(102, 36);
            this.editEntryButton.TabIndex = 4;
            this.editEntryButton.Text = "Edit entry";
            this.toolTips.SetToolTip(this.editEntryButton, "Edits the selected entry.");
            this.editEntryButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.editEntryButton.UseAccentColor = false;
            this.editEntryButton.UseVisualStyleBackColor = true;
            this.editEntryButton.Visible = false;
            this.editEntryButton.Click += new System.EventHandler(this.editEntryButton_Click);
            // 
            // deleteEntriesButton
            // 
            this.deleteEntriesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEntriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteEntriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteEntriesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteEntriesButton.Depth = 0;
            this.deleteEntriesButton.HighEmphasis = true;
            this.deleteEntriesButton.Icon = null;
            this.deleteEntriesButton.Location = new System.Drawing.Point(696, 396);
            this.deleteEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteEntriesButton.Name = "deleteEntriesButton";
            this.deleteEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteEntriesButton.Size = new System.Drawing.Size(136, 36);
            this.deleteEntriesButton.TabIndex = 3;
            this.deleteEntriesButton.Text = "Delete entries";
            this.toolTips.SetToolTip(this.deleteEntriesButton, "Deletes all entered entries");
            this.deleteEntriesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteEntriesButton.UseAccentColor = false;
            this.deleteEntriesButton.UseVisualStyleBackColor = true;
            this.deleteEntriesButton.Visible = false;
            this.deleteEntriesButton.Click += new System.EventHandler(this.deleteEntriesButton_Click);
            // 
            // entriesListBox
            // 
            this.entriesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesListBox.AutoSizeTable = false;
            this.entriesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.entriesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entriesListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateCol,
            this.contentsCol});
            this.entriesListBox.Depth = 0;
            this.entriesListBox.FullRowSelect = true;
            this.entriesListBox.HideSelection = false;
            this.entriesListBox.Location = new System.Drawing.Point(3, 33);
            this.entriesListBox.MinimumSize = new System.Drawing.Size(200, 100);
            this.entriesListBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.entriesListBox.MouseState = MaterialSkin.MouseState.OUT;
            this.entriesListBox.Name = "entriesListBox";
            this.entriesListBox.OwnerDraw = true;
            this.entriesListBox.Size = new System.Drawing.Size(830, 354);
            this.entriesListBox.TabIndex = 2;
            this.entriesListBox.UseCompatibleStateImageBehavior = false;
            this.entriesListBox.View = System.Windows.Forms.View.Details;
            this.entriesListBox.Visible = false;
            this.entriesListBox.SelectedIndexChanged += new System.EventHandler(this.entriesListBox_SelectedIndexChanged);
            this.entriesListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.entriesListBox_MouseDoubleClick);
            // 
            // dateCol
            // 
            this.dateCol.Text = "Date";
            this.dateCol.Width = 175;
            // 
            // contentsCol
            // 
            this.contentsCol.Text = "Contents";
            this.contentsCol.Width = 500;
            // 
            // tabSelect3
            // 
            this.tabSelect3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelect3.BaseTabControl = this.tabControl;
            this.tabSelect3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelect3.Depth = 0;
            this.tabSelect3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelect3.Location = new System.Drawing.Point(3, 3);
            this.tabSelect3.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelect3.Name = "tabSelect3";
            this.tabSelect3.Size = new System.Drawing.Size(830, 24);
            this.tabSelect3.TabIndex = 1;
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.settingsPage.Controls.Add(this.leftMenuNav);
            this.settingsPage.Controls.Add(this.resetAccountCheckbox);
            this.settingsPage.Controls.Add(this.resetLoginStatusButton);
            this.settingsPage.Controls.Add(this.applyDateCheckbox);
            this.settingsPage.Controls.Add(this.lightModeCheckbox);
            this.settingsPage.Controls.Add(this.tabSelect4);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(836, 438);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Settings";
            this.settingsPage.Click += new System.EventHandler(this.settingsPage_Click);
            // 
            // leftMenuNav
            // 
            this.leftMenuNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.leftMenuNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.leftMenuNav.CustomModel = true;
            this.leftMenuNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMenuNav.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.leftMenuNav.FullRowSelect = true;
            this.leftMenuNav.HideSelection = false;
            this.leftMenuNav.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.leftMenuNav.ItemHeight = 36;
            this.leftMenuNav.Location = new System.Drawing.Point(3, 27);
            this.leftMenuNav.Name = "leftMenuNav";
            this.leftMenuNav.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.leftMenuNav.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("leftMenuNav.NodeDownPic")));
            this.leftMenuNav.NodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.leftMenuNav.NodeHeight = 36;
            this.leftMenuNav.NodeIsShowSplitLine = true;
            treeNode1.Name = "themeSetPage";
            treeNode1.Text = "Theme";
            treeNode2.Name = "generalSetPage";
            treeNode2.Text = "General";
            treeNode3.Name = "accountSetPage";
            treeNode3.Text = "Account";
            this.leftMenuNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.leftMenuNav.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.leftMenuNav.NodeSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.leftMenuNav.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.leftMenuNav.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("leftMenuNav.NodeUpPic")));
            this.leftMenuNav.ParentNodeCanSelect = true;
            this.leftMenuNav.ShowLines = false;
            this.leftMenuNav.ShowPlusMinus = false;
            this.leftMenuNav.ShowRootLines = false;
            this.leftMenuNav.Size = new System.Drawing.Size(82, 408);
            this.leftMenuNav.TabIndex = 17;
            this.leftMenuNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.leftMenuNav_AfterSelect);
            // 
            // resetAccountCheckbox
            // 
            this.resetAccountCheckbox.AutoSize = true;
            this.resetAccountCheckbox.Depth = 0;
            this.resetAccountCheckbox.Location = new System.Drawing.Point(93, 33);
            this.resetAccountCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.resetAccountCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.resetAccountCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetAccountCheckbox.Name = "resetAccountCheckbox";
            this.resetAccountCheckbox.ReadOnly = false;
            this.resetAccountCheckbox.Ripple = true;
            this.resetAccountCheckbox.Size = new System.Drawing.Size(198, 37);
            this.resetAccountCheckbox.TabIndex = 16;
            this.resetAccountCheckbox.Text = "Reset account on close";
            this.toolTips.SetToolTip(this.resetAccountCheckbox, "Wipes all account data when you close SafeNotes.");
            this.resetAccountCheckbox.UseVisualStyleBackColor = true;
            this.resetAccountCheckbox.Visible = false;
            // 
            // resetLoginStatusButton
            // 
            this.resetLoginStatusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetLoginStatusButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.resetLoginStatusButton.Depth = 0;
            this.resetLoginStatusButton.HighEmphasis = true;
            this.resetLoginStatusButton.Icon = null;
            this.resetLoginStatusButton.Location = new System.Drawing.Point(93, 76);
            this.resetLoginStatusButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetLoginStatusButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetLoginStatusButton.Name = "resetLoginStatusButton";
            this.resetLoginStatusButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.resetLoginStatusButton.Size = new System.Drawing.Size(170, 36);
            this.resetLoginStatusButton.TabIndex = 15;
            this.resetLoginStatusButton.Text = "Reset login status";
            this.toolTips.SetToolTip(this.resetLoginStatusButton, "Logs you out of SafeNotes.");
            this.resetLoginStatusButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetLoginStatusButton.UseAccentColor = false;
            this.resetLoginStatusButton.UseVisualStyleBackColor = true;
            this.resetLoginStatusButton.Visible = false;
            this.resetLoginStatusButton.Click += new System.EventHandler(this.resetLoginStatusButton_Click);
            // 
            // applyDateCheckbox
            // 
            this.applyDateCheckbox.AutoSize = true;
            this.applyDateCheckbox.Depth = 0;
            this.applyDateCheckbox.Location = new System.Drawing.Point(93, 33);
            this.applyDateCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.applyDateCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.applyDateCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyDateCheckbox.Name = "applyDateCheckbox";
            this.applyDateCheckbox.ReadOnly = false;
            this.applyDateCheckbox.Ripple = true;
            this.applyDateCheckbox.Size = new System.Drawing.Size(167, 37);
            this.applyDateCheckbox.TabIndex = 14;
            this.applyDateCheckbox.Text = "Apply date to entry";
            this.toolTips.SetToolTip(this.applyDateCheckbox, "Applies the date the entry was made in the Entries tab.");
            this.applyDateCheckbox.UseVisualStyleBackColor = true;
            this.applyDateCheckbox.Visible = false;
            this.applyDateCheckbox.CheckedChanged += new System.EventHandler(this.applyDateCheckbox_CheckedChanged);
            // 
            // lightModeCheckbox
            // 
            this.lightModeCheckbox.AutoSize = true;
            this.lightModeCheckbox.Depth = 0;
            this.lightModeCheckbox.Location = new System.Drawing.Point(93, 33);
            this.lightModeCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.lightModeCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lightModeCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.lightModeCheckbox.Name = "lightModeCheckbox";
            this.lightModeCheckbox.ReadOnly = false;
            this.lightModeCheckbox.Ripple = true;
            this.lightModeCheckbox.Size = new System.Drawing.Size(115, 37);
            this.lightModeCheckbox.TabIndex = 12;
            this.lightModeCheckbox.Text = "Light Mode";
            this.toolTips.SetToolTip(this.lightModeCheckbox, "Burns your eyes...");
            this.lightModeCheckbox.UseVisualStyleBackColor = true;
            this.lightModeCheckbox.Visible = false;
            this.lightModeCheckbox.CheckedChanged += new System.EventHandler(this.materialCheckbox_CheckedChanged);
            // 
            // tabSelect4
            // 
            this.tabSelect4.BaseTabControl = this.tabControl;
            this.tabSelect4.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.tabSelect4.Depth = 0;
            this.tabSelect4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabSelect4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelect4.Location = new System.Drawing.Point(3, 3);
            this.tabSelect4.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelect4.Name = "tabSelect4";
            this.tabSelect4.Size = new System.Drawing.Size(830, 24);
            this.tabSelect4.TabIndex = 2;
            this.tabSelect4.Text = "materialTabSelector2";
            // 
            // trayIcon
            // 
            this.trayIcon.Text = "SafeNotes";
            this.trayIcon.Visible = true;
            // 
            // checkTimer
            // 
            this.checkTimer.Enabled = true;
            this.checkTimer.Interval = 50;
            this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
            // 
            // labelVisibilityTimer
            // 
            this.labelVisibilityTimer.Interval = 3000;
            this.labelVisibilityTimer.Tick += new System.EventHandler(this.labelVisibilityTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(850, 531);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Je ne sais pas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            this.journalEntryPage.ResumeLayout(false);
            this.journalEntryPage.PerformLayout();
            this.notepadPage.ResumeLayout(false);
            this.notepadPage.PerformLayout();
            this.journalEntriesPage.ResumeLayout(false);
            this.journalEntriesPage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage journalEntryPage;
        private MaterialSkin.Controls.MaterialTabSelector tabSelect2;
        private System.Windows.Forms.TabPage journalEntriesPage;
        private MaterialSkin.Controls.MaterialTabSelector tabSelect3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 journalEntryBox;
        private MaterialSkin.Controls.MaterialButton saveEntryButton;
        private MaterialSkin.Controls.MaterialButton changeNameButton;
        private System.Windows.Forms.ColumnHeader dateCol;
        private System.Windows.Forms.ColumnHeader contentsCol;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.TabPage settingsPage;
        private MaterialSkin.Controls.MaterialTabSelector tabSelect4;
        public MaterialSkin.Controls.MaterialTextBox yourNameBox;
        private MaterialSkin.Controls.MaterialCheckbox lightModeCheckbox;
        private MaterialSkin.Controls.MaterialCheckbox applyDateCheckbox;
        private MaterialSkin.Controls.MaterialButton resetLoginStatusButton;
        public MaterialSkin.Controls.MaterialListView entriesListBox;
        private System.Windows.Forms.TabPage loginPage;
        private MaterialSkin.Controls.MaterialTextBox2 userConfirmPassword;
        private MaterialSkin.Controls.MaterialTextBox2 userPassword;
        private MaterialSkin.Controls.MaterialTabSelector tabSelect;
        private MaterialSkin.Controls.MaterialButton userLoginButton;
        private System.Windows.Forms.ToolTip toolTips;
        private MaterialSkin.Controls.MaterialCheckbox resetAccountCheckbox;
        private Mook.UI.Windows.Forms.LeftMenuNav leftMenuNav;
        private System.Windows.Forms.Timer checkTimer;
        private MaterialSkin.Controls.MaterialButton deleteEntriesButton;
        private MaterialSkin.Controls.MaterialTextBox2 passwordGenBox;
        private MaterialSkin.Controls.MaterialButton usePassButton;
        private MaterialSkin.Controls.MaterialButton regenPassButton;
        private MaterialSkin.Controls.MaterialSlider passwordLengthSlider;
        private MaterialSkin.Controls.MaterialLabel passwordCopiedLabel;
        private System.Windows.Forms.Timer labelVisibilityTimer;
        private System.Windows.Forms.TabPage notepadPage;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 notepadTextBox;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel savedEntriesCount;
        private MaterialSkin.Controls.MaterialButton saveNotepadButton;
        private MaterialSkin.Controls.MaterialButton openFileButton;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel charsInNotepad;
        private MaterialSkin.Controls.MaterialLabel columnInNotepad;
        private MaterialSkin.Controls.MaterialLabel notepadTitle;
        private MaterialSkin.Controls.MaterialButton editEntryButton;
    }
}


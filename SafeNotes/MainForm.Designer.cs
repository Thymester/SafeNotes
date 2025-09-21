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
            System.Windows.Forms.Timer AutoLockCountdownTimer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Account");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Entries");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("App");
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.PasswordLengthDisclaimer = new System.Windows.Forms.LinkLabel();
            this.PinDisclaimer = new System.Windows.Forms.LinkLabel();
            this.PasswordDisclaimer = new System.Windows.Forms.LinkLabel();
            this.PasswordStrength = new System.Windows.Forms.Label();
            this.UserPINCodeField = new MaterialSkin.Controls.MaterialTextBox2();
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
            this.TenMinLock = new MaterialSkin.Controls.MaterialCheckbox();
            this.FiveMinLock = new MaterialSkin.Controls.MaterialCheckbox();
            this.ThreeMinLock = new MaterialSkin.Controls.MaterialCheckbox();
            this.TwoMinLock = new MaterialSkin.Controls.MaterialCheckbox();
            this.OneMinLock = new MaterialSkin.Controls.MaterialCheckbox();
            this.AutoLockCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.MinToSysTray = new MaterialSkin.Controls.MaterialCheckbox();
            this.RequirePinToLogin = new MaterialSkin.Controls.MaterialCheckbox();
            this.SettingsInfoLabel = new System.Windows.Forms.Label();
            this.EncryptEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.DisableNotificationsCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ImportEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.ExportEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.LeftSettingsNav = new Mook.UI.Windows.Forms.LeftMenuNav();
            this.ResetAccountCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ResetLoginStatusButton = new MaterialSkin.Controls.MaterialButton();
            this.ApplyDateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.LightModeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.SettingsTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.ReleaseNotesPage = new System.Windows.Forms.TabPage();
            this.ReleaseNotesMultiText = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelVisibilityTimer = new System.Windows.Forms.Timer(this.components);
            this.SysTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AutoLockTimer = new System.Windows.Forms.Timer(this.components);
            this.CustLockTimers = new MaterialSkin.Controls.MaterialLabel();
            AutoLockCountdownTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.JournalEntryPage.SuspendLayout();
            this.NotepadPage.SuspendLayout();
            this.JournalEntriesPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.ReleaseNotesPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoLockCountdownTimer
            // 
            AutoLockCountdownTimer.Interval = 500;
            AutoLockCountdownTimer.Tick += new System.EventHandler(this.AutoLockCountdownTimer_Tick);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LoginPage);
            this.TabControl.Controls.Add(this.JournalEntryPage);
            this.TabControl.Controls.Add(this.NotepadPage);
            this.TabControl.Controls.Add(this.JournalEntriesPage);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Controls.Add(this.ReleaseNotesPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 63);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1021, 654);
            this.TabControl.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.LoginPage.Controls.Add(this.PasswordLengthDisclaimer);
            this.LoginPage.Controls.Add(this.PinDisclaimer);
            this.LoginPage.Controls.Add(this.PasswordDisclaimer);
            this.LoginPage.Controls.Add(this.PasswordStrength);
            this.LoginPage.Controls.Add(this.UserPINCodeField);
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
            this.LoginPage.Size = new System.Drawing.Size(1013, 628);
            this.LoginPage.TabIndex = 4;
            this.LoginPage.Text = "Login";
            // 
            // PasswordLengthDisclaimer
            // 
            this.PasswordLengthDisclaimer.AutoSize = true;
            this.PasswordLengthDisclaimer.Location = new System.Drawing.Point(298, 236);
            this.PasswordLengthDisclaimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLengthDisclaimer.Name = "PasswordLengthDisclaimer";
            this.PasswordLengthDisclaimer.Size = new System.Drawing.Size(140, 13);
            this.PasswordLengthDisclaimer.TabIndex = 17;
            this.PasswordLengthDisclaimer.TabStop = true;
            this.PasswordLengthDisclaimer.Text = "Password Length Disclaimer";
            this.PasswordLengthDisclaimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordLengthDisclaimer_LinkClicked);
            // 
            // PinDisclaimer
            // 
            this.PinDisclaimer.AutoSize = true;
            this.PinDisclaimer.Location = new System.Drawing.Point(298, 223);
            this.PinDisclaimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PinDisclaimer.Name = "PinDisclaimer";
            this.PinDisclaimer.Size = new System.Drawing.Size(76, 13);
            this.PinDisclaimer.TabIndex = 16;
            this.PinDisclaimer.TabStop = true;
            this.PinDisclaimer.Text = "PIN Disclaimer";
            this.PinDisclaimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PinDisclaimer_LinkClicked);
            // 
            // PasswordDisclaimer
            // 
            this.PasswordDisclaimer.AutoSize = true;
            this.PasswordDisclaimer.Location = new System.Drawing.Point(297, 206);
            this.PasswordDisclaimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordDisclaimer.Name = "PasswordDisclaimer";
            this.PasswordDisclaimer.Size = new System.Drawing.Size(104, 13);
            this.PasswordDisclaimer.TabIndex = 15;
            this.PasswordDisclaimer.TabStop = true;
            this.PasswordDisclaimer.Text = "Password Disclaimer";
            this.PasswordDisclaimer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PasswordDisclaimer_LinkClicked);
            // 
            // PasswordStrength
            // 
            this.PasswordStrength.AutoSize = true;
            this.PasswordStrength.Location = new System.Drawing.Point(297, 61);
            this.PasswordStrength.Name = "PasswordStrength";
            this.PasswordStrength.Size = new System.Drawing.Size(46, 13);
            this.PasswordStrength.TabIndex = 13;
            this.PasswordStrength.Text = "Placebo";
            // 
            // UserPINCodeField
            // 
            this.UserPINCodeField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserPINCodeField.AnimateReadOnly = false;
            this.UserPINCodeField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UserPINCodeField.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserPINCodeField.Depth = 0;
            this.UserPINCodeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserPINCodeField.HideSelection = true;
            this.UserPINCodeField.Hint = "Enter your PIN...";
            this.UserPINCodeField.LeadingIcon = null;
            this.UserPINCodeField.Location = new System.Drawing.Point(300, 150);
            this.UserPINCodeField.MaxLength = 32767;
            this.UserPINCodeField.MouseState = MaterialSkin.MouseState.OUT;
            this.UserPINCodeField.Name = "UserPINCodeField";
            this.UserPINCodeField.PasswordChar = '*';
            this.UserPINCodeField.PrefixSuffixText = null;
            this.UserPINCodeField.ReadOnly = false;
            this.UserPINCodeField.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserPINCodeField.SelectedText = "";
            this.UserPINCodeField.SelectionLength = 0;
            this.UserPINCodeField.SelectionStart = 0;
            this.UserPINCodeField.ShortcutsEnabled = true;
            this.UserPINCodeField.Size = new System.Drawing.Size(427, 48);
            this.UserPINCodeField.TabIndex = 12;
            this.UserPINCodeField.TabStop = false;
            this.UserPINCodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ToolTips.SetToolTip(this.UserPINCodeField, "Enter a PIN to log into SafeNotes.");
            this.UserPINCodeField.TrailingIcon = null;
            this.UserPINCodeField.UseSystemPasswordChar = false;
            this.UserPINCodeField.Visible = false;
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
            this.PasswordLengthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordLengthSlider.Depth = 0;
            this.PasswordLengthSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLengthSlider.Location = new System.Drawing.Point(249, 364);
            this.PasswordLengthSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.RangeMax = 32;
            this.PasswordLengthSlider.Size = new System.Drawing.Size(527, 40);
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
            this.UsePassButton.Location = new System.Drawing.Point(249, 318);
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
            this.RegenPassButton.Location = new System.Drawing.Point(681, 318);
            this.RegenPassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegenPassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegenPassButton.Name = "RegenPassButton";
            this.RegenPassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegenPassButton.Size = new System.Drawing.Size(95, 36);
            this.RegenPassButton.TabIndex = 5;
            this.RegenPassButton.Text = "Generate";
            this.ToolTips.SetToolTip(this.RegenPassButton, "Generate a cryptographically secure password");
            this.RegenPassButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegenPassButton.UseAccentColor = false;
            this.RegenPassButton.UseVisualStyleBackColor = true;
            this.RegenPassButton.Visible = false;
            this.RegenPassButton.Click += new System.EventHandler(this.RegenPassButton_Click);
            // 
            // PasswordGenBox
            // 
            this.PasswordGenBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordGenBox.AnimateReadOnly = false;
            this.PasswordGenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordGenBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordGenBox.Depth = 0;
            this.PasswordGenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PasswordGenBox.HideSelection = true;
            this.PasswordGenBox.LeadingIcon = null;
            this.PasswordGenBox.Location = new System.Drawing.Point(249, 262);
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
            this.PasswordGenBox.Size = new System.Drawing.Size(527, 48);
            this.PasswordGenBox.TabIndex = 4;
            this.PasswordGenBox.TabStop = false;
            this.PasswordGenBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ToolTips.SetToolTip(this.PasswordGenBox, "Cryptographically secure password");
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
            this.UserLoginButton.Location = new System.Drawing.Point(639, 206);
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
            this.LoginTabSelector.Size = new System.Drawing.Size(1007, 24);
            this.LoginTabSelector.TabIndex = 2;
            this.LoginTabSelector.Text = "TabSelect1";
            // 
            // UserConfirmPassword
            // 
            this.UserConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.UserConfirmPassword.Size = new System.Drawing.Size(427, 48);
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
            this.UserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.UserPassword.Size = new System.Drawing.Size(427, 48);
            this.UserPassword.TabIndex = 0;
            this.UserPassword.TabStop = false;
            this.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserPassword.TrailingIcon = null;
            this.UserPassword.UseSystemPasswordChar = false;
            this.UserPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserPassword_KeyPress);
            this.UserPassword.MouseHover += new System.EventHandler(this.UserPassword_MouseHover);
            this.UserPassword.TextChanged += new System.EventHandler(this.UserPassword_TextChanged);
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
            this.JournalEntryPage.Size = new System.Drawing.Size(1013, 628);
            this.JournalEntryPage.TabIndex = 0;
            this.JournalEntryPage.Text = "Journal";
            this.JournalEntryPage.Click += new System.EventHandler(this.JournalEntryPage_Click);
            // 
            // DecryptionStatusLabel
            // 
            this.DecryptionStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DecryptionStatusLabel.Depth = 0;
            this.DecryptionStatusLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DecryptionStatusLabel.Location = new System.Drawing.Point(297, 595);
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
            this.SavedEntriesCount.Location = new System.Drawing.Point(724, 595);
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
            this.ChangeNameButton.Location = new System.Drawing.Point(163, 587);
            this.ChangeNameButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChangeNameButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangeNameButton.Name = "ChangeNameButton";
            this.ChangeNameButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChangeNameButton.Size = new System.Drawing.Size(103, 36);
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
            this.YourNameBox.Location = new System.Drawing.Point(6, 588);
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
            this.SaveEntryButton.Location = new System.Drawing.Point(901, 586);
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
            this.JournalEntryBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.JournalEntryBox.Size = new System.Drawing.Size(1005, 552);
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
            this.JournalTabSelector.Size = new System.Drawing.Size(1009, 24);
            this.JournalTabSelector.TabIndex = 0;
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
            this.NotepadPage.Size = new System.Drawing.Size(1013, 628);
            this.NotepadPage.TabIndex = 5;
            this.NotepadPage.Text = "Notepad";
            this.NotepadPage.Click += new System.EventHandler(this.Notepad_Click);
            // 
            // NotepadTitle
            // 
            this.NotepadTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NotepadTitle.Depth = 0;
            this.NotepadTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotepadTitle.Location = new System.Drawing.Point(147, 585);
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
            this.ColumnInNotepad.Location = new System.Drawing.Point(656, 604);
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
            this.CharsInNotepad.Location = new System.Drawing.Point(643, 585);
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
            this.ClearNotepadButton.Location = new System.Drawing.Point(3, 585);
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
            this.OpenFileButton.Location = new System.Drawing.Point(780, 585);
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
            this.SaveNotepadButton.Location = new System.Drawing.Point(881, 585);
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
            this.NotepadTabSelector.Size = new System.Drawing.Size(1007, 24);
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
            this.NotepadTextBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.NotepadTextBox.Size = new System.Drawing.Size(1007, 553);
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
            this.JournalEntriesPage.Size = new System.Drawing.Size(1013, 628);
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
            this.EditEntryButton.Location = new System.Drawing.Point(4, 586);
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
            this.DeleteEntriesButton.Location = new System.Drawing.Point(873, 586);
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
            this.EntriesListBox.Size = new System.Drawing.Size(1006, 544);
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
            this.EntriesTabSelector.Size = new System.Drawing.Size(1007, 24);
            this.EntriesTabSelector.TabIndex = 1;
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingsPage.Controls.Add(this.CustLockTimers);
            this.SettingsPage.Controls.Add(this.TenMinLock);
            this.SettingsPage.Controls.Add(this.FiveMinLock);
            this.SettingsPage.Controls.Add(this.ThreeMinLock);
            this.SettingsPage.Controls.Add(this.TwoMinLock);
            this.SettingsPage.Controls.Add(this.OneMinLock);
            this.SettingsPage.Controls.Add(this.AutoLockCheckbox);
            this.SettingsPage.Controls.Add(this.MinToSysTray);
            this.SettingsPage.Controls.Add(this.RequirePinToLogin);
            this.SettingsPage.Controls.Add(this.SettingsInfoLabel);
            this.SettingsPage.Controls.Add(this.EncryptEntriesButton);
            this.SettingsPage.Controls.Add(this.DisableNotificationsCheckbox);
            this.SettingsPage.Controls.Add(this.ImportEntriesButton);
            this.SettingsPage.Controls.Add(this.ExportEntriesButton);
            this.SettingsPage.Controls.Add(this.LeftSettingsNav);
            this.SettingsPage.Controls.Add(this.ResetAccountCheckbox);
            this.SettingsPage.Controls.Add(this.ResetLoginStatusButton);
            this.SettingsPage.Controls.Add(this.ApplyDateCheckbox);
            this.SettingsPage.Controls.Add(this.LightModeCheckbox);
            this.SettingsPage.Controls.Add(this.SettingsTabSelector);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(1013, 628);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.Click += new System.EventHandler(this.SettingsPage_Click);
            // 
            // TenMinLock
            // 
            this.TenMinLock.AutoSize = true;
            this.TenMinLock.Depth = 0;
            this.TenMinLock.Location = new System.Drawing.Point(93, 339);
            this.TenMinLock.Margin = new System.Windows.Forms.Padding(0);
            this.TenMinLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TenMinLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TenMinLock.Name = "TenMinLock";
            this.TenMinLock.ReadOnly = false;
            this.TenMinLock.Ripple = true;
            this.TenMinLock.Size = new System.Drawing.Size(139, 37);
            this.TenMinLock.TabIndex = 30;
            this.TenMinLock.Text = "10 minute lock";
            this.ToolTips.SetToolTip(this.TenMinLock, "You will need a PIN before logging in with your password when logged out.");
            this.TenMinLock.UseVisualStyleBackColor = true;
            this.TenMinLock.Visible = false;
            this.TenMinLock.CheckedChanged += new System.EventHandler(this.TenMinLock_CheckedChanged);
            // 
            // FiveMinLock
            // 
            this.FiveMinLock.AutoSize = true;
            this.FiveMinLock.Depth = 0;
            this.FiveMinLock.Location = new System.Drawing.Point(93, 302);
            this.FiveMinLock.Margin = new System.Windows.Forms.Padding(0);
            this.FiveMinLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FiveMinLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.FiveMinLock.Name = "FiveMinLock";
            this.FiveMinLock.ReadOnly = false;
            this.FiveMinLock.Ripple = true;
            this.FiveMinLock.Size = new System.Drawing.Size(130, 37);
            this.FiveMinLock.TabIndex = 29;
            this.FiveMinLock.Text = "5 minute lock";
            this.ToolTips.SetToolTip(this.FiveMinLock, "You will need a PIN before logging in with your password when logged out.");
            this.FiveMinLock.UseVisualStyleBackColor = true;
            this.FiveMinLock.Visible = false;
            this.FiveMinLock.CheckedChanged += new System.EventHandler(this.FiveMinLock_CheckedChanged);
            // 
            // ThreeMinLock
            // 
            this.ThreeMinLock.AutoSize = true;
            this.ThreeMinLock.Depth = 0;
            this.ThreeMinLock.Location = new System.Drawing.Point(93, 265);
            this.ThreeMinLock.Margin = new System.Windows.Forms.Padding(0);
            this.ThreeMinLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThreeMinLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThreeMinLock.Name = "ThreeMinLock";
            this.ThreeMinLock.ReadOnly = false;
            this.ThreeMinLock.Ripple = true;
            this.ThreeMinLock.Size = new System.Drawing.Size(130, 37);
            this.ThreeMinLock.TabIndex = 28;
            this.ThreeMinLock.Text = "3 minute lock";
            this.ToolTips.SetToolTip(this.ThreeMinLock, "You will need a PIN before logging in with your password when logged out.");
            this.ThreeMinLock.UseVisualStyleBackColor = true;
            this.ThreeMinLock.Visible = false;
            this.ThreeMinLock.CheckedChanged += new System.EventHandler(this.ThreeMinLock_CheckedChanged);
            // 
            // TwoMinLock
            // 
            this.TwoMinLock.AutoSize = true;
            this.TwoMinLock.Depth = 0;
            this.TwoMinLock.Location = new System.Drawing.Point(93, 228);
            this.TwoMinLock.Margin = new System.Windows.Forms.Padding(0);
            this.TwoMinLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.TwoMinLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TwoMinLock.Name = "TwoMinLock";
            this.TwoMinLock.ReadOnly = false;
            this.TwoMinLock.Ripple = true;
            this.TwoMinLock.Size = new System.Drawing.Size(130, 37);
            this.TwoMinLock.TabIndex = 27;
            this.TwoMinLock.Text = "2 minute lock";
            this.ToolTips.SetToolTip(this.TwoMinLock, "You will need a PIN before logging in with your password when logged out.");
            this.TwoMinLock.UseVisualStyleBackColor = true;
            this.TwoMinLock.Visible = false;
            this.TwoMinLock.CheckedChanged += new System.EventHandler(this.TwoMinLock_CheckedChanged);
            // 
            // OneMinLock
            // 
            this.OneMinLock.AutoSize = true;
            this.OneMinLock.Depth = 0;
            this.OneMinLock.Location = new System.Drawing.Point(93, 191);
            this.OneMinLock.Margin = new System.Windows.Forms.Padding(0);
            this.OneMinLock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OneMinLock.MouseState = MaterialSkin.MouseState.HOVER;
            this.OneMinLock.Name = "OneMinLock";
            this.OneMinLock.ReadOnly = false;
            this.OneMinLock.Ripple = true;
            this.OneMinLock.Size = new System.Drawing.Size(130, 37);
            this.OneMinLock.TabIndex = 26;
            this.OneMinLock.Text = "1 minute lock";
            this.ToolTips.SetToolTip(this.OneMinLock, "You will need a PIN before logging in with your password when logged out.");
            this.OneMinLock.UseVisualStyleBackColor = true;
            this.OneMinLock.Visible = false;
            this.OneMinLock.CheckedChanged += new System.EventHandler(this.OneMinLock_CheckedChanged);
            // 
            // AutoLockCheckbox
            // 
            this.AutoLockCheckbox.AutoSize = true;
            this.AutoLockCheckbox.Depth = 0;
            this.AutoLockCheckbox.Location = new System.Drawing.Point(93, 107);
            this.AutoLockCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.AutoLockCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AutoLockCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoLockCheckbox.Name = "AutoLockCheckbox";
            this.AutoLockCheckbox.ReadOnly = false;
            this.AutoLockCheckbox.Ripple = true;
            this.AutoLockCheckbox.Size = new System.Drawing.Size(244, 37);
            this.AutoLockCheckbox.TabIndex = 25;
            this.AutoLockCheckbox.Text = "Automatically lock SafeNotes";
            this.ToolTips.SetToolTip(this.AutoLockCheckbox, "You will need a PIN before logging in with your password when logged out.");
            this.AutoLockCheckbox.UseVisualStyleBackColor = true;
            this.AutoLockCheckbox.Visible = false;
            this.AutoLockCheckbox.CheckedChanged += new System.EventHandler(this.AutoLockCheckbox_CheckedChanged);
            // 
            // MinToSysTray
            // 
            this.MinToSysTray.AutoSize = true;
            this.MinToSysTray.Depth = 0;
            this.MinToSysTray.Location = new System.Drawing.Point(93, 33);
            this.MinToSysTray.Margin = new System.Windows.Forms.Padding(0);
            this.MinToSysTray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MinToSysTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinToSysTray.Name = "MinToSysTray";
            this.MinToSysTray.ReadOnly = false;
            this.MinToSysTray.Ripple = true;
            this.MinToSysTray.Size = new System.Drawing.Size(204, 37);
            this.MinToSysTray.TabIndex = 24;
            this.MinToSysTray.Text = "Minimize to system tray";
            this.ToolTips.SetToolTip(this.MinToSysTray, "You will need a PIN before logging in with your password when logged out.");
            this.MinToSysTray.UseVisualStyleBackColor = true;
            this.MinToSysTray.Visible = false;
            this.MinToSysTray.CheckedChanged += new System.EventHandler(this.MinToSysTray_CheckedChanged);
            // 
            // RequirePinToLogin
            // 
            this.RequirePinToLogin.AutoSize = true;
            this.RequirePinToLogin.Depth = 0;
            this.RequirePinToLogin.Location = new System.Drawing.Point(93, 70);
            this.RequirePinToLogin.Margin = new System.Windows.Forms.Padding(0);
            this.RequirePinToLogin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RequirePinToLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.RequirePinToLogin.Name = "RequirePinToLogin";
            this.RequirePinToLogin.ReadOnly = false;
            this.RequirePinToLogin.Ripple = true;
            this.RequirePinToLogin.Size = new System.Drawing.Size(174, 37);
            this.RequirePinToLogin.TabIndex = 23;
            this.RequirePinToLogin.Text = "Require PIN to login";
            this.ToolTips.SetToolTip(this.RequirePinToLogin, "You will need a PIN before logging in with your password when logged out.");
            this.RequirePinToLogin.UseVisualStyleBackColor = true;
            this.RequirePinToLogin.Visible = false;
            this.RequirePinToLogin.CheckedChanged += new System.EventHandler(this.RequirePenToLogin_CheckedChanged);
            // 
            // SettingsInfoLabel
            // 
            this.SettingsInfoLabel.AutoSize = true;
            this.SettingsInfoLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SettingsInfoLabel.Location = new System.Drawing.Point(94, 178);
            this.SettingsInfoLabel.Name = "SettingsInfoLabel";
            this.SettingsInfoLabel.Size = new System.Drawing.Size(46, 13);
            this.SettingsInfoLabel.TabIndex = 22;
            this.SettingsInfoLabel.Text = "Placebo";
            // 
            // EncryptEntriesButton
            // 
            this.EncryptEntriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EncryptEntriesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.EncryptEntriesButton.Depth = 0;
            this.EncryptEntriesButton.HighEmphasis = true;
            this.EncryptEntriesButton.Icon = null;
            this.EncryptEntriesButton.Location = new System.Drawing.Point(93, 132);
            this.EncryptEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EncryptEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EncryptEntriesButton.Name = "EncryptEntriesButton";
            this.EncryptEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EncryptEntriesButton.Size = new System.Drawing.Size(149, 36);
            this.EncryptEntriesButton.TabIndex = 21;
            this.EncryptEntriesButton.Text = "Encrypt entries";
            this.ToolTips.SetToolTip(this.EncryptEntriesButton, "Encrypts all your entries without logging out. This will activate Lockdown Mode.");
            this.EncryptEntriesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.EncryptEntriesButton.UseAccentColor = false;
            this.EncryptEntriesButton.UseVisualStyleBackColor = true;
            this.EncryptEntriesButton.Visible = false;
            this.EncryptEntriesButton.Click += new System.EventHandler(this.EncryptEntriesButton_Click);
            // 
            // DisableNotificationsCheckbox
            // 
            this.DisableNotificationsCheckbox.AutoSize = true;
            this.DisableNotificationsCheckbox.Depth = 0;
            this.DisableNotificationsCheckbox.Location = new System.Drawing.Point(93, 70);
            this.DisableNotificationsCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.DisableNotificationsCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.DisableNotificationsCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DisableNotificationsCheckbox.Name = "DisableNotificationsCheckbox";
            this.DisableNotificationsCheckbox.ReadOnly = false;
            this.DisableNotificationsCheckbox.Ripple = true;
            this.DisableNotificationsCheckbox.Size = new System.Drawing.Size(181, 37);
            this.DisableNotificationsCheckbox.TabIndex = 20;
            this.DisableNotificationsCheckbox.Text = "Disable notifications";
            this.ToolTips.SetToolTip(this.DisableNotificationsCheckbox, "Disables all SafeNotes notifications.");
            this.DisableNotificationsCheckbox.UseVisualStyleBackColor = true;
            this.DisableNotificationsCheckbox.Visible = false;
            // 
            // ImportEntriesButton
            // 
            this.ImportEntriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportEntriesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ImportEntriesButton.Depth = 0;
            this.ImportEntriesButton.HighEmphasis = true;
            this.ImportEntriesButton.Icon = null;
            this.ImportEntriesButton.Location = new System.Drawing.Point(94, 84);
            this.ImportEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ImportEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ImportEntriesButton.Name = "ImportEntriesButton";
            this.ImportEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ImportEntriesButton.Size = new System.Drawing.Size(138, 36);
            this.ImportEntriesButton.TabIndex = 19;
            this.ImportEntriesButton.Text = "Import entries";
            this.ToolTips.SetToolTip(this.ImportEntriesButton, "Import journal entries.");
            this.ImportEntriesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ImportEntriesButton.UseAccentColor = false;
            this.ImportEntriesButton.UseVisualStyleBackColor = true;
            this.ImportEntriesButton.Visible = false;
            this.ImportEntriesButton.Click += new System.EventHandler(this.ImportEntriesButton_Click);
            // 
            // ExportEntriesButton
            // 
            this.ExportEntriesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportEntriesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExportEntriesButton.Depth = 0;
            this.ExportEntriesButton.HighEmphasis = true;
            this.ExportEntriesButton.Icon = null;
            this.ExportEntriesButton.Location = new System.Drawing.Point(93, 36);
            this.ExportEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportEntriesButton.Name = "ExportEntriesButton";
            this.ExportEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExportEntriesButton.Size = new System.Drawing.Size(139, 36);
            this.ExportEntriesButton.TabIndex = 18;
            this.ExportEntriesButton.Text = "Export entries";
            this.ToolTips.SetToolTip(this.ExportEntriesButton, "Export your journal entries.");
            this.ExportEntriesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ExportEntriesButton.UseAccentColor = false;
            this.ExportEntriesButton.UseVisualStyleBackColor = true;
            this.ExportEntriesButton.Visible = false;
            this.ExportEntriesButton.Click += new System.EventHandler(this.ExportEntriesButton_Click);
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
            treeNode9.Name = "generalSetPage";
            treeNode9.Text = "General";
            treeNode10.Name = "accountSetPage";
            treeNode10.Text = "Account";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Entries";
            treeNode12.Name = "appSetPage";
            treeNode12.Text = "App";
            this.LeftSettingsNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12});
            this.LeftSettingsNav.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LeftSettingsNav.NodeSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.LeftSettingsNav.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.LeftSettingsNav.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("LeftSettingsNav.NodeUpPic")));
            this.LeftSettingsNav.ParentNodeCanSelect = true;
            this.LeftSettingsNav.ShowLines = false;
            this.LeftSettingsNav.ShowPlusMinus = false;
            this.LeftSettingsNav.ShowRootLines = false;
            this.LeftSettingsNav.Size = new System.Drawing.Size(82, 598);
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
            this.ResetAccountCheckbox.Size = new System.Drawing.Size(135, 37);
            this.ResetAccountCheckbox.TabIndex = 16;
            this.ResetAccountCheckbox.Text = "Reset account";
            this.ToolTips.SetToolTip(this.ResetAccountCheckbox, "Wipes all account data when you close SafeNotes.");
            this.ResetAccountCheckbox.UseVisualStyleBackColor = true;
            this.ResetAccountCheckbox.Visible = false;
            this.ResetAccountCheckbox.CheckedChanged += new System.EventHandler(this.ResetAccountCheckbox_CheckedChanged);
            // 
            // ResetLoginStatusButton
            // 
            this.ResetLoginStatusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetLoginStatusButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ResetLoginStatusButton.Depth = 0;
            this.ResetLoginStatusButton.HighEmphasis = true;
            this.ResetLoginStatusButton.Icon = null;
            this.ResetLoginStatusButton.Location = new System.Drawing.Point(93, 113);
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
            this.LightModeCheckbox.Location = new System.Drawing.Point(93, 70);
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
            this.SettingsTabSelector.Size = new System.Drawing.Size(1007, 24);
            this.SettingsTabSelector.TabIndex = 2;
            this.SettingsTabSelector.Text = "MaterialTabSelector2";
            // 
            // ReleaseNotesPage
            // 
            this.ReleaseNotesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ReleaseNotesPage.Controls.Add(this.ReleaseNotesMultiText);
            this.ReleaseNotesPage.Controls.Add(this.materialTabSelector1);
            this.ReleaseNotesPage.Location = new System.Drawing.Point(4, 22);
            this.ReleaseNotesPage.Margin = new System.Windows.Forms.Padding(2);
            this.ReleaseNotesPage.Name = "ReleaseNotesPage";
            this.ReleaseNotesPage.Size = new System.Drawing.Size(1013, 628);
            this.ReleaseNotesPage.TabIndex = 6;
            this.ReleaseNotesPage.Text = "Release Notes";
            // 
            // ReleaseNotesMultiText
            // 
            this.ReleaseNotesMultiText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseNotesMultiText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ReleaseNotesMultiText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReleaseNotesMultiText.Depth = 0;
            this.ReleaseNotesMultiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ReleaseNotesMultiText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReleaseNotesMultiText.Location = new System.Drawing.Point(3, 32);
            this.ReleaseNotesMultiText.Margin = new System.Windows.Forms.Padding(2);
            this.ReleaseNotesMultiText.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReleaseNotesMultiText.Name = "ReleaseNotesMultiText";
            this.ReleaseNotesMultiText.ReadOnly = true;
            this.ReleaseNotesMultiText.Size = new System.Drawing.Size(1008, 597);
            this.ReleaseNotesMultiText.TabIndex = 4;
            this.ReleaseNotesMultiText.Text = "";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.TabControl;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1010, 24);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "ReleaseNotesTabSelector";
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
            // SysTrayIcon
            // 
            this.SysTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTrayIcon.Icon")));
            this.SysTrayIcon.Text = "SafeNotes Tray";
            this.SysTrayIcon.Visible = true;
            // 
            // AutoLockTimer
            // 
            this.AutoLockTimer.Interval = 300000;
            this.AutoLockTimer.Tick += new System.EventHandler(this.AutoLockTimer_Tick);
            // 
            // CustLockTimers
            // 
            this.CustLockTimers.AutoSize = true;
            this.CustLockTimers.Depth = 0;
            this.CustLockTimers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLockTimers.Location = new System.Drawing.Point(94, 155);
            this.CustLockTimers.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustLockTimers.Name = "CustLockTimers";
            this.CustLockTimers.Size = new System.Drawing.Size(147, 19);
            this.CustLockTimers.TabIndex = 32;
            this.CustLockTimers.Text = "Custom Lock Timers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1027, 720);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 63, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Je ne sais pas...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
            this.ReleaseNotesPage.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialButton ImportEntriesButton;
        private MaterialSkin.Controls.MaterialButton ExportEntriesButton;
        private MaterialSkin.Controls.MaterialCheckbox DisableNotificationsCheckbox;
        public Mook.UI.Windows.Forms.LeftMenuNav LeftSettingsNav;
        private MaterialSkin.Controls.MaterialButton EncryptEntriesButton;
        private System.Windows.Forms.Label SettingsInfoLabel;
        private MaterialSkin.Controls.MaterialCheckbox RequirePinToLogin;
        private MaterialSkin.Controls.MaterialTextBox2 UserPINCodeField;
        private System.Windows.Forms.Label PasswordStrength;
        private System.Windows.Forms.TabPage ReleaseNotesPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox ReleaseNotesMultiText;
        private System.Windows.Forms.LinkLabel PasswordDisclaimer;
        private System.Windows.Forms.LinkLabel PinDisclaimer;
        private System.Windows.Forms.LinkLabel PasswordLengthDisclaimer;
        private MaterialSkin.Controls.MaterialCheckbox MinToSysTray;
        private System.Windows.Forms.NotifyIcon SysTrayIcon;
        private MaterialSkin.Controls.MaterialCheckbox AutoLockCheckbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer AutoLockTimer;
        private MaterialSkin.Controls.MaterialCheckbox OneMinLock;
        private MaterialSkin.Controls.MaterialCheckbox TwoMinLock;
        private MaterialSkin.Controls.MaterialCheckbox TenMinLock;
        private MaterialSkin.Controls.MaterialCheckbox FiveMinLock;
        private MaterialSkin.Controls.MaterialCheckbox ThreeMinLock;
        private MaterialSkin.Controls.MaterialLabel CustLockTimers;
    }
}

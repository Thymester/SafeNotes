using TabControl = System.Windows.Forms.TabControl;
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Theme");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Entries");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Security");
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
            this.MaterialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.NotepadTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.JournalEntriesPage = new System.Windows.Forms.TabPage();
            this.EditEntryButton = new MaterialSkin.Controls.MaterialButton();
            this.DeleteEntriesButton = new MaterialSkin.Controls.MaterialButton();
            this.EntriesListBox = new MaterialSkin.Controls.MaterialListView();
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContentsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabSelect3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TodoBoardPage = new System.Windows.Forms.TabPage();
            this.TodoBoardCtrl = new SafeNotes.TodoBoardControl();
            this.TodoTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.LeftMenuNav = new Mook.UI.Windows.Forms.LeftMenuNav();
            this.TabSelect4 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ResetAccountCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.ResetLoginStatusButton = new MaterialSkin.Controls.MaterialButton();
            this.ApplyDateCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.LightModeCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.CheckTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelVisibilityTimer = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.JournalEntryPage.SuspendLayout();
            this.NotepadPage.SuspendLayout();
            this.JournalEntriesPage.SuspendLayout();
            this.TodoBoardPage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LoginPage);
            this.TabControl.Controls.Add(this.JournalEntryPage);
            this.TabControl.Controls.Add(this.NotepadPage);
            this.TabControl.Controls.Add(this.JournalEntriesPage);
            this.TabControl.Controls.Add(this.TodoBoardPage);
            this.TabControl.Controls.Add(this.SettingsPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1089, 599);
            this.TabControl.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
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
            this.LoginPage.Size = new System.Drawing.Size(1081, 573);
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
            this.PasswordLengthSlider.Size = new System.Drawing.Size(596, 40);
            this.PasswordLengthSlider.TabIndex = 7;
            this.PasswordLengthSlider.Text = "Password Length";
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
            this.RegenPassButton.Location = new System.Drawing.Point(751, 309);
            this.RegenPassButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegenPassButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegenPassButton.Name = "RegenPassButton";
            this.RegenPassButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegenPassButton.Size = new System.Drawing.Size(95, 36);
            this.RegenPassButton.TabIndex = 5;
            this.RegenPassButton.Text = "Generate";
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
            this.PasswordGenBox.Size = new System.Drawing.Size(596, 48);
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
            this.UserLoginButton.Location = new System.Drawing.Point(707, 207);
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
            this.LoginTabSelector.Size = new System.Drawing.Size(1075, 25);
            this.LoginTabSelector.TabIndex = 2;
            this.LoginTabSelector.Text = "tabSelect1";
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
            this.UserConfirmPassword.Size = new System.Drawing.Size(496, 48);
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
            this.UserPassword.Size = new System.Drawing.Size(496, 48);
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
            this.JournalEntryPage.Controls.Add(this.SavedEntriesCount);
            this.JournalEntryPage.Controls.Add(this.ChangeNameButton);
            this.JournalEntryPage.Controls.Add(this.YourNameBox);
            this.JournalEntryPage.Controls.Add(this.SaveEntryButton);
            this.JournalEntryPage.Controls.Add(this.JournalEntryBox);
            this.JournalEntryPage.Controls.Add(this.JournalTabSelector);
            this.JournalEntryPage.Location = new System.Drawing.Point(4, 22);
            this.JournalEntryPage.Name = "JournalEntryPage";
            this.JournalEntryPage.Padding = new System.Windows.Forms.Padding(3);
            this.JournalEntryPage.Size = new System.Drawing.Size(1081, 573);
            this.JournalEntryPage.TabIndex = 0;
            this.JournalEntryPage.Text = "Journal";
            this.JournalEntryPage.Click += new System.EventHandler(this.JournalEntryPage_Click);
            // 
            // SavedEntriesCount
            // 
            this.SavedEntriesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SavedEntriesCount.Depth = 0;
            this.SavedEntriesCount.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SavedEntriesCount.Location = new System.Drawing.Point(790, 539);
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
            this.ChangeNameButton.Location = new System.Drawing.Point(163, 531);
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
            this.YourNameBox.Location = new System.Drawing.Point(6, 531);
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
            this.SaveEntryButton.Location = new System.Drawing.Point(967, 531);
            this.SaveEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveEntryButton.Name = "SaveEntryButton";
            this.SaveEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveEntryButton.Size = new System.Drawing.Size(107, 36);
            this.SaveEntryButton.TabIndex = 2;
            this.SaveEntryButton.Text = "Save Entry";
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
            this.JournalEntryBox.Size = new System.Drawing.Size(1078, 496);
            this.JournalEntryBox.TabIndex = 1;
            this.JournalEntryBox.TabStop = false;
            this.JournalEntryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.JournalEntryBox.UseSystemPasswordChar = false;
            this.JournalEntryBox.TextChanged += new System.EventHandler(this.JournalEntryBox_TextChanged);
            // 
            // JournalTabSelector
            // 
            this.JournalTabSelector.BaseTabControl = this.TabControl;
            this.JournalTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.JournalTabSelector.Depth = 0;
            this.JournalTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.JournalTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.JournalTabSelector.Location = new System.Drawing.Point(3, 3);
            this.JournalTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.JournalTabSelector.Name = "JournalTabSelector";
            this.JournalTabSelector.Size = new System.Drawing.Size(1075, 25);
            this.JournalTabSelector.TabIndex = 0;
            this.JournalTabSelector.Text = "materialTabSelector1";
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
            this.NotepadPage.Controls.Add(this.MaterialTabSelector1);
            this.NotepadPage.Controls.Add(this.NotepadTextBox);
            this.NotepadPage.Location = new System.Drawing.Point(4, 22);
            this.NotepadPage.Name = "NotepadPage";
            this.NotepadPage.Size = new System.Drawing.Size(1081, 573);
            this.NotepadPage.TabIndex = 5;
            this.NotepadPage.Text = "Notepad";
            this.NotepadPage.Click += new System.EventHandler(this.Notepad_Click);
            // 
            // NotepadTitle
            // 
            this.NotepadTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NotepadTitle.Depth = 0;
            this.NotepadTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.NotepadTitle.Location = new System.Drawing.Point(148, 531);
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
            this.ColumnInNotepad.Location = new System.Drawing.Point(721, 550);
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
            this.CharsInNotepad.Location = new System.Drawing.Point(712, 531);
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
            this.ClearNotepadButton.Location = new System.Drawing.Point(4, 531);
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
            this.OpenFileButton.Location = new System.Drawing.Point(849, 532);
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
            this.SaveNotepadButton.Location = new System.Drawing.Point(949, 532);
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
            // MaterialTabSelector1
            // 
            this.MaterialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaterialTabSelector1.BaseTabControl = this.TabControl;
            this.MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.MaterialTabSelector1.Depth = 0;
            this.MaterialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MaterialTabSelector1.Location = new System.Drawing.Point(3, 3);
            this.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.MaterialTabSelector1.Name = "MaterialTabSelector1";
            this.MaterialTabSelector1.Size = new System.Drawing.Size(1075, 25);
            this.MaterialTabSelector1.TabIndex = 3;
            this.MaterialTabSelector1.Text = "tabSelect1";
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
            this.NotepadTextBox.Size = new System.Drawing.Size(1078, 499);
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
            this.JournalEntriesPage.Controls.Add(this.TabSelect3);
            this.JournalEntriesPage.Location = new System.Drawing.Point(4, 22);
            this.JournalEntriesPage.Name = "JournalEntriesPage";
            this.JournalEntriesPage.Size = new System.Drawing.Size(1081, 573);
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
            this.EditEntryButton.Location = new System.Drawing.Point(4, 531);
            this.EditEntryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditEntryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditEntryButton.Name = "EditEntryButton";
            this.EditEntryButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.EditEntryButton.Size = new System.Drawing.Size(102, 36);
            this.EditEntryButton.TabIndex = 4;
            this.EditEntryButton.Text = "Edit entry";
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
            this.DeleteEntriesButton.Location = new System.Drawing.Point(941, 531);
            this.DeleteEntriesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteEntriesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteEntriesButton.Name = "DeleteEntriesButton";
            this.DeleteEntriesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteEntriesButton.Size = new System.Drawing.Size(136, 36);
            this.DeleteEntriesButton.TabIndex = 3;
            this.DeleteEntriesButton.Text = "Delete entries";
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
            this.EntriesListBox.Size = new System.Drawing.Size(1075, 489);
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
            // TabSelect3
            // 
            this.TabSelect3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabSelect3.BaseTabControl = this.TabControl;
            this.TabSelect3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelect3.Depth = 0;
            this.TabSelect3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelect3.Location = new System.Drawing.Point(3, 3);
            this.TabSelect3.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelect3.Name = "TabSelect3";
            this.TabSelect3.Size = new System.Drawing.Size(1075, 25);
            this.TabSelect3.TabIndex = 1;
            // 
            // TodoBoardPage
            // 
            this.TodoBoardPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TodoBoardPage.Controls.Add(this.TodoBoardCtrl);
            this.TodoBoardPage.Controls.Add(this.TodoTabSelector);
            this.TodoBoardPage.Location = new System.Drawing.Point(4, 22);
            this.TodoBoardPage.Name = "TodoBoardPage";
            this.TodoBoardPage.Padding = new System.Windows.Forms.Padding(3);
            this.TodoBoardPage.Size = new System.Drawing.Size(1081, 573);
            this.TodoBoardPage.TabIndex = 4;
            this.TodoBoardPage.Text = "To-Do Board";
            // 
            // TodoBoardCtrl
            // 
            this.TodoBoardCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodoBoardCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TodoBoardCtrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TodoBoardCtrl.Location = new System.Drawing.Point(-1, 31);
            this.TodoBoardCtrl.Name = "TodoBoardCtrl";
            this.TodoBoardCtrl.Size = new System.Drawing.Size(1083, 536);
            this.TodoBoardCtrl.TabIndex = 1;
            // 
            // TodoTabSelector
            // 
            this.TodoTabSelector.BaseTabControl = this.TabControl;
            this.TodoTabSelector.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TodoTabSelector.Depth = 0;
            this.TodoTabSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodoTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodoTabSelector.Location = new System.Drawing.Point(3, 3);
            this.TodoTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.TodoTabSelector.Name = "TodoTabSelector";
            this.TodoTabSelector.Size = new System.Drawing.Size(1075, 25);
            this.TodoTabSelector.TabIndex = 0;
            this.TodoTabSelector.Text = "todoTabSelector";
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingsPage.Controls.Add(this.LeftMenuNav);
            this.SettingsPage.Controls.Add(this.TabSelect4);
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(1081, 573);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Settings";
            this.SettingsPage.Click += new System.EventHandler(this.SettingsPage_Click);
            // 
            // LeftMenuNav
            // 
            this.LeftMenuNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.LeftMenuNav.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LeftMenuNav.CustomModel = true;
            this.LeftMenuNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenuNav.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.LeftMenuNav.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftMenuNav.FullRowSelect = true;
            this.LeftMenuNav.HideSelection = false;
            this.LeftMenuNav.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.LeftMenuNav.ItemHeight = 40;
            this.LeftMenuNav.Location = new System.Drawing.Point(3, 28);
            this.LeftMenuNav.Name = "LeftMenuNav";
            this.LeftMenuNav.NodeBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.LeftMenuNav.NodeDownPic = ((System.Drawing.Image)(resources.GetObject("LeftMenuNav.NodeDownPic")));
            this.LeftMenuNav.NodeForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.LeftMenuNav.NodeHeight = 40;
            this.LeftMenuNav.NodeIsShowSplitLine = false;
            treeNode1.Name = "themeSetPage";
            treeNode1.Text = "Theme";
            treeNode2.Name = "generalSetPage";
            treeNode2.Text = "General";
            treeNode3.Name = "entriesSetPage";
            treeNode3.Text = "Entries";
            treeNode4.Name = "securitySetPage";
            treeNode4.Text = "Security";
            this.LeftMenuNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.LeftMenuNav.NodeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.LeftMenuNav.NodeSelectedForeColor = System.Drawing.Color.White;
            this.LeftMenuNav.NodeSplitLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.LeftMenuNav.NodeUpPic = ((System.Drawing.Image)(resources.GetObject("LeftMenuNav.NodeUpPic")));
            this.LeftMenuNav.ParentNodeCanSelect = true;
            this.LeftMenuNav.ShowLines = false;
            this.LeftMenuNav.ShowPlusMinus = false;
            this.LeftMenuNav.ShowRootLines = false;
            this.LeftMenuNav.Size = new System.Drawing.Size(130, 542);
            this.LeftMenuNav.TabIndex = 17;
            this.LeftMenuNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.LeftMenuNav_AfterSelect);
            // 
            // TabSelect4
            // 
            this.TabSelect4.BaseTabControl = this.TabControl;
            this.TabSelect4.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.TabSelect4.Depth = 0;
            this.TabSelect4.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabSelect4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TabSelect4.Location = new System.Drawing.Point(3, 3);
            this.TabSelect4.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabSelect4.Name = "TabSelect4";
            this.TabSelect4.Size = new System.Drawing.Size(1075, 25);
            this.TabSelect4.TabIndex = 2;
            this.TabSelect4.Text = "materialTabSelector2";
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
            this.LightModeCheckbox.UseVisualStyleBackColor = true;
            this.LightModeCheckbox.Visible = false;
            this.LightModeCheckbox.CheckedChanged += new System.EventHandler(this.LightModeCheckbox_CheckedChanged);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1095, 666);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafeNotes";
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
            this.TodoBoardPage.ResumeLayout(false);
            this.SettingsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTabControl TabControl;
        public System.Windows.Forms.TabPage JournalEntryPage;
        public MaterialSkin.Controls.MaterialTabSelector JournalTabSelector;
        public System.Windows.Forms.TabPage JournalEntriesPage;
        public MaterialSkin.Controls.MaterialTabSelector TabSelect3;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 JournalEntryBox;
        public MaterialSkin.Controls.MaterialButton SaveEntryButton;
        public MaterialSkin.Controls.MaterialButton ChangeNameButton;
        public System.Windows.Forms.ColumnHeader DateCol;
        public System.Windows.Forms.ColumnHeader ContentsCol;
        public System.Windows.Forms.NotifyIcon TrayIcon;
        public System.Windows.Forms.TabPage SettingsPage;
        public MaterialSkin.Controls.MaterialTabSelector TabSelect4;
        public MaterialSkin.Controls.MaterialTextBox YourNameBox;
        public MaterialSkin.Controls.MaterialCheckbox LightModeCheckbox;
        public MaterialSkin.Controls.MaterialCheckbox ApplyDateCheckbox;
        public MaterialSkin.Controls.MaterialButton ResetLoginStatusButton;
        public MaterialSkin.Controls.MaterialListView EntriesListBox;
        public System.Windows.Forms.TabPage LoginPage;
        public MaterialSkin.Controls.MaterialTextBox2 UserConfirmPassword;
        public MaterialSkin.Controls.MaterialTextBox2 UserPassword;
        public MaterialSkin.Controls.MaterialTabSelector LoginTabSelector;
        public MaterialSkin.Controls.MaterialButton UserLoginButton;
        public System.Windows.Forms.ToolTip ToolTips;
        public MaterialSkin.Controls.MaterialCheckbox ResetAccountCheckbox;
        public Mook.UI.Windows.Forms.LeftMenuNav LeftMenuNav;
        public System.Windows.Forms.Timer CheckTimer;
        public MaterialSkin.Controls.MaterialButton DeleteEntriesButton;
        public MaterialSkin.Controls.MaterialTextBox2 PasswordGenBox;
        public MaterialSkin.Controls.MaterialButton UsePassButton;
        public MaterialSkin.Controls.MaterialButton RegenPassButton;
        public MaterialSkin.Controls.MaterialSlider PasswordLengthSlider;
        public MaterialSkin.Controls.MaterialLabel PasswordCopiedLabel;
        public System.Windows.Forms.Timer LabelVisibilityTimer;
        public System.Windows.Forms.TabPage NotepadPage;
        public MaterialSkin.Controls.MaterialMultiLineTextBox2 NotepadTextBox;
        public MaterialSkin.Controls.MaterialTabSelector MaterialTabSelector1;
        public MaterialSkin.Controls.MaterialLabel SavedEntriesCount;
        public MaterialSkin.Controls.MaterialButton SaveNotepadButton;
        public MaterialSkin.Controls.MaterialButton OpenFileButton;
        public MaterialSkin.Controls.MaterialButton ClearNotepadButton;
        public MaterialSkin.Controls.MaterialLabel CharsInNotepad;
        public MaterialSkin.Controls.MaterialLabel ColumnInNotepad;
        public MaterialSkin.Controls.MaterialLabel NotepadTitle;
        public MaterialSkin.Controls.MaterialButton EditEntryButton;
        public System.Windows.Forms.TabPage TodoBoardPage;
        public MaterialSkin.Controls.MaterialTabSelector TodoTabSelector;
        public SafeNotes.TodoBoardControl TodoBoardCtrl;
    }
}


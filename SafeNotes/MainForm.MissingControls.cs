// File: SafeNotes/MainForm.MissingControls.cs
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SafeNotes
{
    public partial class MainForm
    {
        public Mook.UI.Windows.Forms.LeftMenuNav LeftSettingsNav => LeftMenuNav;

        // Legacy / AppManager compatibility controls:
        public MaterialCheckbox AutoLockCheckbox = new MaterialCheckbox();
        public System.Windows.Forms.Timer AutoLockTimer = new System.Windows.Forms.Timer();
        public Panel CustLockTimers = new Panel();
        public MaterialLabel DecryptionStatusLabel = new MaterialLabel();
        public MaterialCheckbox DisableNotificationsCheckbox = new MaterialCheckbox();
        public MaterialButton EncryptEntriesButton = new MaterialButton();
        public MaterialButton ExportEntriesButton = new MaterialButton();
        public MaterialCheckbox FiveMinLock = new MaterialCheckbox();
        public MaterialButton ImportEntriesButton = new MaterialButton();
        public MaterialCheckbox MinToSysTray = new MaterialCheckbox();
        public MaterialCheckbox OneMinLock = new MaterialCheckbox();
        public LinkLabel PasswordLengthDisclaimer = new LinkLabel();
        public MaterialLabel PasswordStrength = new MaterialLabel();
        public MaterialMultiLineTextBox2 ReleaseNotesMultiText = new MaterialMultiLineTextBox2();
        public MaterialCheckbox RequirePinToLogin = new MaterialCheckbox();
        public MaterialLabel SettingsInfoLabel = new MaterialLabel();
        public NotifyIcon SysTrayIcon { get; set; } = new NotifyIcon();
        public MaterialCheckbox TenMinLock = new MaterialCheckbox();
        public MaterialCheckbox ThreeMinLock = new MaterialCheckbox();
        public MaterialCheckbox TwoMinLock = new MaterialCheckbox();
        public MaterialTextBox2 UserPINCodeField = new MaterialTextBox2();

        // Clean Settings Flow Panels:
        public Panel SettingsContentPanel = new Panel();
        public FlowLayoutPanel PnlTheme = new FlowLayoutPanel();
        public FlowLayoutPanel PnlGeneral = new FlowLayoutPanel();
        public FlowLayoutPanel PnlEntries = new FlowLayoutPanel();
        public FlowLayoutPanel PnlSecurity = new FlowLayoutPanel();

        public void InitializeSettingsControls()
        {
            if (SettingsPage == null) return;

            // 1. Remove direct legacy controls from SettingsPage to eliminate elevation shadow artifacts
            SettingsPage.Controls.Remove(ResetAccountCheckbox);
            SettingsPage.Controls.Remove(ResetLoginStatusButton);
            SettingsPage.Controls.Remove(ApplyDateCheckbox);
            SettingsPage.Controls.Remove(LightModeCheckbox);

            // 2. Setup LeftMenuNav sidebar styling
            LeftMenuNav.Width = 130;
            LeftMenuNav.ItemHeight = 42;
            LeftMenuNav.NodeHeight = 42;
            LeftMenuNav.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            LeftMenuNav.BackColor = Color.FromArgb(36, 36, 39);
            LeftMenuNav.NodeBackgroundColor = Color.FromArgb(36, 36, 39);
            LeftMenuNav.NodeForeColor = Color.FromArgb(220, 220, 225);
            LeftMenuNav.HoverColor = Color.FromArgb(52, 52, 58);
            LeftMenuNav.NodeSelectedColor = Color.FromArgb(83, 109, 254);
            LeftMenuNav.NodeSelectedForeColor = Color.White;

            // 3. Setup Settings Content Container (under TabSelect4 at Y=31)
            SettingsContentPanel.Location = new Point(135, 31);
            SettingsContentPanel.Size = new Size(Math.Max(500, SettingsPage.ClientSize.Width - 138), Math.Max(350, SettingsPage.ClientSize.Height - 34));
            SettingsContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SettingsContentPanel.BackColor = Color.FromArgb(45, 45, 48);

            // Configure the 4 sub-pages
            SetupThemeSubPage();
            SetupGeneralSubPage();
            SetupEntriesSubPage();
            SetupSecuritySubPage();

            // Wire all event handlers to AppManager methods
            WireSettingsEventHandlers();

            SettingsContentPanel.Controls.Clear();
            SettingsContentPanel.Controls.Add(PnlTheme);
            SettingsContentPanel.Controls.Add(PnlGeneral);
            SettingsContentPanel.Controls.Add(PnlEntries);
            SettingsContentPanel.Controls.Add(PnlSecurity);

            SettingsPage.Controls.Add(SettingsContentPanel);

            // Activate initial sub-page (Theme by default)
            SelectSettingsSubPage(0);
        }

        private void WireSettingsEventHandlers()
        {
            // Entries actions (Export, Import, Lockdown)
            ExportEntriesButton.Click -= ExportEntriesButton_Click;
            ExportEntriesButton.Click += ExportEntriesButton_Click;

            ImportEntriesButton.Click -= ImportEntriesButton_Click;
            ImportEntriesButton.Click += ImportEntriesButton_Click;

            EncryptEntriesButton.Click -= EncryptEntriesButton_Click;
            EncryptEntriesButton.Click += EncryptEntriesButton_Click;

            // Security actions
            AutoLockCheckbox.CheckedChanged -= AutoLockCheckbox_CheckedChanged;
            AutoLockCheckbox.CheckedChanged += AutoLockCheckbox_CheckedChanged;

            MinToSysTray.CheckedChanged -= MinToSysTray_CheckedChanged;
            MinToSysTray.CheckedChanged += MinToSysTray_CheckedChanged;

            RequirePinToLogin.CheckedChanged -= RequirePenToLogin_CheckedChanged;
            RequirePinToLogin.CheckedChanged += RequirePenToLogin_CheckedChanged;

            DisableNotificationsCheckbox.CheckedChanged -= DisableNotificationsCheckbox_CheckedChanged;
            DisableNotificationsCheckbox.CheckedChanged += DisableNotificationsCheckbox_CheckedChanged;
        }

        private void DisableNotificationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (_settings != null)
            {
                _settings.DisableNotifications = DisableNotificationsCheckbox.Checked;
                SettingsManager.SaveSettings(_settings);
            }
        }

        public void SelectSettingsSubPage(int index)
        {
            if (PnlTheme != null) PnlTheme.Visible = (index == 0);
            if (PnlGeneral != null) PnlGeneral.Visible = (index == 1);
            if (PnlEntries != null) PnlEntries.Visible = (index == 2);
            if (PnlSecurity != null) PnlSecurity.Visible = (index == 3);
        }

        #region Theme Sub-Page
        private void SetupThemeSubPage()
        {
            ConfigureFlowPanel(PnlTheme);

            var header = CreateSectionHeader("Appearance & Theme", "Customize the visual appearance and color theme of SafeNotes.");
            PnlTheme.Controls.Add(header);

            // Light Mode Checkbox
            LightModeCheckbox.Text = "Light Mode";
            LightModeCheckbox.AutoSize = true;
            LightModeCheckbox.Depth = 0;
            LightModeCheckbox.Visible = true;
            LightModeCheckbox.Margin = new Padding(4, 4, 0, 16);
            PnlTheme.Controls.Add(LightModeCheckbox);

            // Info Card
            var infoBox = CreateInfoCard(
                "Theme Preference",
                "SafeNotes automatically remembers your selected theme and restores it whenever the application starts. Changes apply immediately to all active tabs and dialogs.",
                Color.FromArgb(83, 109, 254),
                640
            );
            PnlTheme.Controls.Add(infoBox);
        }
        #endregion

        #region General Sub-Page
        private void SetupGeneralSubPage()
        {
            ConfigureFlowPanel(PnlGeneral);

            var header = CreateSectionHeader("Account & Authentication", "Manage master login credentials, session persistence, and secondary PIN security.");
            PnlGeneral.Controls.Add(header);

            // 1. Reset account on close
            ResetAccountCheckbox.Text = "Reset account on close";
            ResetAccountCheckbox.AutoSize = true;
            ResetAccountCheckbox.Depth = 0;
            ResetAccountCheckbox.Visible = true;
            ResetAccountCheckbox.Margin = new Padding(4, 4, 0, 8);
            PnlGeneral.Controls.Add(ResetAccountCheckbox);

            // 2. Reset login status button
            ResetLoginStatusButton.Text = "RESET LOGIN STATUS";
            ResetLoginStatusButton.Type = MaterialButton.MaterialButtonType.Contained;
            ResetLoginStatusButton.HighEmphasis = true;
            ResetLoginStatusButton.UseAccentColor = false;
            ResetLoginStatusButton.Depth = 0;
            ResetLoginStatusButton.AutoSize = true;
            ResetLoginStatusButton.Visible = true;
            ResetLoginStatusButton.Margin = new Padding(4, 4, 0, 12);
            PnlGeneral.Controls.Add(ResetLoginStatusButton);

            // 3. Require PIN code to login
            RequirePinToLogin.Text = "Require PIN code to login";
            RequirePinToLogin.AutoSize = true;
            RequirePinToLogin.Depth = 0;
            RequirePinToLogin.Visible = true;
            RequirePinToLogin.Margin = new Padding(4, 4, 0, 16);
            PnlGeneral.Controls.Add(RequirePinToLogin);

            // 4. Info Card: PIN Security
            var infoBox = CreateInfoCard(
                "About PIN Code Security",
                "The login PIN is a second layer of security to help eliminate unwanted access to SafeNotes.\n\n" +
                "• Best Practice: To ensure high security, generate a numeric PIN at least eight digits long.\n\n" +
                "• Password Management: Always store your master password and PIN in a reputable password manager (e.g., Bitwarden, 1Password, Proton Pass) so you never lose access.",
                Color.FromArgb(83, 109, 254),
                640
            );
            PnlGeneral.Controls.Add(infoBox);
        }
        #endregion

        #region Entries Sub-Page
        private void SetupEntriesSubPage()
        {
            ConfigureFlowPanel(PnlEntries);

            var header = CreateSectionHeader("Journal Entries & Backups", "Configure entry metadata timestamps, manage offline backups, and activate emergency lockdown.");
            PnlEntries.Controls.Add(header);

            // 1. Apply date to entry
            ApplyDateCheckbox.Text = "Apply date to entry";
            ApplyDateCheckbox.AutoSize = true;
            ApplyDateCheckbox.Depth = 0;
            ApplyDateCheckbox.Visible = true;
            ApplyDateCheckbox.Margin = new Padding(4, 4, 0, 10);
            PnlEntries.Controls.Add(ApplyDateCheckbox);

            // 2. Export & Import buttons in a row
            ExportEntriesButton.Text = "EXPORT ENTRIES";
            ExportEntriesButton.Type = MaterialButton.MaterialButtonType.Contained;
            ExportEntriesButton.HighEmphasis = true;
            ExportEntriesButton.UseAccentColor = false;
            ExportEntriesButton.Depth = 0;
            ExportEntriesButton.AutoSize = true;
            ExportEntriesButton.Visible = true;
            ExportEntriesButton.Margin = new Padding(0, 0, 12, 0);

            ImportEntriesButton.Text = "IMPORT ENTRIES";
            ImportEntriesButton.Type = MaterialButton.MaterialButtonType.Contained;
            ImportEntriesButton.HighEmphasis = true;
            ImportEntriesButton.UseAccentColor = false;
            ImportEntriesButton.Depth = 0;
            ImportEntriesButton.AutoSize = true;
            ImportEntriesButton.Visible = true;
            ImportEntriesButton.Margin = new Padding(0);

            FlowLayoutPanel backupButtonsFlow = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                BackColor = Color.Transparent,
                Margin = new Padding(4, 4, 0, 10)
            };
            backupButtonsFlow.Controls.Add(ExportEntriesButton);
            backupButtonsFlow.Controls.Add(ImportEntriesButton);
            PnlEntries.Controls.Add(backupButtonsFlow);

            // 3. Emergency Lockdown button
            EncryptEntriesButton.Text = "LOCKDOWN MODE";
            EncryptEntriesButton.Type = MaterialButton.MaterialButtonType.Contained;
            EncryptEntriesButton.HighEmphasis = true;
            EncryptEntriesButton.UseAccentColor = true;
            EncryptEntriesButton.Depth = 0;
            EncryptEntriesButton.AutoSize = true;
            EncryptEntriesButton.Visible = true;
            EncryptEntriesButton.Margin = new Padding(4, 4, 0, 16);
            PnlEntries.Controls.Add(EncryptEntriesButton);

            // 4. Info Card: Backup & Lockdown Information
            var infoBox = CreateInfoCard(
                "Backup & Lockdown Information",
                "• Export Entries: Backs up your AES-256 encrypted entries into an entries.txt file for safe offline storage.\n\n" +
                "• Import Entries: Restores entries from a previous export. You must log in using the exact same master password used during exportation.\n\n" +
                "• Lockdown Mode: SafeNotes immediately re-encrypts all entries and removes them from active memory, securing your data instantly.",
                Color.FromArgb(231, 76, 60),
                640
            );
            PnlEntries.Controls.Add(infoBox);
        }
        #endregion

        #region Security Sub-Page
        private void SetupSecuritySubPage()
        {
            ConfigureFlowPanel(PnlSecurity);

            var header = CreateSectionHeader("System & Inactivity Security", "Configure notification tray behavior, alerts, and automatic inactivity lock timers.");
            PnlSecurity.Controls.Add(header);

            // 1. Minimize to system tray
            MinToSysTray.Text = "Minimize to system tray";
            MinToSysTray.AutoSize = true;
            MinToSysTray.Depth = 0;
            MinToSysTray.Visible = true;
            MinToSysTray.Margin = new Padding(4, 4, 0, 8);
            PnlSecurity.Controls.Add(MinToSysTray);

            // 2. Disable notifications
            DisableNotificationsCheckbox.Text = "Disable notifications";
            DisableNotificationsCheckbox.AutoSize = true;
            DisableNotificationsCheckbox.Depth = 0;
            DisableNotificationsCheckbox.Visible = true;
            DisableNotificationsCheckbox.Margin = new Padding(4, 4, 0, 8);
            PnlSecurity.Controls.Add(DisableNotificationsCheckbox);

            // 3. Auto lock SafeNotes
            AutoLockCheckbox.Text = "Auto lock SafeNotes";
            AutoLockCheckbox.AutoSize = true;
            AutoLockCheckbox.Depth = 0;
            AutoLockCheckbox.Visible = true;
            AutoLockCheckbox.Margin = new Padding(4, 4, 0, 8);
            PnlSecurity.Controls.Add(AutoLockCheckbox);

            // 4. Lock Delay Timers Panel (Cleanly indented below AutoLockCheckbox)
            CustLockTimers.Size = new Size(580, 40);
            CustLockTimers.BackColor = Color.Transparent;
            CustLockTimers.Margin = new Padding(24, 0, 0, 10);
            CustLockTimers.Controls.Clear();

            Label timerPrompt = new Label
            {
                Text = "Lock Delay:",
                Font = new Font("Segoe UI", 9.0f, FontStyle.Bold),
                ForeColor = Color.FromArgb(220, 220, 225),
                AutoSize = true,
                Location = new Point(0, 9),
                UseMnemonic = false
            };
            CustLockTimers.Controls.Add(timerPrompt);

            MaterialCheckbox[] timerRadios = { OneMinLock, TwoMinLock, ThreeMinLock, FiveMinLock, TenMinLock };
            string[] timerLabels = { "1 Min", "2 Min", "3 Min", "5 Min", "10 Min" };
            int tx = 88;
            for (int i = 0; i < timerRadios.Length; i++)
            {
                var cb = timerRadios[i];
                cb.Text = timerLabels[i];
                cb.AutoSize = true;
                cb.Depth = 0;
                cb.Location = new Point(tx, 0);
                cb.Visible = true;
                CustLockTimers.Controls.Add(cb);
                tx += 75;
            }

            CustLockTimers.Visible = AutoLockCheckbox.Checked;

            AutoLockCheckbox.CheckedChanged += (s, e) =>
            {
                CustLockTimers.Visible = AutoLockCheckbox.Checked;
                foreach (var cb in timerRadios)
                {
                    cb.Visible = AutoLockCheckbox.Checked;
                }
            };

            PnlSecurity.Controls.Add(CustLockTimers);

            // 5. Info Box: Inactivity Details (Positioned in FlowLayoutPanel so it NEVER overlaps!)
            var infoBox = CreateInfoCard(
                "Auto-Lock Inactivity Details",
                "• Automatic Security: When the inactivity timer expires, SafeNotes instantly purges plaintext from memory and returns to the master login screen.\n\n" +
                "• Activity Tracking: Any keyboard or mouse activity automatically resets the inactivity countdown timer.",
                Color.FromArgb(46, 204, 113),
                640
            );
            PnlSecurity.Controls.Add(infoBox);
        }
        #endregion

        #region UI Building Helpers
        private void ConfigureFlowPanel(FlowLayoutPanel flp)
        {
            flp.Controls.Clear();
            flp.Dock = DockStyle.Fill;
            flp.FlowDirection = FlowDirection.TopDown;
            flp.WrapContents = false;
            flp.AutoScroll = true;
            flp.BackColor = Color.FromArgb(45, 45, 48);
            flp.Padding = new Padding(16, 12, 16, 36);
        }

        private Panel CreateSectionHeader(string title, string subtitle)
        {
            Panel pnl = new Panel
            {
                Width = 640,
                Height = 46,
                BackColor = Color.Transparent,
                Margin = new Padding(0, 0, 0, 12)
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 12.0f, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(0, 0),
                AutoSize = true,
                UseMnemonic = false
            };
            pnl.Controls.Add(lblTitle);

            Label lblSub = new Label
            {
                Text = subtitle,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(165, 165, 175),
                Location = new Point(1, 24),
                AutoSize = true,
                UseMnemonic = false
            };
            pnl.Controls.Add(lblSub);

            return pnl;
        }

        private Panel CreateInfoCard(string title, string body, Color accentColor, int width = 640)
        {
            Panel card = new Panel
            {
                Width = width,
                BackColor = Color.FromArgb(32, 34, 42),
                Padding = new Padding(16, 12, 16, 16),
                Margin = new Padding(0, 10, 0, 24)
            };

            // Paint accent strip on left and outer border
            card.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(50, 52, 60), 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, card.Width - 1, card.Height - 1);
                }
                using (SolidBrush brush = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
                }
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(16, 12),
                AutoSize = true,
                UseMnemonic = false
            };
            card.Controls.Add(lblTitle);

            int bodyWidth = width - 36;
            Font bodyFont = new Font("Segoe UI", 9.0f, FontStyle.Regular);
            Size measured = TextRenderer.MeasureText(body, bodyFont, new Size(bodyWidth, int.MaxValue), TextFormatFlags.WordBreak | TextFormatFlags.TextBoxControl);

            Label lblBody = new Label
            {
                Text = body,
                Font = bodyFont,
                ForeColor = Color.FromArgb(210, 215, 225),
                Location = new Point(16, 36),
                Size = new Size(bodyWidth, measured.Height + 40),
                AutoSize = false,
                UseMnemonic = false
            };
            card.Controls.Add(lblBody);

            card.Height = lblBody.Location.Y + lblBody.Height + 20;
            return card;
        }
        #endregion
    }
}

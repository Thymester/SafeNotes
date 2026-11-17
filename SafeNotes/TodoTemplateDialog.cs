// File: SafeNotes/TodoTemplateDialog.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SafeNotes
{
    public class TodoTemplateDialog : Form
    {
        public string SelectedTemplate { get; private set; }

        private ListBox templateListBox;
        private Label descriptionLabel;

        private readonly (string Name, string Description)[] templates = new[]
        {
            ("Standard Kanban", "Classic workflow: Planned, In Progress, and Complete. Great for general everyday tasks."),
            ("Personal / Daily Life", "Designed for busy everyday people: To Do Today, This Week, In Progress, and Done."),
            ("Software Development", "For developers and tech enthusiasts: Backlog, In Progress, Code Review, QA / Testing, and Deployed."),
            ("Shopping & Errands", "For groceries, chores, and errands: To Buy / Errands, At the Store, and Purchased / Done."),
            ("Goal & Project Tracker", "For personal or professional milestones: Ideas & Planned, Milestone 1, Milestone 2, and Completed.")
        };

        public TodoTemplateDialog(bool isDarkMode)
        {
            InitializeCustomUI(isDarkMode);
        }

        private void InitializeCustomUI(bool isDarkMode)
        {
            this.Text = "Choose a Board Template";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(460, 340);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            Color bgColor = isDarkMode ? Color.FromArgb(37, 37, 40) : Color.FromArgb(248, 249, 250);
            Color fgColor = isDarkMode ? Color.FromArgb(240, 240, 240) : Color.FromArgb(33, 37, 41);
            Color inputBg = isDarkMode ? Color.FromArgb(50, 50, 54) : Color.White;
            Color accentColor = Color.FromArgb(52, 152, 219);

            this.BackColor = bgColor;
            this.ForeColor = fgColor;
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

            Label lblIntro = new Label
            {
                Text = "Select a preset to customize your tracker for your workflow:",
                Location = new Point(20, 16),
                Width = 420,
                ForeColor = fgColor
            };
            this.Controls.Add(lblIntro);

            templateListBox = new ListBox
            {
                Location = new Point(20, 45),
                Width = 420,
                Height = 130,
                BackColor = inputBg,
                ForeColor = fgColor,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10f, FontStyle.Regular)
            };

            foreach (var t in templates)
            {
                templateListBox.Items.Add(t.Name);
            }
            templateListBox.SelectedIndex = 0;
            this.Controls.Add(templateListBox);

            descriptionLabel = new Label
            {
                Location = new Point(20, 190),
                Width = 420,
                Height = 65,
                ForeColor = isDarkMode ? Color.FromArgb(180, 180, 185) : Color.FromArgb(100, 100, 105),
                Text = templates[0].Description,
                Font = new Font("Segoe UI", 9.0f, FontStyle.Italic)
            };
            this.Controls.Add(descriptionLabel);

            templateListBox.SelectedIndexChanged += (s, e) =>
            {
                if (templateListBox.SelectedIndex >= 0)
                {
                    descriptionLabel.Text = templates[templateListBox.SelectedIndex].Description;
                }
            };

            Button btnApply = new Button
            {
                Text = "Apply Template",
                Location = new Point(200, 280),
                Width = 140,
                Height = 36,
                BackColor = accentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.Click += (s, e) =>
            {
                if (templateListBox.SelectedIndex >= 0)
                {
                    SelectedTemplate = templates[templateListBox.SelectedIndex].Name;
                }
            };
            this.Controls.Add(btnApply);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(348, 280),
                Width = 92,
                Height = 36,
                BackColor = isDarkMode ? Color.FromArgb(60, 60, 64) : Color.FromArgb(230, 230, 230),
                ForeColor = fgColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnApply;
            this.CancelButton = btnCancel;
        }
    }
}

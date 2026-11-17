// File: SafeNotes/TodoColumnDialog.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SafeNotes
{
    public class TodoColumnDialog : Form
    {
        public string ColumnName { get; private set; }
        public string ColorHex { get; private set; }
        public bool IsCompleteColumn { get; private set; }

        private TextBox nameBox;
        private ComboBox colorComboBox;
        private CheckBox isCompleteBox;
        private Panel colorPreviewPanel;

        private readonly (string Name, string Hex)[] colorPresets = new[]
        {
            ("Sky Blue", "#3498DB"),
            ("Royal Blue", "#2980B9"),
            ("Emerald Green", "#2ECC71"),
            ("Forest Green", "#27AE60"),
            ("Amber / Orange", "#F39C12"),
            ("Coral Red", "#E74C3C"),
            ("Purple / Violet", "#9B59B6"),
            ("Teal", "#1ABC9C"),
            ("Slate / Gray", "#7F8C8D"),
            ("Dark Slate", "#34495E")
        };

        public TodoColumnDialog(string currentName, string currentColorHex, bool isComplete, bool isEdit, bool isDarkMode)
        {
            ColumnName = currentName ?? "New Column";
            ColorHex = !string.IsNullOrEmpty(currentColorHex) ? currentColorHex : "#3498DB";
            IsCompleteColumn = isComplete;

            InitializeCustomUI(isEdit, isDarkMode);
        }

        private void InitializeCustomUI(bool isEdit, bool isDarkMode)
        {
            this.Text = isEdit ? "Customize Column" : "Add New Column";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(380, 260);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            Color bgColor = isDarkMode ? Color.FromArgb(37, 37, 40) : Color.FromArgb(248, 249, 250);
            Color fgColor = isDarkMode ? Color.FromArgb(240, 240, 240) : Color.FromArgb(33, 37, 41);
            Color inputBg = isDarkMode ? Color.FromArgb(50, 50, 54) : Color.White;
            Color accentColor = Color.FromArgb(52, 152, 219);

            this.BackColor = bgColor;
            this.ForeColor = fgColor;
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

            Label lblName = new Label
            {
                Text = "Column / Stage Name *",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Location = new Point(24, 20),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblName);

            nameBox = new TextBox
            {
                Location = new Point(24, 45),
                Width = 332,
                BackColor = inputBg,
                ForeColor = fgColor,
                BorderStyle = BorderStyle.FixedSingle,
                Text = ColumnName
            };
            this.Controls.Add(nameBox);

            Label lblColor = new Label
            {
                Text = "Accent Color",
                Location = new Point(24, 85),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblColor);

            colorComboBox = new ComboBox
            {
                Location = new Point(24, 110),
                Width = 270,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = inputBg,
                ForeColor = fgColor
            };

            int selectedColorIndex = 0;
            for (int i = 0; i < colorPresets.Length; i++)
            {
                colorComboBox.Items.Add(colorPresets[i].Name);
                if (string.Equals(colorPresets[i].Hex, ColorHex, StringComparison.OrdinalIgnoreCase))
                    selectedColorIndex = i;
            }
            colorComboBox.SelectedIndex = selectedColorIndex;
            this.Controls.Add(colorComboBox);

            colorPreviewPanel = new Panel
            {
                Location = new Point(304, 110),
                Size = new Size(52, 25),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = ColorTranslator.FromHtml(ColorHex)
            };
            this.Controls.Add(colorPreviewPanel);

            colorComboBox.SelectedIndexChanged += (s, e) =>
            {
                if (colorComboBox.SelectedIndex >= 0)
                {
                    ColorHex = colorPresets[colorComboBox.SelectedIndex].Hex;
                    colorPreviewPanel.BackColor = ColorTranslator.FromHtml(ColorHex);
                }
            };

            isCompleteBox = new CheckBox
            {
                Text = "Treat tasks in this column as 'Completed'",
                Location = new Point(24, 150),
                AutoSize = true,
                ForeColor = fgColor,
                Checked = IsCompleteColumn
            };
            this.Controls.Add(isCompleteBox);

            Button btnSave = new Button
            {
                Text = isEdit ? "Save" : "Add Column",
                Location = new Point(160, 200),
                Width = 100,
                Height = 36,
                BackColor = accentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    MessageBox.Show("Please enter a name for the column.", "Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }
                ColumnName = nameBox.Text.Trim();
                IsCompleteColumn = isCompleteBox.Checked;
            };
            this.Controls.Add(btnSave);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(268, 200),
                Width = 88,
                Height = 36,
                BackColor = isDarkMode ? Color.FromArgb(60, 60, 64) : Color.FromArgb(230, 230, 230),
                ForeColor = fgColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
        }
    }
}

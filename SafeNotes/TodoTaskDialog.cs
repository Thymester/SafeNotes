// File: SafeNotes/TodoTaskDialog.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SafeNotes
{
    public class TodoTaskDialog : Form
    {
        public TodoItem TaskItem { get; private set; }
        public string SelectedColumnId { get; private set; }

        private TextBox titleBox;
        private TextBox descriptionBox;
        private ComboBox columnComboBox;
        private ComboBox priorityComboBox;
        private TextBox tagBox;
        private CheckBox enableDueDateBox;
        private DateTimePicker dueDatePicker;
        private CheckBox isCompletedBox;
        private Button saveButton;
        private Button cancelButton;

        public TodoTaskDialog(TodoItem existingItem, List<TodoColumn> columns, string defaultColumnId, bool isDarkMode)
        {
            TaskItem = existingItem != null ? existingItem.Clone() : new TodoItem();
            SelectedColumnId = defaultColumnId;

            InitializeCustomUI(existingItem != null, columns, defaultColumnId, isDarkMode);
        }

        private void InitializeCustomUI(bool isEdit, List<TodoColumn> columns, string defaultColumnId, bool isDarkMode)
        {
            this.Text = isEdit ? "Edit Task" : "New Task";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(460, 490);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            Color bgColor = isDarkMode ? Color.FromArgb(37, 37, 40) : Color.FromArgb(248, 249, 250);
            Color fgColor = isDarkMode ? Color.FromArgb(240, 240, 240) : Color.FromArgb(33, 37, 41);
            Color inputBg = isDarkMode ? Color.FromArgb(50, 50, 54) : Color.White;
            Color borderColor = isDarkMode ? Color.FromArgb(70, 70, 75) : Color.FromArgb(206, 212, 218);
            Color accentColor = Color.FromArgb(52, 152, 219);

            this.BackColor = bgColor;
            this.ForeColor = fgColor;
            this.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

            // Title Label & Box
            Label lblTitle = new Label
            {
                Text = "Task Title *",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Location = new Point(24, 20),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblTitle);

            titleBox = new TextBox
            {
                Location = new Point(24, 45),
                Width = 412,
                BackColor = inputBg,
                ForeColor = fgColor,
                BorderStyle = BorderStyle.FixedSingle,
                Text = TaskItem.Title
            };
            this.Controls.Add(titleBox);

            // Column Selection Label & Dropdown
            Label lblColumn = new Label
            {
                Text = "Stage / Column",
                Location = new Point(24, 85),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblColumn);

            columnComboBox = new ComboBox
            {
                Location = new Point(24, 110),
                Width = 195,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = inputBg,
                ForeColor = fgColor
            };
            int selectedIndex = 0;
            if (columns != null)
            {
                for (int i = 0; i < columns.Count; i++)
                {
                    columnComboBox.Items.Add(columns[i].Name);
                    if (columns[i].Id == defaultColumnId)
                        selectedIndex = i;
                }
            }
            if (columnComboBox.Items.Count > 0)
                columnComboBox.SelectedIndex = selectedIndex;
            this.Controls.Add(columnComboBox);

            // Priority Selection Label & Dropdown
            Label lblPriority = new Label
            {
                Text = "Priority",
                Location = new Point(240, 85),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblPriority);

            priorityComboBox = new ComboBox
            {
                Location = new Point(240, 110),
                Width = 196,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = inputBg,
                ForeColor = fgColor
            };
            priorityComboBox.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            priorityComboBox.SelectedItem = string.IsNullOrEmpty(TaskItem.Priority) ? "Medium" : TaskItem.Priority;
            this.Controls.Add(priorityComboBox);

            // Tag / Category Label & Box
            Label lblTag = new Label
            {
                Text = "Category / Tag (e.g. Work, Personal, Bug)",
                Location = new Point(24, 150),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblTag);

            tagBox = new TextBox
            {
                Location = new Point(24, 175),
                Width = 412,
                BackColor = inputBg,
                ForeColor = fgColor,
                BorderStyle = BorderStyle.FixedSingle,
                Text = TaskItem.Tag
            };
            this.Controls.Add(tagBox);

            // Due Date Row
            enableDueDateBox = new CheckBox
            {
                Text = "Set Due Date:",
                Location = new Point(24, 215),
                AutoSize = true,
                ForeColor = fgColor,
                Checked = TaskItem.DueDate.HasValue
            };
            this.Controls.Add(enableDueDateBox);

            dueDatePicker = new DateTimePicker
            {
                Location = new Point(150, 212),
                Width = 286,
                Format = DateTimePickerFormat.Short,
                Enabled = TaskItem.DueDate.HasValue,
                Value = TaskItem.DueDate.HasValue ? TaskItem.DueDate.Value : DateTime.Today.AddDays(1)
            };
            enableDueDateBox.CheckedChanged += (s, e) =>
            {
                dueDatePicker.Enabled = enableDueDateBox.Checked;
            };
            this.Controls.Add(dueDatePicker);

            // Description / Notes Label & Multi-line Box
            Label lblDesc = new Label
            {
                Text = "Notes / Description",
                Location = new Point(24, 255),
                AutoSize = true,
                ForeColor = fgColor
            };
            this.Controls.Add(lblDesc);

            descriptionBox = new TextBox
            {
                Location = new Point(24, 280),
                Width = 412,
                Height = 100,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = inputBg,
                ForeColor = fgColor,
                BorderStyle = BorderStyle.FixedSingle,
                Text = TaskItem.Description
            };
            this.Controls.Add(descriptionBox);

            // Is Completed checkbox
            isCompletedBox = new CheckBox
            {
                Text = "Mark as Completed",
                Location = new Point(24, 395),
                AutoSize = true,
                ForeColor = fgColor,
                Checked = TaskItem.IsCompleted
            };
            this.Controls.Add(isCompletedBox);

            // Buttons
            saveButton = new Button
            {
                Text = isEdit ? "Save Changes" : "Add Task",
                Location = new Point(216, 435),
                Width = 120,
                Height = 36,
                BackColor = accentColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(titleBox.Text))
                {
                    MessageBox.Show("Please enter a title for the task.", "Title Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.None;
                    return;
                }

                TaskItem.Title = titleBox.Text.Trim();
                TaskItem.Description = descriptionBox.Text.Trim();
                TaskItem.Priority = priorityComboBox.SelectedItem != null ? priorityComboBox.SelectedItem.ToString() : "Medium";
                TaskItem.Tag = tagBox.Text.Trim();
                TaskItem.DueDate = enableDueDateBox.Checked ? (DateTime?)dueDatePicker.Value.Date : null;
                TaskItem.IsCompleted = isCompletedBox.Checked;

                if (columns != null && columnComboBox.SelectedIndex >= 0 && columnComboBox.SelectedIndex < columns.Count)
                {
                    SelectedColumnId = columns[columnComboBox.SelectedIndex].Id;
                }
            };
            this.Controls.Add(saveButton);

            cancelButton = new Button
            {
                Text = "Cancel",
                Location = new Point(344, 435),
                Width = 92,
                Height = 36,
                BackColor = isDarkMode ? Color.FromArgb(60, 60, 64) : Color.FromArgb(230, 230, 230),
                ForeColor = fgColor,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            cancelButton.FlatAppearance.BorderSize = 0;
            this.Controls.Add(cancelButton);

            this.AcceptButton = saveButton;
            this.CancelButton = cancelButton;
        }
    }
}

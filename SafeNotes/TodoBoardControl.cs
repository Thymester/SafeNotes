// File: SafeNotes/TodoBoardControl.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SafeNotes
{
    public class TodoBoardControl : UserControl
    {
        public TodoBoard Board { get; private set; }
        public bool IsDarkMode { get; private set; } = true;

        public event EventHandler BoardChanged;

        // UI Controls
        private Panel topPanel;
        private Label titleLabel;
        private Label statsLabel;
        private MaterialSkin.Controls.MaterialProgressBar completionProgressBar;
        private FlowLayoutPanel actionToolbar;
        private TextBox searchBox;
        private ComboBox priorityFilterBox;
        private Button btnAddTask;
        private Button btnAddColumn;
        private Button btnTemplates;
        private Button btnClearDone;
        private Button btnExport;
        private Button btnImport;

        private FlowLayoutPanel columnsFlowPanel;

        // Theme Colors
        private Color cBg;
        private Color cColumnBg;
        private Color cCardBg;
        private Color cCardBorder;
        private Color cTextPrimary;
        private Color cTextSecondary;
        private Color cAccent = Color.FromArgb(83, 109, 254);

        // Filter state
        private string currentSearchTerm = string.Empty;
        private string currentPriorityFilter = "All Priorities";

        public TodoBoardControl()
        {
            this.DoubleBuffered = true;
            this.Board = TodoBoard.CreateDefault();
            InitializeComponent();
            ApplyTheme(true);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Dock = DockStyle.Fill;
            this.Font = new Font("Segoe UI", 9.0f, FontStyle.Regular);

            // Top Dashboard Panel
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 78,
                Padding = new Padding(12, 6, 12, 6)
            };
            topPanel.Paint += TopPanel_Paint;

            // Row 1: Title, Stats, Progress Bar
            titleLabel = new Label
            {
                Text = "To-Do Tracker",
                Font = new Font("Segoe UI", 11.5f, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(12, 8)
            };
            topPanel.Controls.Add(titleLabel);

            statsLabel = new Label
            {
                Text = "4 Tasks • 1 In Progress • 1 Done (25%)",
                Font = new Font("Segoe UI", 9.0f, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(140, 11)
            };
            topPanel.Controls.Add(statsLabel);

            completionProgressBar = new MaterialSkin.Controls.MaterialProgressBar
            {
                Location = new Point(430, 13),
                Size = new Size(160, 8),
                Minimum = 0,
                Maximum = 100,
                Value = 25
            };
            topPanel.Controls.Add(completionProgressBar);

            // Row 2: Action & Filter Toolbar (FlowLayoutPanel for responsive layout)
            actionToolbar = new FlowLayoutPanel
            {
                Location = new Point(8, 36),
                Height = 36,
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoScroll = true,
                Padding = new Padding(0, 2, 0, 0)
            };

            // Search Box
            searchBox = new TextBox
            {
                Width = 160,
                Height = 26,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9.0f),
                Margin = new Padding(2, 2, 6, 2)
            };
            SetWatermark(searchBox, "🔍 Search cards...");
            searchBox.TextChanged += (s, e) =>
            {
                string txt = (searchBox.Text ?? "").Trim();
                if (string.IsNullOrEmpty(txt) ||
                    string.Equals(txt, "🔍 Search cards...", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(txt, "Search cards...", StringComparison.OrdinalIgnoreCase))
                {
                    currentSearchTerm = string.Empty;
                }
                else
                {
                    currentSearchTerm = txt.ToLowerInvariant();
                }
                RefreshBoardCardsOnly();
            };
            searchBox.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    searchBox.Text = string.Empty;
                    e.SuppressKeyPress = true;
                }
            };
            actionToolbar.Controls.Add(searchBox);

            // Priority Filter Dropdown
            priorityFilterBox = new ComboBox
            {
                Width = 110,
                Height = 26,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 8.5f),
                Margin = new Padding(0, 2, 8, 2)
            };
            priorityFilterBox.Items.AddRange(new object[] { "All Priorities", "Urgent", "High", "Medium", "Low" });
            priorityFilterBox.SelectedIndex = 0;
            priorityFilterBox.SelectedIndexChanged += (s, e) =>
            {
                currentPriorityFilter = priorityFilterBox.SelectedItem != null ? priorityFilterBox.SelectedItem.ToString() : "All Priorities";
                RefreshBoardCardsOnly();
            };
            actionToolbar.Controls.Add(priorityFilterBox);

            // Buttons
            btnAddTask = CreateActionButton("+ New Task", Color.FromArgb(83, 109, 254), Color.White, 96, 26, true);
            btnAddTask.Click += BtnAddTask_Click;
            actionToolbar.Controls.Add(btnAddTask);

            btnAddColumn = CreateActionButton("+ Column", Color.FromArgb(60, 60, 66), Color.White, 88, 26, false);
            btnAddColumn.Click += BtnAddColumn_Click;
            actionToolbar.Controls.Add(btnAddColumn);

            btnTemplates = CreateActionButton("Templates", Color.FromArgb(60, 60, 66), Color.White, 92, 26, false);
            btnTemplates.Click += BtnTemplates_Click;
            actionToolbar.Controls.Add(btnTemplates);

            btnClearDone = CreateActionButton("Clear Done", Color.FromArgb(60, 60, 66), Color.White, 96, 26, false);
            btnClearDone.Click += BtnClearDone_Click;
            actionToolbar.Controls.Add(btnClearDone);

            btnExport = CreateActionButton("Export", Color.FromArgb(60, 60, 66), Color.White, 76, 26, false);
            btnExport.Click += BtnExport_Click;
            actionToolbar.Controls.Add(btnExport);

            btnImport = CreateActionButton("Import", Color.FromArgb(60, 60, 66), Color.White, 76, 26, false);
            btnImport.Click += BtnImport_Click;
            actionToolbar.Controls.Add(btnImport);

            topPanel.Controls.Add(actionToolbar);
            this.Controls.Add(topPanel);

            // Columns Flow Panel (Horizontal scrollable canvas)
            columnsFlowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = false,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(8, 8, 8, 8)
            };
            columnsFlowPanel.Resize += (s, e) => UpdateColumnHeights();
            this.Controls.Add(columnsFlowPanel);

            // Ensure proper WinForms dock ordering:
            // topPanel stays at Top, columnsFlowPanel fills below it
            topPanel.SendToBack();
            columnsFlowPanel.BringToFront();

            this.ResumeLayout(false);
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                UpdateColumnHeights();
            }
        }

        private Button CreateActionButton(string text, Color bg, Color fg, int width, int height, bool isPrimary = false)
        {
            Button btn = new Button
            {
                Text = text,
                AutoSize = true,
                MinimumSize = new Size(width, height),
                Height = height,
                Padding = new Padding(8, 0, 8, 0),
                BackColor = bg,
                ForeColor = fg,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 2, 6, 2)
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = isPrimary ? Color.FromArgb(105, 128, 255) : Color.FromArgb(75, 75, 82);
            return btn;
        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(IsDarkMode ? Color.FromArgb(60, 60, 64) : Color.FromArgb(220, 224, 230), 1))
            {
                e.Graphics.DrawLine(pen, 0, topPanel.Height - 1, topPanel.Width, topPanel.Height - 1);
            }
        }

        public void ApplyTheme(bool isDarkMode)
        {
            this.IsDarkMode = isDarkMode;

            // SafeNotes native page background: Color.FromArgb(45, 45, 48)
            cBg = isDarkMode ? Color.FromArgb(45, 45, 48) : Color.FromArgb(242, 242, 242);
            cColumnBg = isDarkMode ? Color.FromArgb(36, 36, 39) : Color.FromArgb(232, 234, 238);
            cCardBg = isDarkMode ? Color.FromArgb(53, 53, 58) : Color.White;
            cCardBorder = isDarkMode ? Color.FromArgb(68, 68, 74) : Color.FromArgb(218, 222, 228);
            cTextPrimary = isDarkMode ? Color.FromArgb(240, 240, 245) : Color.FromArgb(33, 37, 41);
            cTextSecondary = isDarkMode ? Color.FromArgb(160, 160, 170) : Color.FromArgb(108, 117, 125);
            cAccent = Color.FromArgb(83, 109, 254);

            this.BackColor = cBg;
            topPanel.BackColor = cBg;
            actionToolbar.BackColor = Color.Transparent;
            columnsFlowPanel.BackColor = cBg;

            titleLabel.ForeColor = cTextPrimary;
            statsLabel.ForeColor = cTextSecondary;

            searchBox.BackColor = isDarkMode ? Color.FromArgb(36, 36, 39) : Color.White;
            searchBox.ForeColor = cTextPrimary;

            priorityFilterBox.BackColor = isDarkMode ? Color.FromArgb(36, 36, 39) : Color.White;
            priorityFilterBox.ForeColor = cTextPrimary;

            // Update button colors for theme
            if (btnAddTask != null)
            {
                btnAddTask.BackColor = Color.FromArgb(83, 109, 254);
                btnAddTask.ForeColor = Color.White;
                btnAddTask.FlatAppearance.MouseOverBackColor = Color.FromArgb(105, 128, 255);
            }
            Color secBtnBg = isDarkMode ? Color.FromArgb(60, 60, 66) : Color.FromArgb(225, 228, 233);
            Color secBtnFg = isDarkMode ? Color.FromArgb(240, 240, 245) : Color.FromArgb(40, 40, 45);
            Color secBtnHover = isDarkMode ? Color.FromArgb(75, 75, 82) : Color.FromArgb(210, 214, 220);

            Button[] secButtons = { btnAddColumn, btnTemplates, btnClearDone, btnExport, btnImport };
            foreach (var b in secButtons)
            {
                if (b != null)
                {
                    b.BackColor = secBtnBg;
                    b.ForeColor = secBtnFg;
                    b.FlatAppearance.MouseOverBackColor = secBtnHover;
                }
            }

            topPanel.Invalidate();
            RenderBoard();
        }

        public void LoadBoard(TodoBoard board)
        {
            this.Board = board ?? TodoBoard.CreateDefault();
            RenderBoard();
        }

        public void RenderBoard()
        {
            UpdateStats();

            columnsFlowPanel.SuspendLayout();
            columnsFlowPanel.Controls.Clear();

            int targetHeight = Math.Max(350, columnsFlowPanel.ClientSize.Height - 24);

            if (Board != null && Board.Columns != null)
            {
                for (int colIndex = 0; colIndex < Board.Columns.Count; colIndex++)
                {
                    var col = Board.Columns[colIndex];
                    var colControl = CreateColumnControl(col, colIndex, targetHeight);
                    columnsFlowPanel.Controls.Add(colControl);
                }
            }

            columnsFlowPanel.ResumeLayout(true);
        }

        private void UpdateColumnHeights()
        {
            if (columnsFlowPanel == null) return;
            int targetHeight = Math.Max(350, columnsFlowPanel.ClientSize.Height - 24);
            foreach (Control ctrl in columnsFlowPanel.Controls)
            {
                if (ctrl is Panel colPanel && colPanel.Tag is TodoColumn)
                {
                    colPanel.Height = targetHeight;
                }
            }
        }

        private void RefreshBoardCardsOnly()
        {
            UpdateStats();

            foreach (Control ctrl in columnsFlowPanel.Controls)
            {
                if (ctrl is Panel colPanel && colPanel.Tag is TodoColumn col)
                {
                    FlowLayoutPanel cardsContainer = colPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault(p => p.Name == "cardsContainer");
                    if (cardsContainer != null)
                    {
                        PopulateColumnCards(cardsContainer, col);
                    }
                    Label countLabel = colPanel.Controls.Find("countLabel", true).FirstOrDefault() as Label;
                    if (countLabel != null)
                    {
                        countLabel.Text = $"({col.Items.Count})";
                    }
                }
            }
        }

        private void UpdateStats()
        {
            int total = Board.GetTotalTaskCount();
            int inProgress = Board.GetInProgressTaskCount();
            int completed = Board.GetCompletedTaskCount();
            int percentage = total > 0 ? (int)Math.Round((double)completed / total * 100) : 0;

            statsLabel.Text = $"{total} Tasks • {inProgress} In Progress • {completed} Done ({percentage}%)";
            completionProgressBar.Value = Math.Max(0, Math.Min(100, percentage));
        }

        #region Column Creation
        private Panel CreateColumnControl(TodoColumn col, int colIndex, int height)
        {
            Panel colPanel = new Panel
            {
                Width = 270,
                Height = height,
                Margin = new Padding(0, 0, 16, 0),
                BackColor = cColumnBg,
                Tag = col,
                AllowDrop = true
            };

            // Drag-drop to column panel
            colPanel.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(DragCardData)))
                    e.Effect = DragDropEffects.Move;
            };
            colPanel.DragDrop += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(DragCardData)))
                {
                    var data = (DragCardData)e.Data.GetData(typeof(DragCardData));
                    MoveTaskBetweenColumns(data.SourceColumnId, col.Id, data.TaskId);
                }
            };

            // 1. Colored top accent stripe
            Color colAccent = ColorTranslator.FromHtml(string.IsNullOrEmpty(col.ColorHex) ? "#3498DB" : col.ColorHex);
            Panel stripe = new Panel
            {
                Dock = DockStyle.Top,
                Height = 4,
                BackColor = colAccent
            };

            // 2. Column Header Panel
            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 38,
                Padding = new Padding(8, 4, 8, 4),
                BackColor = cColumnBg
            };

            Label colTitle = new Label
            {
                Text = col.Name,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = cTextPrimary,
                AutoSize = false,
                Location = new Point(8, 8),
                Size = new Size(125, 22),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand,
                AutoEllipsis = true
            };
            colTitle.Click += (s, e) => EditColumn(col);
            headerPanel.Controls.Add(colTitle);

            Label colCount = new Label
            {
                Name = "countLabel",
                Text = $"({col.Items.Count})",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                ForeColor = cTextSecondary,
                AutoSize = true,
                Location = new Point(135, 11)
            };
            headerPanel.Controls.Add(colCount);

            // Column reorder & options buttons
            Button btnLeft = new Button
            {
                Text = "◀",
                Size = new Size(22, 22),
                Location = new Point(175, 8),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 6.5f),
                Cursor = Cursors.Hand,
                Enabled = colIndex > 0
            };
            btnLeft.FlatAppearance.BorderSize = 0;
            btnLeft.Click += (s, e) => MoveColumn(colIndex, colIndex - 1);
            headerPanel.Controls.Add(btnLeft);

            Button btnRight = new Button
            {
                Text = "▶",
                Size = new Size(22, 22),
                Location = new Point(200, 8),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 6.5f),
                Cursor = Cursors.Hand,
                Enabled = colIndex < Board.Columns.Count - 1
            };
            btnRight.FlatAppearance.BorderSize = 0;
            btnRight.Click += (s, e) => MoveColumn(colIndex, colIndex + 1);
            headerPanel.Controls.Add(btnRight);

            Button btnOptions = new Button
            {
                Text = "⋮",
                Size = new Size(22, 22),
                Location = new Point(225, 8),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 10.0f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.Click += (s, e) => ShowColumnMenu(col, btnOptions);
            headerPanel.Controls.Add(btnOptions);

            // 3. Column Footer: "+ Add Card"
            Button btnAddCardToCol = new Button
            {
                Dock = DockStyle.Bottom,
                Height = 32,
                Text = "+ Add Card",
                FlatStyle = FlatStyle.Flat,
                BackColor = cColumnBg,
                ForeColor = cAccent,
                Font = new Font("Segoe UI", 9.0f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnAddCardToCol.FlatAppearance.BorderSize = 0;
            btnAddCardToCol.Click += (s, e) =>
            {
                using (var dlg = new TodoTaskDialog(null, Board.Columns, col.Id, IsDarkMode))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        var targetCol = Board.Columns.FirstOrDefault(c => c.Id == dlg.SelectedColumnId) ?? col;
                        targetCol.Items.Add(dlg.TaskItem);
                        OnBoardChanged();
                        RenderBoard();
                    }
                }
            };

            // 4. Column Cards Container (FlowLayoutPanel handles scrolling and positioning smoothly)
            FlowLayoutPanel cardsContainer = new FlowLayoutPanel
            {
                Name = "cardsContainer",
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = false,
                FlowDirection = FlowDirection.TopDown,
                BackColor = cColumnBg,
                Padding = new Padding(8, 4, 8, 4),
                AllowDrop = true
            };
            cardsContainer.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(DragCardData)))
                    e.Effect = DragDropEffects.Move;
            };
            cardsContainer.DragDrop += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(DragCardData)))
                {
                    var data = (DragCardData)e.Data.GetData(typeof(DragCardData));
                    MoveTaskBetweenColumns(data.SourceColumnId, col.Id, data.TaskId);
                }
            };

            PopulateColumnCards(cardsContainer, col);

            // Assemble with correct WinForms Dock priority:
            // Controls docked to edges are added and SendToBack so they take their edge first.
            // cardsContainer (Dock=Fill) is BringToFront so it fills the remaining space between header and footer.
            colPanel.Controls.Add(cardsContainer);
            colPanel.Controls.Add(btnAddCardToCol);
            colPanel.Controls.Add(headerPanel);
            colPanel.Controls.Add(stripe);

            stripe.SendToBack();
            headerPanel.SendToBack();
            btnAddCardToCol.SendToBack();
            cardsContainer.BringToFront();

            return colPanel;
        }

        private void PopulateColumnCards(FlowLayoutPanel container, TodoColumn col)
        {
            container.SuspendLayout();
            container.Controls.Clear();

            var filteredItems = col.Items.Where(MatchesFilter).ToList();

            if (filteredItems.Count == 0 && col.Items.Count > 0 && (!string.IsNullOrEmpty(currentSearchTerm) || currentPriorityFilter != "All Priorities"))
            {
                Label noMatches = new Label
                {
                    Text = "No cards match filter",
                    ForeColor = cTextSecondary,
                    Font = new Font("Segoe UI", 8.5f, FontStyle.Italic),
                    AutoSize = true,
                    Margin = new Padding(8, 8, 8, 0)
                };
                container.Controls.Add(noMatches);
            }

            foreach (var item in filteredItems)
            {
                Control card = CreateCardControl(col, item);
                container.Controls.Add(card);
            }

            container.ResumeLayout(true);
        }

        private bool MatchesFilter(TodoItem item)
        {
            if (item == null) return false;

            if (!string.IsNullOrEmpty(currentPriorityFilter) && currentPriorityFilter != "All Priorities")
            {
                if (!string.Equals(item.Priority, currentPriorityFilter, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            if (!string.IsNullOrEmpty(currentSearchTerm))
            {
                bool matchesTitle = item.Title != null && item.Title.ToLowerInvariant().Contains(currentSearchTerm);
                bool matchesDesc = item.Description != null && item.Description.ToLowerInvariant().Contains(currentSearchTerm);
                bool matchesTag = item.Tag != null && item.Tag.ToLowerInvariant().Contains(currentSearchTerm);

                if (!matchesTitle && !matchesDesc && !matchesTag)
                    return false;
            }

            return true;
        }
        #endregion

        #region Card Creation
        private Control CreateCardControl(TodoColumn col, TodoItem item)
        {
            // 232px width fits cleanly inside 270px column with padding and vertical scrollbar
            const int cardWidth = 232;

            Panel card = new Panel
            {
                Width = cardWidth,
                BackColor = cCardBg,
                Margin = new Padding(2, 0, 2, 8),
                Cursor = Cursors.Hand,
                Tag = item
            };

            // Calculate card height dynamically
            int contentY = 6;

            // Row 1: Badges (Priority, Tag, Due Date)
            FlowLayoutPanel badgeRow = new FlowLayoutPanel
            {
                Location = new Point(10, contentY),
                Width = cardWidth - 18,
                Height = 18,
                WrapContents = false,
                BackColor = Color.Transparent
            };

            Color pColor = GetPriorityColor(item.Priority);
            Label pBadge = new Label
            {
                Text = item.Priority ?? "Normal",
                Font = new Font("Segoe UI", 7.0f, FontStyle.Bold),
                BackColor = Color.FromArgb(40, pColor),
                ForeColor = pColor,
                AutoSize = true,
                Padding = new Padding(3, 0, 3, 0),
                Margin = new Padding(0, 0, 4, 0)
            };
            badgeRow.Controls.Add(pBadge);

            if (!string.IsNullOrWhiteSpace(item.Tag))
            {
                Label tagBadge = new Label
                {
                    Text = "#" + item.Tag,
                    Font = new Font("Segoe UI", 7.0f, FontStyle.Regular),
                    BackColor = IsDarkMode ? Color.FromArgb(60, 60, 65) : Color.FromArgb(225, 230, 235),
                    ForeColor = cTextSecondary,
                    AutoSize = true,
                    Padding = new Padding(3, 0, 3, 0),
                    Margin = new Padding(0, 0, 4, 0)
                };
                badgeRow.Controls.Add(tagBadge);
            }

            if (item.DueDate.HasValue)
            {
                DateTime due = item.DueDate.Value.Date;
                bool isOverdue = due < DateTime.Today && !item.IsCompleted && !col.IsCompleteColumn;
                bool isToday = due == DateTime.Today;

                Color dueColor = isOverdue ? Color.FromArgb(231, 76, 60) : (isToday ? Color.FromArgb(243, 156, 18) : cTextSecondary);
                string dueText = isOverdue ? "⚠ Overdue" : (isToday ? "Due Today" : due.ToString("MMM d"));

                Label dueBadge = new Label
                {
                    Text = dueText,
                    Font = new Font("Segoe UI", 7.0f, FontStyle.Bold),
                    BackColor = Color.FromArgb(30, dueColor),
                    ForeColor = dueColor,
                    AutoSize = true,
                    Padding = new Padding(3, 0, 3, 0),
                    Margin = new Padding(0, 0, 4, 0)
                };
                badgeRow.Controls.Add(dueBadge);
            }

            card.Controls.Add(badgeRow);
            contentY += 22;

            // Row 2: Title (multi-line safe, auto-wrapping up to 40px)
            Label titleLabel = new Label
            {
                Text = item.Title,
                Font = new Font("Segoe UI", 9.0f, (item.IsCompleted || col.IsCompleteColumn) ? FontStyle.Strikeout : FontStyle.Bold),
                ForeColor = (item.IsCompleted || col.IsCompleteColumn) ? cTextSecondary : cTextPrimary,
                Location = new Point(10, contentY),
                Width = cardWidth - 18,
                AutoSize = true,
                MaximumSize = new Size(cardWidth - 18, 40),
                BackColor = Color.Transparent
            };
            titleLabel.DoubleClick += (s, e) => EditTask(col, item);
            card.Controls.Add(titleLabel);

            // Compute title height
            int titleHeight = Math.Max(18, titleLabel.GetPreferredSize(new Size(cardWidth - 18, 0)).Height);
            contentY += titleHeight + 4;

            // Row 3: Description snippet (if present)
            if (!string.IsNullOrWhiteSpace(item.Description))
            {
                Label descLabel = new Label
                {
                    Text = "📝 " + item.Description.Replace("\r\n", " ").Replace("\n", " "),
                    Font = new Font("Segoe UI", 7.5f, FontStyle.Italic),
                    ForeColor = cTextSecondary,
                    Location = new Point(10, contentY),
                    Width = cardWidth - 18,
                    Height = 16,
                    AutoEllipsis = true,
                    BackColor = Color.Transparent
                };
                descLabel.DoubleClick += (s, e) => EditTask(col, item);
                card.Controls.Add(descLabel);
                contentY += 18;
            }

            // Total card height gives space for the bottom action bar
            card.Height = contentY + 28;

            // Row 4: Action Row at bottom: [✔ Check] [◀] [▶]              [✎] [✕]
            Panel actionRow = new Panel
            {
                Location = new Point(8, card.Height - 24),
                Width = cardWidth - 16,
                Height = 22,
                BackColor = Color.Transparent
            };

            // Complete check toggle button
            Button btnCheck = new Button
            {
                Text = (item.IsCompleted || col.IsCompleteColumn) ? "✔" : "○",
                Size = new Size(22, 20),
                Location = new Point(0, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = (item.IsCompleted || col.IsCompleteColumn) ? Color.FromArgb(46, 204, 113) : cTextSecondary,
                Font = new Font("Segoe UI", 9.0f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCheck.FlatAppearance.BorderSize = 0;
            btnCheck.Click += (s, e) =>
            {
                item.IsCompleted = !item.IsCompleted;
                if (item.IsCompleted && !col.IsCompleteColumn)
                {
                    var completeCol = Board.Columns.FirstOrDefault(c => c.IsCompleteColumn);
                    if (completeCol != null)
                    {
                        col.Items.Remove(item);
                        completeCol.Items.Add(item);
                    }
                }
                OnBoardChanged();
                RenderBoard();
            };
            actionRow.Controls.Add(btnCheck);

            // Move Left button ◀
            int colIdx = Board.Columns.IndexOf(col);
            Button btnMoveLeft = new Button
            {
                Text = "◀",
                Size = new Size(22, 20),
                Location = new Point(24, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 6.5f),
                Cursor = Cursors.Hand,
                Enabled = colIdx > 0
            };
            btnMoveLeft.FlatAppearance.BorderSize = 0;
            btnMoveLeft.Click += (s, e) =>
            {
                if (colIdx > 0)
                {
                    MoveTaskBetweenColumns(col.Id, Board.Columns[colIdx - 1].Id, item.Id);
                }
            };
            actionRow.Controls.Add(btnMoveLeft);

            // Move Right button ▶
            Button btnMoveRight = new Button
            {
                Text = "▶",
                Size = new Size(22, 20),
                Location = new Point(48, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 6.5f),
                Cursor = Cursors.Hand,
                Enabled = colIdx < Board.Columns.Count - 1
            };
            btnMoveRight.FlatAppearance.BorderSize = 0;
            btnMoveRight.Click += (s, e) =>
            {
                if (colIdx < Board.Columns.Count - 1)
                {
                    MoveTaskBetweenColumns(col.Id, Board.Columns[colIdx + 1].Id, item.Id);
                }
            };
            actionRow.Controls.Add(btnMoveRight);

            // Edit button ✎
            Button btnEdit = new Button
            {
                Text = "✎",
                Size = new Size(22, 20),
                Location = new Point(actionRow.Width - 48, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = cTextSecondary,
                Font = new Font("Segoe UI", 8.5f),
                Cursor = Cursors.Hand
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Click += (s, e) => EditTask(col, item);
            actionRow.Controls.Add(btnEdit);

            // Delete button ✕
            Button btnDelete = new Button
            {
                Text = "✕",
                Size = new Size(22, 20),
                Location = new Point(actionRow.Width - 24, 0),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.FromArgb(231, 76, 60),
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += (s, e) =>
            {
                if (MessageBox.Show($"Delete task \"{item.Title}\"?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    col.Items.Remove(item);
                    OnBoardChanged();
                    RenderBoard();
                }
            };
            actionRow.Controls.Add(btnDelete);

            card.Controls.Add(actionRow);

            // Border and left priority strip
            card.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(cCardBorder, 1))
                {
                    e.Graphics.DrawRectangle(borderPen, 0, 0, card.Width - 1, card.Height - 1);
                }

                Color pCol = GetPriorityColor(item.Priority);
                using (SolidBrush brush = new SolidBrush(pCol))
                {
                    e.Graphics.FillRectangle(brush, 0, 0, 4, card.Height);
                }
            };

            card.DoubleClick += (s, e) => EditTask(col, item);

            // Drag-drop initiation
            card.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left && e.Clicks == 1)
                {
                    var dragData = new DragCardData { SourceColumnId = col.Id, TaskId = item.Id };
                    card.DoDragDrop(dragData, DragDropEffects.Move);
                }
            };

            return card;
        }

        private Color GetPriorityColor(string priority)
        {
            if (string.IsNullOrEmpty(priority)) return Color.FromArgb(52, 152, 219);
            switch (priority.Trim().ToLowerInvariant())
            {
                case "urgent": return Color.FromArgb(231, 76, 60);  // Red
                case "high": return Color.FromArgb(230, 126, 34);   // Orange
                case "medium": return Color.FromArgb(52, 152, 219); // Blue
                case "low": return Color.FromArgb(46, 204, 113);    // Green
                default: return Color.FromArgb(52, 152, 219);
            }
        }
        #endregion

        #region Operations & Dialogs
        private void EditTask(TodoColumn col, TodoItem item)
        {
            using (var dlg = new TodoTaskDialog(item, Board.Columns, col.Id, IsDarkMode))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (dlg.SelectedColumnId != col.Id)
                    {
                        col.Items.Remove(item);
                        var targetCol = Board.Columns.FirstOrDefault(c => c.Id == dlg.SelectedColumnId);
                        if (targetCol != null)
                        {
                            targetCol.Items.Add(dlg.TaskItem);
                        }
                        else
                        {
                            col.Items.Add(dlg.TaskItem);
                        }
                    }
                    else
                    {
                        int idx = col.Items.IndexOf(item);
                        if (idx >= 0)
                        {
                            col.Items[idx] = dlg.TaskItem;
                        }
                    }

                    OnBoardChanged();
                    RenderBoard();
                }
            }
        }

        private void MoveTaskBetweenColumns(string sourceColId, string targetColId, string taskId)
        {
            if (sourceColId == targetColId) return;

            var sourceCol = Board.Columns.FirstOrDefault(c => c.Id == sourceColId);
            var targetCol = Board.Columns.FirstOrDefault(c => c.Id == targetColId);

            if (sourceCol != null && targetCol != null)
            {
                var item = sourceCol.Items.FirstOrDefault(i => i.Id == taskId);
                if (item != null)
                {
                    sourceCol.Items.Remove(item);
                    if (targetCol.IsCompleteColumn)
                        item.IsCompleted = true;

                    targetCol.Items.Add(item);
                    OnBoardChanged();
                    RenderBoard();
                }
            }
        }

        private void MoveColumn(int oldIndex, int newIndex)
        {
            if (oldIndex < 0 || oldIndex >= Board.Columns.Count || newIndex < 0 || newIndex >= Board.Columns.Count)
                return;

            var col = Board.Columns[oldIndex];
            Board.Columns.RemoveAt(oldIndex);
            Board.Columns.Insert(newIndex, col);

            for (int i = 0; i < Board.Columns.Count; i++)
            {
                Board.Columns[i].Order = i;
            }

            OnBoardChanged();
            RenderBoard();
        }

        private void EditColumn(TodoColumn col)
        {
            using (var dlg = new TodoColumnDialog(col.Name, col.ColorHex, col.IsCompleteColumn, true, IsDarkMode))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    col.Name = dlg.ColumnName;
                    col.ColorHex = dlg.ColorHex;
                    col.IsCompleteColumn = dlg.IsCompleteColumn;
                    OnBoardChanged();
                    RenderBoard();
                }
            }
        }

        private void ShowColumnMenu(TodoColumn col, Control anchor)
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("✎ Rename & Customize", null, (s, e) => EditColumn(col));
            menu.Items.Add("+ Add Card to this column", null, (s, e) =>
            {
                using (var dlg = new TodoTaskDialog(null, Board.Columns, col.Id, IsDarkMode))
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        col.Items.Add(dlg.TaskItem);
                        OnBoardChanged();
                        RenderBoard();
                    }
                }
            });
            menu.Items.Add("🧹 Clear Completed Cards in this column", null, (s, e) =>
            {
                col.Items.RemoveAll(i => i.IsCompleted || col.IsCompleteColumn);
                OnBoardChanged();
                RenderBoard();
            });
            menu.Items.Add(new ToolStripSeparator());
            menu.Items.Add("🗑 Delete Column", null, (s, e) =>
            {
                if (Board.Columns.Count <= 1)
                {
                    MessageBox.Show("You must keep at least one column on the board.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string msg = col.Items.Count > 0
                    ? $"Column \"{col.Name}\" contains {col.Items.Count} cards. Are you sure you want to delete it?"
                    : $"Delete column \"{col.Name}\"?";

                if (MessageBox.Show(msg, "Delete Column", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Board.Columns.Remove(col);
                    OnBoardChanged();
                    RenderBoard();
                }
            });

            menu.Show(anchor, new Point(0, anchor.Height));
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string defaultColId = Board.Columns.Count > 0 ? Board.Columns[0].Id : string.Empty;
            using (var dlg = new TodoTaskDialog(null, Board.Columns, defaultColId, IsDarkMode))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var targetCol = Board.Columns.FirstOrDefault(c => c.Id == dlg.SelectedColumnId)
                                 ?? Board.Columns.FirstOrDefault();
                    if (targetCol != null)
                    {
                        targetCol.Items.Add(dlg.TaskItem);
                        OnBoardChanged();
                        RenderBoard();
                    }
                }
            }
        }

        private void BtnAddColumn_Click(object sender, EventArgs e)
        {
            using (var dlg = new TodoColumnDialog("New Column", "#3498DB", false, false, IsDarkMode))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    var newCol = new TodoColumn
                    {
                        Name = dlg.ColumnName,
                        ColorHex = dlg.ColorHex,
                        IsCompleteColumn = dlg.IsCompleteColumn,
                        Order = Board.Columns.Count
                    };
                    Board.Columns.Add(newCol);
                    OnBoardChanged();
                    RenderBoard();
                }
            }
        }

        private void BtnTemplates_Click(object sender, EventArgs e)
        {
            using (var dlg = new TodoTemplateDialog(IsDarkMode))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (Board.GetTotalTaskCount() > 0)
                    {
                        var res = MessageBox.Show(
                            "Applying a new template will replace your current columns. Do you want to proceed?",
                            "Apply Template",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (res != DialogResult.Yes) return;
                    }

                    Board = TodoBoard.CreateTemplate(dlg.SelectedTemplate);
                    OnBoardChanged();
                    RenderBoard();
                }
            }
        }

        private void BtnClearDone_Click(object sender, EventArgs e)
        {
            int completedCount = Board.GetCompletedTaskCount();
            if (completedCount == 0)
            {
                MessageBox.Show("There are no completed tasks to clear.", "No Completed Tasks", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Clear all {completedCount} completed task(s)?", "Clear Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (var col in Board.Columns)
                {
                    if (col.IsCompleteColumn)
                    {
                        col.Items.Clear();
                    }
                    else
                    {
                        col.Items.RemoveAll(i => i.IsCompleted);
                    }
                }
                OnBoardChanged();
                RenderBoard();
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                sfd.FileName = "safenotes_board.json";
                if (sfd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, Board.ToJson());
                        MessageBox.Show("Board exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error exporting board: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        string json = File.ReadAllText(ofd.FileName);
                        var importedBoard = TodoBoard.FromJson(json);
                        if (importedBoard != null && importedBoard.Columns.Count > 0)
                        {
                            Board = importedBoard;
                            OnBoardChanged();
                            RenderBoard();
                            MessageBox.Show("Board imported successfully!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error importing board: " + ex.Message, "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OnBoardChanged()
        {
            BoardChanged?.Invoke(this, EventArgs.Empty);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        private void SetWatermark(TextBox textBox, string watermarkText)
        {
            if (textBox.IsHandleCreated)
            {
                SendMessage(textBox.Handle, EM_SETCUEBANNER, 1, watermarkText);
            }
            else
            {
                textBox.HandleCreated += (s, e) =>
                {
                    SendMessage(textBox.Handle, EM_SETCUEBANNER, 1, watermarkText);
                };
            }
        }
        #endregion

        private class DragCardData
        {
            public string SourceColumnId { get; set; }
            public string TaskId { get; set; }
        }
    }
}

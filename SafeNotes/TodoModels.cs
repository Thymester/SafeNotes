// File: SafeNotes/TodoModels.cs
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SafeNotes
{
    public class TodoItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Priority { get; set; } = "Medium"; // Low, Medium, High, Urgent
        public string Tag { get; set; } = string.Empty; // e.g. "Work", "Home", "Bug", "Feature"
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsCompleted { get; set; } = false;
        public int Order { get; set; } = 0;

        public TodoItem Clone()
        {
            return new TodoItem
            {
                Id = Guid.NewGuid().ToString("N"),
                Title = this.Title,
                Description = this.Description,
                Priority = this.Priority,
                Tag = this.Tag,
                DueDate = this.DueDate,
                CreatedAt = DateTime.Now,
                IsCompleted = this.IsCompleted,
                Order = this.Order
            };
        }
    }

    public class TodoColumn
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");
        public string Name { get; set; } = "New Column";
        public string ColorHex { get; set; } = "#3498DB";
        public int Order { get; set; } = 0;
        public bool IsCompleteColumn { get; set; } = false;
        public List<TodoItem> Items { get; set; } = new List<TodoItem>();
    }

    public class TodoBoard
    {
        public string BoardName { get; set; } = "My Board";
        public List<TodoColumn> Columns { get; set; } = new List<TodoColumn>();

        public int GetTotalTaskCount()
        {
            return Columns != null ? Columns.Sum(c => c.Items != null ? c.Items.Count : 0) : 0;
        }

        public int GetCompletedTaskCount()
        {
            if (Columns == null) return 0;
            return Columns.Sum(c => c.Items != null 
                ? c.Items.Count(item => item.IsCompleted || c.IsCompleteColumn) 
                : 0);
        }

        public int GetInProgressTaskCount()
        {
            if (Columns == null) return 0;
            // Count items in non-complete columns that are not marked completed
            return Columns.Where(c => !c.IsCompleteColumn && !IsPlannedColumn(c))
                          .Sum(c => c.Items != null ? c.Items.Count(item => !item.IsCompleted) : 0);
        }

        private static bool IsPlannedColumn(TodoColumn col)
        {
            if (col == null || col.Name == null) return false;
            string n = col.Name.Trim().ToLowerInvariant();
            return n == "planned" || n == "to do" || n == "todo" || n == "backlog";
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public static TodoBoard FromJson(string json)
        {
            if (string.IsNullOrWhiteSpace(json))
                return CreateDefault();

            try
            {
                var board = JsonConvert.DeserializeObject<TodoBoard>(json);
                if (board != null && board.Columns != null && board.Columns.Count > 0)
                {
                    // Ensure all columns and items have non-null lists
                    foreach (var col in board.Columns)
                    {
                        if (col.Items == null) col.Items = new List<TodoItem>();
                    }
                    return board;
                }
            }
            catch
            {
                // Fallback to default if corrupted
            }

            return CreateDefault();
        }

        public static TodoBoard CreateDefault()
        {
            var board = new TodoBoard { BoardName = "My Tasks" };

            var colPlanned = new TodoColumn
            {
                Name = "Planned",
                ColorHex = "#4A90E2",
                Order = 0,
                IsCompleteColumn = false,
                Items = new List<TodoItem>
                {
                    new TodoItem
                    {
                        Title = "Welcome to your To-Do Board!",
                        Description = "Track your daily tasks with this Trello-style board. Move cards with the ◀ and ▶ buttons or drag and drop!",
                        Priority = "Medium",
                        Tag = "Getting Started",
                        CreatedAt = DateTime.Now
                    },
                    new TodoItem
                    {
                        Title = "Add custom columns or templates",
                        Description = "Click '+ Add Column' or 'Templates' above to adapt this board to work, home chores, or dev sprints.",
                        Priority = "Low",
                        Tag = "Tip",
                        CreatedAt = DateTime.Now
                    }
                }
            };

            var colInProgress = new TodoColumn
            {
                Name = "In Progress",
                ColorHex = "#F39C12",
                Order = 1,
                IsCompleteColumn = false,
                Items = new List<TodoItem>
                {
                    new TodoItem
                    {
                        Title = "Secure with SafeNotes encryption",
                        Description = "All your tasks and columns are AES-256 encrypted automatically when you close or lock the app.",
                        Priority = "High",
                        Tag = "Security",
                        CreatedAt = DateTime.Now
                    }
                }
            };

            var colComplete = new TodoColumn
            {
                Name = "Complete",
                ColorHex = "#2ECC71",
                Order = 2,
                IsCompleteColumn = true,
                Items = new List<TodoItem>
                {
                    new TodoItem
                    {
                        Title = "Set up your SafeNotes account",
                        Description = "SafeNotes account created and ready.",
                        Priority = "Low",
                        Tag = "Setup",
                        IsCompleted = true,
                        CreatedAt = DateTime.Now
                    }
                }
            };

            board.Columns.Add(colPlanned);
            board.Columns.Add(colInProgress);
            board.Columns.Add(colComplete);

            return board;
        }

        public static TodoBoard CreateTemplate(string templateName)
        {
            var board = new TodoBoard();

            switch (templateName)
            {
                case "Personal / Daily Life":
                    board.BoardName = "Personal & Daily Tasks";
                    board.Columns.Add(new TodoColumn { Name = "To Do Today", ColorHex = "#E74C3C", Order = 0 });
                    board.Columns.Add(new TodoColumn { Name = "This Week", ColorHex = "#F39C12", Order = 1 });
                    board.Columns.Add(new TodoColumn { Name = "In Progress", ColorHex = "#3498DB", Order = 2 });
                    board.Columns.Add(new TodoColumn { Name = "Done", ColorHex = "#2ECC71", Order = 3, IsCompleteColumn = true });
                    break;

                case "Software Development":
                    board.BoardName = "Dev Sprint";
                    board.Columns.Add(new TodoColumn { Name = "Backlog", ColorHex = "#95A5A6", Order = 0 });
                    board.Columns.Add(new TodoColumn { Name = "In Progress", ColorHex = "#3498DB", Order = 1 });
                    board.Columns.Add(new TodoColumn { Name = "Code Review", ColorHex = "#9B59B6", Order = 2 });
                    board.Columns.Add(new TodoColumn { Name = "QA / Testing", ColorHex = "#E67E22", Order = 3 });
                    board.Columns.Add(new TodoColumn { Name = "Deployed", ColorHex = "#2ECC71", Order = 4, IsCompleteColumn = true });
                    break;

                case "Shopping & Errands":
                    board.BoardName = "Shopping & Errands";
                    board.Columns.Add(new TodoColumn { Name = "To Buy / Errands", ColorHex = "#E67E22", Order = 0 });
                    board.Columns.Add(new TodoColumn { Name = "At the Store", ColorHex = "#3498DB", Order = 1 });
                    board.Columns.Add(new TodoColumn { Name = "Purchased / Done", ColorHex = "#2ECC71", Order = 2, IsCompleteColumn = true });
                    break;

                case "Goal & Project Tracker":
                    board.BoardName = "Project Roadmap";
                    board.Columns.Add(new TodoColumn { Name = "Ideas & Planned", ColorHex = "#1ABC9C", Order = 0 });
                    board.Columns.Add(new TodoColumn { Name = "Milestone 1", ColorHex = "#3498DB", Order = 1 });
                    board.Columns.Add(new TodoColumn { Name = "Milestone 2", ColorHex = "#9B59B6", Order = 2 });
                    board.Columns.Add(new TodoColumn { Name = "Completed", ColorHex = "#2ECC71", Order = 3, IsCompleteColumn = true });
                    break;

                default:
                    return CreateDefault();
            }

            return board;
        }
    }
}

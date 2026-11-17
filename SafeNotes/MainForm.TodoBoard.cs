// File: SafeNotes/MainForm.TodoBoard.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace SafeNotes
{
    public partial class MainForm
    {
        public void InitializeTodoBoard()
        {
            if (TodoBoardCtrl == null) return;

            TodoBoardCtrl.BoardChanged += (s, e) =>
            {
                SaveTodoBoard();
            };

            UpdateTodoBoardTheme();
            LoadTodoBoardData();
        }

        public void LoadTodoBoardData()
        {
            if (TodoBoardCtrl == null) return;

            try
            {
                // If user has a password but is not logged in, keep board cleared for privacy/security
                if (_settings != null && !_settings.IsUserLoggedIn && !string.IsNullOrWhiteSpace(_settings.UserPassword))
                {
                    TodoBoardCtrl.LoadBoard(new TodoBoard());
                    return;
                }

                if (!string.IsNullOrWhiteSpace(_settings?.TodoBoardData))
                {
                    string rawData = _settings.TodoBoardData;
                    string json = null;

                    // If encrypted, attempt decrypt
                    if (securePassword != null && securePassword.Length > 0)
                    {
                        try
                        {
                            json = DecryptString(rawData, ConvertToUnsecureString(securePassword));
                        }
                        catch
                        {
                            json = null;
                        }
                    }

                    // If decryption wasn't needed (legacy plaintext JSON before encryption)
                    if (string.IsNullOrWhiteSpace(json) && rawData.TrimStart().StartsWith("{"))
                    {
                        json = rawData;
                    }

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var loadedBoard = TodoBoard.FromJson(json);
                        if (loadedBoard != null && loadedBoard.Columns != null && loadedBoard.Columns.Count > 0)
                        {
                            TodoBoardCtrl.LoadBoard(loadedBoard);

                            // Migrate legacy plaintext to AES-256 encrypted storage if user is logged in
                            if (rawData.TrimStart().StartsWith("{") && securePassword != null && securePassword.Length > 0)
                            {
                                SaveTodoBoard();
                            }
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error loading todo board: " + ex.Message);
            }

            // Only create default board if user is logged in or doesn't have an account password
            if (_settings != null && (_settings.IsUserLoggedIn || string.IsNullOrWhiteSpace(_settings.UserPassword)))
            {
                TodoBoardCtrl.LoadBoard(TodoBoard.CreateDefault());
                SaveTodoBoard();
            }
            else
            {
                TodoBoardCtrl.LoadBoard(new TodoBoard());
            }
        }

        public void SaveTodoBoard()
        {
            if (TodoBoardCtrl == null || TodoBoardCtrl.Board == null || _settings == null) return;

            try
            {
                // If user is registered but not logged in, do not save or overwrite
                if (!_settings.IsUserLoggedIn && !string.IsNullOrWhiteSpace(_settings.UserPassword))
                {
                    return;
                }

                string json = TodoBoardCtrl.Board.ToJson();

                // Encrypt board if user is logged in and password is in memory
                if (securePassword != null && securePassword.Length > 0)
                {
                    string encrypted = EncryptString(json, ConvertToUnsecureString(securePassword));
                    _settings.TodoBoardData = encrypted ?? json;
                }
                else if (string.IsNullOrWhiteSpace(_settings.UserPassword))
                {
                    // No password protection enabled
                    _settings.TodoBoardData = json;
                }

                SettingsManager.SaveSettings(_settings);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving todo board: " + ex.Message);
            }
        }

        public void UpdateTodoBoardTheme()
        {
            if (TodoBoardCtrl == null) return;
            bool isDark = _settings == null || !_settings.LightMode;
            TodoBoardCtrl.ApplyTheme(isDark);
        }
    }
}

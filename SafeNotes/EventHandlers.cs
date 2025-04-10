using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System;

public class EventHandlerClass
{

    public async Task CheckForUpdatesAsync()
    {
        string repo = "Thymester/SafeNotes";
        string currentVersion = Application.ProductVersion;

        // Normalize the current version (remove "v" if exists)
        Version currentAppVersion = new Version(currentVersion.TrimStart('v'));

        using (var http = new HttpClient())
        {
            http.DefaultRequestHeaders.UserAgent.ParseAdd("SafeNotesUpdater/1.0");

            try
            {
                // Fetch release info from GitHub
                var json = await http.GetStringAsync($"https://api.github.com/repos/{repo}/releases/latest");
                var release = JObject.Parse(json);

                string latestVersionString = release["tag_name"].ToString().TrimStart('v');
                Version latestVersion = new Version(latestVersionString);

                // Compare version numbers using the Version class
                if (latestVersion > currentAppVersion)
                {
                    var asset = release["assets"]?[0]?["browser_download_url"]?.ToString();

                    // Ensure that the asset is an .exe file
                    if (asset != null && asset.EndsWith(".exe"))
                    {
                        var result = MessageBox.Show(
                            $"A new version ({latestVersion}) is available! Do you want to update now?",
                            "Update Available",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information
                        );

                        if (result == DialogResult.Yes)
                        {
                            string tempExePath = Path.Combine(Path.GetTempPath(), "SafeNotes_New.exe");
                            string batFilePath = Path.Combine(Path.GetTempPath(), "SafeNotes_Updater.bat");
                            string currentExePath = Application.ExecutablePath;
                            string logPath = Path.Combine(Path.GetTempPath(), "SafeNotes_UpdateLog.txt");

                            // Download the update file (ensure it's an .exe)
                            using (var stream = await http.GetStreamAsync(asset))
                            using (var fs = new FileStream(tempExePath, FileMode.Create))
                            {
                                await stream.CopyToAsync(fs);
                            }

                            // Check if the file is a valid .exe (not corrupted)
                            if (Path.GetExtension(tempExePath).ToLower() != ".exe" || new FileInfo(tempExePath).Length < 10000)
                            {
                                MessageBox.Show("Downloaded file is invalid or too small.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Write the batch file for replacing the old version
                            File.WriteAllText(batFilePath, $@"
                        @echo off
                        echo Update starting >> ""{logPath}""
                        timeout /t 2 /nobreak > nul
                        del /f /q ""{currentExePath}"" >> ""{logPath}"" 2>&1
                        move /y ""{tempExePath}"" ""{currentExePath}"" >> ""{logPath}"" 2>&1
                        start ""SafeNotes"" ""{currentExePath}""
                        echo Update complete >> ""{logPath}""
                        ");

                            // Launch the batch file to replace the app
                            Process.Start(new ProcessStartInfo
                            {
                                FileName = "cmd.exe",
                                Arguments = $"/C \"\"{batFilePath}\"\"",
                                CreateNoWindow = true,
                                UseShellExecute = false
                            });

                            // Exit the app before the new version runs
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: The downloaded file is not an executable (.exe).", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking for updates: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

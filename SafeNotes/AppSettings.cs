public class AppSettings
{
    public string UserPassword { get; set; } = string.Empty;
    public string YourName { get; set; } = string.Empty;
    public string EntryText { get; set; } = string.Empty;
    public string NotepadSaveText { get; set; } = string.Empty;
    public bool SaveDate { get; set; } = false;
    public bool DisableNotifications { get; set; } = false;
    public bool LightMode { get; set; } = false;
    public bool IsUserLoggedIn { get; set; } = false;
    public bool FirstTimeOpened { get; set; } = true;
    public bool RequirePinCode { get; set; } = false;
    public string PinCode { get; set; } = string.Empty;
    public string Entries { get; set; } = string.Empty;
    public bool IsRestartingForUpdate { get; set; } = false;
}

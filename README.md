# SafeNotes

SafeNotes is an encrypted and user-friendly note-taking application designed to keep your personal notes and journal entries safe and organized. With SafeNotes, you can easily create, edit, and manage your notes, all while ensuring your data is protected through robust AES-256 encryption and password hashing. The app features a sleek and intuitive interface built with MaterialSkin, offering light and dark themes to suit your preferences.

SafeNotes is perfect for anyone looking to keep their notes and journal entries secure and organized. Download SafeNotes today and experience the peace of mind of knowing your personal information is safe.

## Features

**For a list of all features, visit [SafeNotes Website](https://safenotes.space/).**

1. **Automatic Version Control**: SafeNotes automatically checks for updates with every launch. It will then prompt you to update if you are out of date with every launch, and I understand that can be unpleasant, but our goal is for people to update to the newest versions, so that was intended.
2. **Encryption and Hashing:** SafeNotes will encrypt entries on closure and decrypt entries when the user logs into SafeNotes. All of this secured behind password authentication which is protected via hashing so nothing is ever stored in plain text.
3. **Password Verification**: Users must log in with a password to access their notes, ensuring privacy and security.
4. **Password Generator**: Easily create strong and unique passwords with the built-in password generator.
5. **Password Manager Detection**: Detects if a password manager is installed, providing an additional layer of security.
6. **Journal with Entry Saving**: Keep track of your thoughts, ideas, and experiences with the journal feature, and save entries securely.
7. **Custom User Names**: Personalize your SafeNotes experience by setting your own user name.
8. **Notepad with File Saving and Opening**: Use the notepad feature to jot down quick notes, and save and open files as needed.
9. **Journal Entries**: Organize your thoughts with journal entries, applying dates by default for easy reference.
10. **Entry Editing**: Edit your journal entries for accuracy and clarity, ensuring your notes are always up to date.
11. **Dark Mode by Default**: Protect your eyes and reduce screen glare with the default dark mode interface.
12. **Light Mode**: Switch to light mode for a different visual experience, catering to your preferences.
13. **Reset Account Info/Password**: Easily reset your account information or password if needed, ensuring continued access to your notes.
14. **Reset Login Status**: Reset your login status to ensure security if you suspect unauthorized access to your account.

## Usage

1. **Login**: Enter your password to access your notes.
2. **Journal**: Record your thoughts, ideas, and experiences in the journal.
3. **Notepad**: Use the notepad for quick notes and file saving.
4. **Settings**: Customize your SafeNotes experience, including dark or light mode preferences.
5. **Password Management**: Update your password or reset account information as needed.

## Contributing

We welcome contributions from the community to improve SafeNotes. If you have any suggestions, bug reports, or feature requests, please feel free to open an issue or submit a pull request on GitHub.

# SafeNotes UI Elements and Variable Reference

This page documents the main UI elements, variable names, and their purpose/locations in the SafeNotes app (`AppManager.cs` and related files). Use this as a reference for contributing, refactoring, or updating the app.

---

## Core Controls & Elements

| Variable Name              | Type / Control     | Purpose / Description                                                                                         | Main Location (File/Class)         |
|----------------------------|--------------------|---------------------------------------------------------------------------------------------------------------|------------------------------------|
| **EntriesListBox**         | ListView/ListBox   | Displays user's journal entries. Supports add, edit, delete, select, double-click for delete.                 | `AppManager.cs`, `MainForm`        |
| **JournalEntryBox**        | TextBox            | For entering/editing a journal entry. Used in journal tab.                                                    | `AppManager.cs`, `MainForm`        |
| **NotepadTextBox**         | TextBox            | The notepad area for freeform note-taking and file saving.                                                    | `AppManager.cs`, `MainForm`        |
| **NotepadTitle**           | Label              | Shows the title or opened file name for the notepad.                                                          | `AppManager.cs`, `MainForm`        |
| **SavedEntriesCount**      | Label              | Displays the number of saved entries.                                                                         | `AppManager.cs`                    |
| **CharsInNotepad**         | Label              | Shows character count in the notepad.                                                                         | `AppManager.cs`                    |
| **ColumnInNotepad**        | Label              | Shows line/column count in notepad.                                                                           | `AppManager.cs`                    |
| **UserPassword**           | TextBox            | Password input for user authentication and registration.                                                      | `AppManager.cs`                    |
| **UserConfirmPassword**    | TextBox            | Password confirmation input during registration/reset.                                                        | `AppManager.cs`                    |
| **UserPINCodeField**       | TextBox            | PIN code field for extra login security if enabled.                                                           | `AppManager.cs`                    |
| **YourNameBox**            | TextBox            | Stores/edits user's display name.                                                                             | `AppManager.cs`                    |
| **PasswordGenBox**         | TextBox            | Displays generated passwords (for password generation feature).                                                | `AppManager.cs`                    |
| **PasswordStrength**       | Label              | Shows password strength and estimated time to crack.                                                          | `AppManager.cs`                    |
| **PasswordCopiedLabel**    | Label              | Notification for password copy action.                                                                        | `AppManager.cs`                    |
| **TabControl**             | TabControl         | Hosts major tabs (Journal, Notepad, etc).                                                                     | `AppManager.cs`                    |
| **JournalTabSelector**     | TabControl/Tab     | Used to control which journal/notepad/settings sub-tab is active.                                             | `AppManager.cs`                    |
| **LeftSettingsNav**        | TreeView           | Navigation tree for settings.                                                                                 | `AppManager.cs`                    |
| **SettingsInfoLabel**      | Label              | Shows extra info/explanations in settings view.                                                               | `AppManager.cs`                    |
| **DecryptionStatusLabel**  | Label              | Status label shown during encryption/decryption actions.                                                      | `AppManager.cs`                    |
| **LoginTabSelector**       | TabControl/Tab     | Login/registration tab; controls visibility depending on login state.                                         | `AppManager.cs`                    |
| **LoginPage**              | TabPage            | Login/register interface.                                                                                     | `AppManager.cs`                    |

---

## Buttons & Actions

| Variable Name              | Type / Control     | Purpose / Description                                                                                         |
|----------------------------|--------------------|---------------------------------------------------------------------------------------------------------------|
| **SaveEntryButton**        | Button             | Saves a new or edited journal entry.                                                                          |
| **EditEntryButton**        | Button             | Initiates editing for the selected journal entry.                                                             |
| **DeleteEntriesButton**    | Button             | Deletes all entries from the journal.                                                                         |
| **EncryptEntriesButton**   | Button             | Encrypts all entries ("Lockdown mode").                                                                       |
| **ImportEntriesButton**    | Button             | Imports entries from a file.                                                                                  |
| **ExportEntriesButton**    | Button             | Exports entries to a file.                                                                                    |
| **ChangeNameButton**       | Button             | Saves or enables editing of your name.                                                                        |
| **RegenPassButton**        | Button             | Generates a random secure password in the password generator.                                                 |
| **UsePassButton**          | Button             | Applies generated password to the input fields.                                                               |
| **OpenFileButton**         | Button             | Opens a text file into notepad.                                                                               |
| **SaveNotepadButton**      | Button             | Saves the notepad contents to a file.                                                                         |
| **ClearNotepadButton**     | Button             | Clears the notepad contents.                                                                                  |
| **ResetAccountCheckbox**   | CheckBox           | Triggers account reset (clears all user data).                                                                |
| **ResetLoginStatusButton** | Button             | Resets login status (forces re-login).                                                                        |
| **ApplyDateCheckbox**      | CheckBox           | If checked, applies date/time to entries.                                                                     |
| **LightModeCheckbox**      | CheckBox           | Toggles light/dark mode.                                                                                      |
| **DisableNotificationsCheckbox** | CheckBox      | Turns off notification popups.                                                                                |
| **RequirePinToLogin**      | CheckBox           | Enables/disables PIN code for login.                                                                          |

---

## Timers and Miscellaneous

| Variable Name              | Type / Control     | Purpose / Description                                                   |
|----------------------------|--------------------|-------------------------------------------------------------------------|
| **LabelVisibilityTimer**   | Timer              | Used to hide password copied label after a short interval.               |
| **CheckTimer**             | Timer              | Checks and updates UI state based on entries and password fields.        |

---

## Where to Find These

- **All of the above are declared and used in `SafeNotes/AppManager.cs` as fields or within the `MainForm` class.**
- Most are manipulated via event handlers (e.g., `SaveEntryButton_Click`, `EditEntryButton_Click`, etc.).
- Some are also referenced in settings logic, form load, and UI state update methods.

---

## How to Add or Change UI Logic

- **UI elements are mostly referenced by their variable name in event handler methods.**
- To add new logic, locate the relevant event handler (e.g., `SaveEntryButton_Click` for saving entries) and update logic there.
- To change UI appearance or state, update the element’s properties in form initialization or in the appropriate event.
- For new UI elements, add them in the WinForms Designer, then handle their events in `AppManager.cs`.

---

## Example: Editing a Journal Entry

1. Select an entry in `EntriesListBox`.
2. Click `EditEntryButton` (calls `EditEntryButton_Click`).
3. The selected entry text is loaded into `JournalEntryBox`.
4. Edit and click `SaveEntryButton` to save changes.

---

## Example: Generating a Password

1. Click `RegenPassButton` to generate a new password.
2. The password appears in `PasswordGenBox`.
3. Click `UsePassButton` to copy the password to input fields.

---

> For further detail on any control, check the corresponding event handler in `AppManager.cs` or search for the variable name in the file.

---

*Last updated: 2025-09-07*

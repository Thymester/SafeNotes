// File: SafeNotes/mainForm.cs
using MaterialSkin;
using MaterialSkin.Controls;

namespace SafeNotes
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            // Sets the default theme to dark, the theme will not be set if the lightModeCheckbox is checked
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}

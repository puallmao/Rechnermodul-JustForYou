using Rechnermodul.Utils.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rechnermodul.Utils.Shared.ThemeManager;

namespace Rechnermodul.Utils.Shared.View
{
    public partial class FRM_Settings : Form
    {
        public FRM_Settings()
        {
            InitializeComponent();
            SettingsManager.SettingsChanged += SettingsChanged;
            SettingsManager.ApplySettingsToForm(this);
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            // Change settings
            SettingsManager.ApplySettingsToForm(this);
        }

        private void BTN_save_Click(object sender, EventArgs e)
        {
            Theme theme = Themes.WhiteMode;
            switch (CB_theme.Text)
            {
                case "WhiteMode":
                    theme = Themes.WhiteMode;
                    break;
                case "DarkMode":
                    theme = Themes.DarkMode;
                    break;
                case "FrogMode":
                    theme = Themes.FrogMode;
                    break;
            }
            SettingsManager.Change(new Font(CB_fontFamily.Text, float.Parse(CB_fontSize.Text.Split(' ')[0])), theme);
            this.Close();
        }

        private void BTN_abort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

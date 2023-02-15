using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechnermodul.Utils.src.Shared
{
    public static class Settings
    {
        public class SettingsChangedArgs : EventArgs
        {
            public Font FontNormalText;
            public Font FontHeaderText;
            public Color FontColor;
            public Color BackgroundColor;

            public SettingsChangedArgs(Font fontNormalText, Font fontHeaderText, Color fontColor, Color backgroundColor)
            {
                FontNormalText = fontNormalText;
                FontHeaderText = fontHeaderText;
                FontColor = fontColor;
                BackgroundColor = backgroundColor;
            }
        }

        private static Font FontNormalText;
        private static Font FontHeaderText;
        public static EventHandler<SettingsChangedArgs> SettingsChanged;

        public static void ApplyDefault()
        {
            FontNormalText = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
            FontHeaderText = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            SettingsChanged(null, new SettingsChangedArgs(FontNormalText, FontHeaderText, ThemeManager.Themes.WhiteMode.FontColor, ThemeManager.Themes.WhiteMode.BackgroundColor));
        }

        public static void Change(Font font, ThemeManager.Theme theme)
        {
            FontNormalText = new Font(font.FontFamily, font.Size, FontStyle.Regular);
            FontHeaderText = new Font(font.FontFamily, font.Size + 1.75f, FontStyle.Bold);
            SettingsChanged(null, new SettingsChangedArgs(FontNormalText, FontHeaderText, theme.FontColor, theme.BackgroundColor));
        }

        public static void ApplySettingsToForm(object sender, SettingsChangedArgs data)
        {
            if (sender is Form) { ((Form)sender).BackColor = data.BackgroundColor; }
            foreach (Control control in ((Control)sender).Controls)
            {
                control.BackColor = data.BackgroundColor;
                control.ForeColor = data.FontColor;
                control.Font = data.FontNormalText;
                if (control is GroupBox || control is UserControl)
                {
                    sender = control;
                    ApplySettingsToForm(sender, data);
                }
            }
        }

        public static void SaveToJon()
        {
            throw new NotImplementedException();
        }

        public static void Load()
        {
            throw new NotImplementedException();
        }
    }
}

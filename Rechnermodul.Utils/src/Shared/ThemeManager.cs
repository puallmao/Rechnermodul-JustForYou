using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Utils.Shared
{
    public class ThemeManager
    {
        public class Theme
        {
            public Color FontColor { get; set; }
            public Color BackgroundColor { get; set; }

            public Theme()
            {
                FontColor = SystemColors.ControlText;
                BackgroundColor = SystemColors.Control;
            }

            public Theme(Color fontColor, Color backgroundColor)
            {
                FontColor = fontColor;
                BackgroundColor = backgroundColor;
            }
        }

        public static class Themes
        {
            public static readonly Theme WhiteMode = new Theme(SystemColors.ControlText, SystemColors.Control);
            public static readonly Theme DarkMode = new Theme(SystemColors.ControlLightLight, Color.FromArgb(255, 32, 33, 36));
            public static readonly Theme FrogMode = new Theme(SystemColors.ControlText, Color.Lime);
        }
    }
}

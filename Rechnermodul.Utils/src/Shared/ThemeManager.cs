﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnermodul.Utils.src.Shared
{
    public class ThemeManager
    {
        public class Theme
        {
            public Color FontColor;
            public Color BackgroundColor;
            public Theme(Color fontColor, Color backgroundColor)
            {
                FontColor = fontColor;
                BackgroundColor = backgroundColor;
            }
        }

        public static class Themes
        {
            public static readonly Theme WhiteMode = new Theme(default(Color), default(Color));
            public static readonly Theme DarkMode = new Theme(SystemColors.ControlLightLight, SystemColors.Desktop);
            public static readonly Theme FrogMode = new Theme(SystemColors.ControlText, Color.Lime);
        }
    }
}

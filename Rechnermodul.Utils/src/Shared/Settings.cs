using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Rechnermodul.Utils.Shared.ThemeManager;

namespace Rechnermodul.Utils.Shared
{
    /// <summary>
    /// Settings
    /// </summary>
    public class Settings
    {
        public FontSerializable FontNormalText { get; set; }
        public FontSerializable FontHeaderText { get; set; }
        public Theme Theme { get; set; }

        public Settings()
        {
            FontNormalText = FontSerializable.FromFont(new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular));
            FontHeaderText = FontSerializable.FromFont(new Font("Microsoft Sans Serif", 10, FontStyle.Bold));
            Theme = new Theme(Themes.WhiteMode.FontColor, Themes.WhiteMode.BackgroundColor);
        }
    }

    /// <summary>
    /// Manages the custom application settings
    /// </summary>
    public static class SettingsManager
    {
        private static readonly string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Rechnermodul-JustForYou";
        private static readonly string FileName = "Rechnermodul-JustForYou-Settings.dat";

        public static Settings settings = new Settings();
        public static EventHandler SettingsChanged;

        public static void ApplyDefault()
        {
            settings.FontNormalText = FontSerializable.FromFont(new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular));
            settings.FontHeaderText = FontSerializable.FromFont(new Font("Microsoft Sans Serif", 10, FontStyle.Bold));
            settings.Theme = new Theme(Themes.WhiteMode.FontColor, Themes.WhiteMode.BackgroundColor);
            SettingsChanged(null, null);
        }

        public static void Change(Font font, ThemeManager.Theme theme)
        {
            settings.FontNormalText = FontSerializable.FromFont(new Font(font.FontFamily, font.Size, FontStyle.Regular));
            settings.FontHeaderText = FontSerializable.FromFont(new Font(font.FontFamily, font.Size + 1.75f, FontStyle.Bold));
            settings.Theme = new Theme(theme.FontColor, theme.BackgroundColor);
            Save();
            SettingsChanged(null, null);
        }

        public static void ApplySettingsToForm(object sender)
        {
            if (sender is Form) { ((Form)sender).BackColor = settings.Theme.BackgroundColor; }
            foreach (Control control in ((Control)sender).Controls)
            {
                control.BackColor = settings.Theme.BackgroundColor;
                control.ForeColor = settings.Theme.FontColor;
                control.Font = settings.FontNormalText.ToFont();
                if (control is GroupBox || control is UserControl)
                {
                    sender = control;
                    ApplySettingsToForm(sender);
                }
            }
        }

        public static void Save()
        {
            string data = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonColorConverter() } });
            if (string.IsNullOrEmpty(data)) return;

            DirectoryInfo dir = new DirectoryInfo(AppDataPath);
            if (!dir.Exists) { dir.Create(); }

            string path = AppDataPath + "\\" + FileName;
            FileInfo file = new FileInfo(path);
            if (file.Exists) { file.Delete(); }
            File.WriteAllText(path, data);
        }

        public static void Load()
        {
            DirectoryInfo dir = new DirectoryInfo(AppDataPath);
            if (dir.Exists)
            {
                string path = AppDataPath + "\\" + FileName;
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    try
                    {
                        settings = JsonSerializer.Deserialize<Settings>(File.ReadAllText(path), new JsonSerializerOptions { WriteIndented = true, Converters = { new JsonColorConverter() } });
                        SettingsChanged(null, null);
                    }
                    catch { }
                }
            }
        }
    }
}

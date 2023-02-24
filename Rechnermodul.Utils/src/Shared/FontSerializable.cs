using System.Drawing;

namespace Rechnermodul.Utils.Shared
{
    public class FontSerializable
    {
        public string FontFamily { get; set; }
        public GraphicsUnit GraphicsUnit { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }

        public FontSerializable() { }

        public FontSerializable(Font f)
        {
            FontFamily = f.FontFamily.Name;
            GraphicsUnit = f.Unit;
            Size = f.Size;
            Style = f.Style;
        }

        public static FontSerializable FromFont(Font f)
        {
            return new FontSerializable(f);
        }

        public Font ToFont()
        {
            return new Font(FontFamily, Size, Style, GraphicsUnit);
        }
    }
}

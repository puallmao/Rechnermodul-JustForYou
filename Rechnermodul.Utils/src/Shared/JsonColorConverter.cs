using System;
using System.Drawing;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Rechnermodul.Utils.Shared
{
    /// <summary>
    /// JSON Converter for the DataType Color
    /// Allows for the Serialization of colors
    /// </summary>
    public class JsonColorConverter : JsonConverter<Color>
    {
        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToArgb().ToString());
        }

        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return Color.FromArgb(int.Parse(reader.GetString()));
        }
    }
}

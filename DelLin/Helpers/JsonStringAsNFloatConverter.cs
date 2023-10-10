using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class JsonStringAsNFloatConverter : JsonConverter<float?>
    {
        public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            var styles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            if (float.TryParse(s, styles, CultureInfo.InvariantCulture, out float result))
                return result;

            return null;
        }

        public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }
}

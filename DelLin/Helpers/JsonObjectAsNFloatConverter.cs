using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class JsonObjectAsNFloatConverter : JsonConverter<float?>
    {
        public override float? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var s = reader.GetString();
                    var style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                    if (float.TryParse(s, style, CultureInfo.InvariantCulture, out float result))
                        return result;
                    break;

                case JsonTokenType.Number:
                    return reader.GetSingle();

                case JsonTokenType.Null:
                    return null;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, float? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }
}

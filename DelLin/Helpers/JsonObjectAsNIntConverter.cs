using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class JsonObjectAsNIntConverter : JsonConverter<int?>
    {
        public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                    var s = reader.GetString();
                    var style = NumberStyles.Number;
                    if (int.TryParse(s, style, CultureInfo.InvariantCulture, out int result))
                        return result;
                    break;

                case JsonTokenType.Number:
                    return reader.GetInt32();

                case JsonTokenType.Null:
                    return null;
                default:
                    break;
            }
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
        {
            if(value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }
}

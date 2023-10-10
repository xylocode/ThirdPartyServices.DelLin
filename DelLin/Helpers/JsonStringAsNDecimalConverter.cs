using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class JsonStringAsNDecimalConverter : JsonConverter<decimal?>
    {
        public override decimal? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var s = reader.GetString();
            var styles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            if (decimal.TryParse(s, styles, CultureInfo.InvariantCulture, out decimal result))
                return result;

            return null;
        }

        public override void Write(Utf8JsonWriter writer, decimal? value, JsonSerializerOptions options)
        {
            if (value.HasValue)
                writer.WriteNumberValue(value.Value);
        }
    }
}

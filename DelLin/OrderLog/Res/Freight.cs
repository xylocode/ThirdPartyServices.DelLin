using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Информация о грузе
    /// </summary>
    public class Freight
    {
        /// <summary>
        /// Характер груза.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Вес груза, кг.
        /// </summary>
        [JsonPropertyName("weight")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? Weight { get; set; }


        /// <summary>
        /// Вес негабаритных грузовых мест, кг.
        /// </summary>
        [JsonPropertyName("oversizedWeight")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? OversizedWeight { get; set; }


        /// <summary>
        /// Объем груза, м3.
        /// </summary>
        [JsonPropertyName("volume")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? Volume { get; set; }


        /// <summary>
        /// Объем негабаритных грузовых мест, м3.
        /// </summary>
        [JsonPropertyName("oversizedVolume")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? OversizedVolume { get; set; }


        /// <summary>
        /// Количество грузовых мест.
        /// </summary>
        [JsonPropertyName("places")]
        [JsonConverter(typeof(JsonObjectAsNIntConverter))]
        public int? Places { get; set; }


        /// <summary>
        /// Количество негабаритных грузовых мест.
        /// </summary>
        [JsonPropertyName("oversizedPlaces")]
        public int? OversizedPlaces { get; set; }


        /// <summary>
        /// Длина груза, м.
        /// </summary>
        [JsonPropertyName("length")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? Length { get; set; }


        /// <summary>
        /// Ширина груза, м.
        /// </summary>
        [JsonPropertyName("width")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? Width { get; set; }


        /// <summary>
        /// Высота груза, м.
        /// </summary>
        [JsonPropertyName("height")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? Height { get; set; }

        [JsonPropertyName("maxLength")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? MaxLength { get; set; }

        [JsonPropertyName("maxWidth")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? MaxWidth { get; set; }

        [JsonPropertyName("maxHeight")]
        [JsonConverter(typeof(JsonObjectAsNFloatConverter))]
        public float? MaxHeight { get; set; }
    }
}
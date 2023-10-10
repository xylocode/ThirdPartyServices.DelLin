using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    /// <summary>
    /// Терминал на карте
    /// </summary>
    public class Maps
    {
        /// <summary>
        /// Ширина изображения с картой.
        /// </summary>
        [JsonPropertyName("width")]
        public Dictionary<int, WidthValue> Width { get; set; }
    }


    /// <summary>
    /// Ширина изображения с картой.
    /// </summary>
    public class WidthValue
    {
        /// <summary>
        /// Высота изображения с картой.
        /// </summary>
        [JsonPropertyName("height")]
        public Dictionary<int, HeightValue> Height { get; set; }
    }


    /// <summary>
    /// Высота изображения с картой.
    /// </summary>
    public class HeightValue
    {
        /// <summary>
        /// Ссылка на изображение с картой.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}

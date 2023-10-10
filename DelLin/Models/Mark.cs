using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Для справочника этикеток
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// Идентификатор знака.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Размер этикетки.
        /// Возможные значения: 80x50, a4
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }


        /// <summary>
        /// MIME-тип файла.
        /// Возможные значения: image/jpeg, application/pdf, image/png
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }


        /// <summary>
        /// Base64-код файла, содержащего этикетку
        /// </summary>
        [JsonPropertyName("base64")]
        public string Base64 { get; set; }
    }
}

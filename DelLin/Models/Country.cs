using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Страна
    /// </summary>
    public class Country
    {
        /// <summary>
        /// UID страны
        /// </summary>
        [JsonPropertyName("countryUID")]
        public string UID { get; set; }

        /// <summary>
        /// Наименование страны
        /// </summary>
        [JsonPropertyName("country")]
        public string Name { get; set; }
    }
}

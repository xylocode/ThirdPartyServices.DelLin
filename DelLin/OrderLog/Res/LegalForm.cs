using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Организационно-правовая форма.
    /// </summary>
    public class LegalForm
    {
        /// <summary>
        /// Сокращённое наименование ОПФ.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Полное наименование ОПФ.
        /// </summary>
        [JsonPropertyName("fullName")]
        public string FullName { get; set; }


        /// <summary>
        /// Код страны.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public int? CountryCode { get; set; }

    }
}
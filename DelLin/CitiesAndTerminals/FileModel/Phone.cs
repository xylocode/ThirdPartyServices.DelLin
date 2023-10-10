using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class Phone
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// Тип телефонного номера.
        /// Возможные значения:
        /// "городской";
        /// "мобильный"
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }


        /// <summary>
        /// Комментарий.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }


        /// <summary>
        /// Признак основного номера
        /// </summary>
        [JsonPropertyName("primary")]
        public bool? Primary { get; set; }
    }
}

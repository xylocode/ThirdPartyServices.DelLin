using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Универсальный справочник
    /// </summary>
    public class BaseItem
    {
        /// <summary>
        /// UID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }


        /// <summary>
        /// Полное наименование
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Краткое наименование
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }


        /// <summary>
        /// UID видов, несовместимых с видом, UID которого передан в параметре "data.uid"
        /// </summary>
        [JsonPropertyName("incompatible")]
        public List<string> Incompatible { get; set; }
    }
}

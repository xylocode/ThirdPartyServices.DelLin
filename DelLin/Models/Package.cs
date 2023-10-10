using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    public class Package : BaseItem
    {
        /// <summary>
        /// Флаг, обозначающий, что можно заказать несколько единиц упаковки
        /// </summary>
        [JsonPropertyName("countable")]
        public bool? Countable {  get; set; }
    }
}

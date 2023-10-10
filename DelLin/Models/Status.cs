using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    /// <summary>
    /// Справочник статусов заказа груза
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Статус заказа.
        /// </summary>
        [JsonPropertyName("uid")]
        public string UID {  get; set; }


        /// <summary>
        /// Наименование статуса заказа на русском языке.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title {  get; set; }


        [JsonPropertyName ("name")]
        public string Name { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Информация по заявке на доставку до адреса получателя.
    /// </summary>
    public class Sfrequest
    {
        /// <summary>
        /// ID города доставки, см. метод "Поиск населённых пунктов".
        /// </summary>
        [JsonPropertyName("cityID")]
        public int? CityID { get; set; }


        /// <summary>
        /// Номер накладной доставки.
        /// </summary>
        [JsonPropertyName("docNumber")]
        public string DocNumber { get; set; }


        /// <summary>
        /// Стоимость доставки.
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }
    }
}

using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Информация о доставке авиатранспортом.
    /// </summary>
    public class Air
    {
        /// <summary>
        /// Фактическая дата прибытия груза при доставке авиатранспортом
        /// </summary>
        [JsonPropertyName("arrivalDate")]
        public DateTime? ArrivalDate { get; set; }


        /// <summary>
        /// Дата выдачи груза при доставке авиатранспортом.
        /// </summary>
        [JsonPropertyName("giveoutDate")]
        public DateTime? GiveoutDate { get; set; }


        /// <summary>
        /// Дата начала платного хранения при доставке авиатранспортом.
        /// </summary>
        [JsonPropertyName("warehousingDate")]
        public DateTime? WarehousingDate { get; set; }


        /// <summary>
        /// Ориентировочная дата прибытия груза при доставке авиатранспортом.
        /// </summary>
        [JsonPropertyName("deliveryDate")]
        public DateTime? DeliveryDate { get; set; }


        /// <summary>
        /// Комментарий.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }


        /// <summary>
        /// Номер авианакладной.
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }
    }

}

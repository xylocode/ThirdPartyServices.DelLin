using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    public class Delivery
    {
        /// <summary>
        /// Вид межтерминальной перевозки груза для которого будет рассчитана стоимость
        /// </summary>
        [JsonPropertyName("deliveryType")]
        public DeliveryType DeliveryType { get; set; }

        /// <summary>
        /// Данные по доставке груза до получателя
        /// </summary>
        [JsonPropertyName("arrival")]
        public DerivalArrival Arrival { get; set; }

        /// <summary>
        /// Данные по доставке груза от отправителя
        /// </summary>
        [JsonPropertyName("derival")]
        public DerivalArrival Derival { get; set; }

        /// <summary>
        /// Данные по упаковке. При отсутствии параметра расчёт производится без учёта услуги
        /// </summary>
        [JsonPropertyName("packages")]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Информация по сопроводительным документам
        /// </summary>
        [JsonPropertyName("accompanyingDocuments")]
        public List<AccompanyingDocument> AccompanyingDocuments { get; set; }
    }
}

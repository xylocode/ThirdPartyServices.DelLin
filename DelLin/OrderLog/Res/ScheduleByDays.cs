using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Расчетные сроки доставки от терминала до адреса в днях.
    /// </summary>
    public class ScheduleByDays
    {
        /// <summary>
        /// Срок доставки груза.
        /// Отсчитывается от даты, пришедшей в параметре "orderDates.derivalFromOspReceiver".
        /// Информация присутствует в ответе, если заказана доставка до адреса и отсутствует дата доставки груза до адреса (см.описание параметра ответа "orders.orderDates.arrivalToReceiver").
        /// </summary>
        [JsonPropertyName("delivery")]
        public int? Delivery { get; set; }


        /// <summary>
        /// Срок доставки сопроводительных документов.
        /// Отсчитывается от даты, пришедшей в параметре "orderDates.derivalFromOspReceiverAccdoc".
        /// </summary>
        [JsonPropertyName("deliveryAccdoc")]
        public int? DeliveryAccdoc { get; set; }
    }
}
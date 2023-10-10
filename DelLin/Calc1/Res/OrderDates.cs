using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    public class OrderDates
    {
        /// <summary>
        /// Дата передачи груза на адресе отправителя
        /// </summary>
        [JsonPropertyName("pickup")]
        public DateOnly? Pickup { get; set; }

        /// <summary>
        /// Время, до которого необходимо забрать груз на адресе отправителя
        /// </summary>
        [JsonPropertyName("senderAddressTime")]
        public TimeOnly? SenderAddressTime { get; set; }


        /// <summary>
        /// Время, до которого необходимо передать груз на терминал отправителя
        /// </summary>
        [JsonPropertyName("senderTerminalTime")]
        public TimeOnly? SenderTerminalTime { get; set; }


        /// <summary>
        /// Дата прибытия на терминал-отправитель
        /// </summary>
        [JsonPropertyName("arrivalToOspSender")]
        public DateOnly? ArrivalToOspSender { get; set; }


        /// <summary>
        /// Дата отправки с терминала-отправителя
        /// </summary>
        [JsonPropertyName("derrivalFromOspSender")]
        public DateOnly? DerrivalFromOspSender { get; set; }


        /// <summary>
        /// Дата прибытия на терминал-получатель
        /// </summary>
        [JsonPropertyName("arrivalToOspReceiver")]
        public DateOnly? ArrivalToOspReceiver { get; set; }


        /// <summary>
        /// Дата прибытия на терминал получателя/в аэропорт
        /// </summary>
        [JsonPropertyName("arrivalToAirport")]
        public DateOnly? ArrivalToAirport { get; set; }


        /// <summary>
        /// Максимальная дата прибытия на терминал получателя/в аэропорт (в случае, если возможно увеличение срока прибытия)
        /// </summary>
        [JsonPropertyName("arrivalToAirportMax")]
        public DateOnly? ArrivalToAirportMax { get; set; }


        /// <summary>
        /// Дата и время, с которого груз готов к выдаче на терминале
        /// </summary>
        [JsonPropertyName("giveoutFromOspReceiver")]
        public DateTime? GiveoutFromOspReceiver { get; set; }


        /// <summary>
        /// Максимальная дата и время, с которого груз готов к выдаче на терминале (в случае, если возможно увеличение срока готовности)
        /// </summary>
        [JsonPropertyName("giveoutFromOspReceiverMax")]
        public DateTime? GiveoutFromOspReceiverMax { get; set; }


        /// <summary>
        /// Дата отправки с терминала-получателя
        /// </summary>
        [JsonPropertyName("derrivalFromOspReceiver")]
        public DateOnly? DerrivalFromOspReceiver { get; set; }


        /// <summary>
        /// Время, до которого необходимо подать заявку на доставку от адреса
        /// </summary>
        [JsonPropertyName("createTo")]
        public TimeOnly? CreateTo { get; set; }


        /// <summary>
        /// Дата и время, с которого возможна доставка до клиента
        /// Параметр присутствует в ответе только при расчёте стоимости авиа или экспресс-перевозки (значение параметра запроса "delivery.deliveryType.type"- "avia" или "express")
        /// </summary>
        [JsonPropertyName("derrivalToAddress")]
        public DateTime? DerrivalToAddress { get; set; }


        /// <summary>
        /// Максимальная дата и время, до которого возможна доставка до клиента
        /// Параметр присутствует в ответе только при расчёте стоимости авиа или экспресс-перевозки (значение параметра запроса "delivery.deliveryType.type"- "avia" или "express")
        /// </summary>
        [JsonPropertyName("derivalToAddressMax")]
        public DateTime? DerivalToAddressMax { get; set; }
    }
}

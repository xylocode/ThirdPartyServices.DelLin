using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class Order
    {
        /// <summary>
        /// Номер заказа интернет-магазина (внутренний номер заказа, ВНЗ)
        /// </summary>
        [JsonPropertyName("orderNumber")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Дата заказа интернет-магазина
        /// </summary>
        [JsonPropertyName("orderDate")]
        public DateTime? OrderDate { get; set; }


        /// <summary>
        /// Номер заказа
        /// </summary>
        [JsonPropertyName("orderId")]
        public string OrderId { get; set; }


        /// <summary>
        /// Дата создания заказа
        /// </summary>
        [JsonPropertyName("orderedAt")]
        public DateTime? OrderedAt { get; set; }


        /// <summary>
        /// Статус заказа на английском языке (см. "Справочник статусов заказа груза").
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }


        /// <summary>
        /// Статус заказа на русском языке (см. "Справочник статусов заказа груза")
        /// </summary>
        [JsonPropertyName("stateName")]
        public string StateName { get; set; }


        /// <summary>
        /// Дата установки текущего статуса.
        /// Формат: "ГГГГ-ММ-ДД".
        /// Если статус заказа - "Черновик" или "В обработке" (значение параметра ответа "orders.state" - "draft" или "processing"), то значение параметра - null.
        /// </summary>
        [JsonPropertyName("stateDate")]
        public DateOnly? StateDate { get; set; }


        /// <summary>
        /// Признак возвратного груза.
        /// </summary>
        [JsonPropertyName("returnState")]
        public bool? ReturnState { get; set; }


        /// <summary>
        /// Причина возврата груза.
        /// </summary>
        [JsonPropertyName("returnReason")]
        public string ReturnReason { get; set; }


        /// <summary>
        /// Дата и время установки признака возвратного груза
        /// </summary>
        [JsonPropertyName("returnDate")]
        public DateTime? ReturnDate { get; set; }


        /// <summary>
        /// Степень выполнения заказа (в процентах). Значение параметра может быть использовано для визуализации хода выполнения заказа.
        /// </summary>
        [JsonPropertyName("progressPercent")]
        public int? ProgressPercent { get; set; }


        /// <summary>
        /// Информация о месте отправки.
        /// </summary>
        [JsonPropertyName("derival")]
        public DerivalArrival Derival { get; set; }


        /// <summary>
        /// Информация о месте получения.
        /// </summary>
        [JsonPropertyName("arrival")]
        public DerivalArrival Arrival { get; set; }


        /// <summary>
        /// Информация об отправителе
        /// </summary>
        [JsonPropertyName("sender")]
        public Member Sender { get; set; }


        /// <summary>
        /// Информация о получателе
        /// </summary>
        [JsonPropertyName("receiver")]
        public Member Receiver { get; set; }


        /// <summary>
        /// Информация о плательщике
        /// </summary>
        [JsonPropertyName("payer")]
        public Member Payer { get; set; }


        /// <summary>
        /// Информация о грузе.
        /// </summary>
        [JsonPropertyName("freight")]
        public Freight Freight { get; set; }


        /// <summary>
        /// Информация о грузовых местах.
        /// </summary>
        [JsonPropertyName("cargoPlaces")]
        public List<CargoPlace> CargoPlaces { get; set; }


        /// <summary>
        /// Признак авиаперевозки.
        /// </summary>
        [JsonPropertyName("isAir")]
        public bool? IsAir { get; set; }


        /// <summary>
        /// Информация о доставке авиатранспортом.
        /// Если значение параметра "isAir" - "false", то вложенные параметры переданы не будут.
        /// </summary>
        [JsonPropertyName("air")]
        public Air Air { get; set; }


        /// <summary>
        /// Массив блокировок по заказу.
        /// </summary>
        [JsonPropertyName("locks")]
        public List<Lock> Locks { get; set; }


        /// <summary>
        /// Сумма наложенного платежа.
        /// </summary>
        [JsonPropertyName("webOrderItemsSum")]
        public decimal? WebOrderItemsSum { get; set; }


        /// <summary>
        /// Признак наложенного платежа.
        /// </summary>
        [JsonPropertyName("withWebOrder")]
        public bool? WithWebOrder { get; set; }


        /// <summary>
        /// Общая сумма заказа.
        /// </summary>
        [JsonPropertyName("totalSum")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? TotalSum { get; set; }


        /// <summary>
        /// НДС
        /// </summary>
        [JsonPropertyName("vat")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? Vat { get; set; }


        /// <summary>
        /// Статус оплаты заказа
        /// </summary>
        [JsonPropertyName("isPaid")]
        public bool? IsPaid { get; set; }


        /// <summary>
        /// Флаг, обозначающий что заказ является предзаказом.
        /// </summary>
        [JsonPropertyName("isPreorder")]
        public bool? IsPreorder { get; set; }


        /// <summary>
        /// Дата выполнения заказа.
        /// Данные недоступны при заказе услуги "Мультиотправка".
        /// </summary>
        [JsonPropertyName("produceDate")]
        public DateOnly? ProduceDate { get; set; }


        /// <summary>
        /// Причина отклонения.
        /// Данные доступны, только если заказ был отклонён.
        /// </summary>
        [JsonPropertyName("declineReason")]
        public string DeclineReason { get; set; }


        /// <summary>
        /// Расчетный график движения груза.
        /// </summary>
        [JsonPropertyName("orderDates")]
        public Schedule OrderDates { get; set; }


        /// <summary>
        /// Расчетные сроки доставки от терминала до адреса в днях.
        /// </summary>
        [JsonPropertyName("orderTimeInDays")]
        public ScheduleByDays OrderTimeInDays { get; set; }


        /// <summary>
        /// Флаг, обозначающий что заказана доставка от адреса отправителя.
        /// </summary>
        [JsonPropertyName("orderedDeliveryFromAddress")]
        public bool? OrderedDeliveryFromAddress { get; set; }


        /// <summary>
        /// Флаг, обозначающий что возможна доставка от адреса отправителя.
        /// </summary>
        [JsonPropertyName("availableDeliveryFromAddress")]
        public bool? AvailableDeliveryFromAddress { get; set; }


        /// <summary>
        /// Флаг, обозначающий что заказана доставка до адреса получателя.
        /// </summary>
        [JsonPropertyName("orderedDeliveryToAddress")]
        public bool? OrderedDeliveryToAddress { get; set; }


        /// <summary>
        /// Флаг, обозначающий что возможна доставка до адреса получателя.
        /// </summary>
        [JsonPropertyName("availableDeliveryToAddress")]
        public bool? AvailableDeliveryToAddress { get; set; }


        /// <summary>
        /// Признак избранного заказа.
        /// </summary>
        [JsonPropertyName("isFavorite")]
        public bool? IsFavorite { get; set; }


        /// <summary>
        /// Флаг контейнерной перевозки.
        /// </summary>
        [JsonPropertyName("isContainer")]
        public bool? IsContainer { get; set; }


        /// <summary>
        /// Информация по заявке на доставку до адреса получателя.
        /// </summary>
        [JsonPropertyName("sfrequest")]
        public Sfrequest Sfrequest { get; set; }


        /// <summary>
        /// Массив документов заказа.
        /// </summary>
        [JsonPropertyName("documents")]
        public List<Document> Documents { get; set; }

        /// <summary>
        /// Информация о промежуточных точках маршрута перевозки.
        /// Параметр отсутствует в ответе, если заказ отклонён или с момента завершения заказа прошло более 24 часов (значение параметра "response.state" - "declined" или же значение параметра "response.state" изменилось на "finished" более 24 часов назад).
        /// </summary>
        [JsonPropertyName("orderDatesAdditional")]
        public OrderDatesAdditional OrderDatesAdditional { get; set; }


        /// <summary>
        /// Дополнительный статус заказа на английском языке.
        /// Возможные значения (порядок соответствует порядку возможных значений параметра "detailedStatusRus"):
        /// "pickup_waiting_pickup";
        /// "pickup_departed";
        /// "pickup_arrived";
        /// "pickup_arrived_at_first";
        /// "pickup_arrived_at_last";
        /// "pickup_finished";
        /// "delivery_waiting_delivery";
        /// "delivery_departed";
        /// "delivery_arrived";
        /// "delivery_finished";
        /// "delivery_delivered"
        /// </summary>
        [JsonPropertyName("detailedStatus")]
        public string DetailedStatus { get; set; }


        /// <summary>
        /// Дополнительный статус заказа на русском языке.
        /// Возможные значения(порядок соответствует порядку возможных значений параметра "detailedStatus"):
        /// "Ожидается забор" - водитель ещё не выехал на адрес отправителя;
        /// "Машина едет на адрес";
        /// "Машина на адресе";
        /// "Прибыл на первый адрес";
        /// "Прибыл на последний адрес";
        /// "Груз забран. Едет на терминал";
        /// "Ожидается доставка" - водитель ещё не выехал на адрес получателя;
        /// "Машина едет на адрес";
        /// "Машина на адресе";
        /// "Груз доставлен" (соответствует значениям "delivery_finished" и "delivery_delivered" параметра "detailedStatus").
        /// </summary>
        [JsonPropertyName("detailedStatusRus")]
        public string DetailedStatusRus { get; set; }


        /// <summary>
        /// Комментарий к заказу.
        /// Пользователь может оставить комментарий к заказу в личном кабинете на сайте компании "Деловых Линии".
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }


        /// <summary>
        /// Ориентировочная дата возврата сопроводительных документов.
        /// </summary>
        [JsonPropertyName("documentsReturnDate")]
        public DateOnly? DocumentsReturnDate { get; set; }


        /// <summary>
        /// Комментарий, свидетельствующий о том, что информация о стоимости заказа недоступна текущему пользователю.
        /// </summary>
        [JsonPropertyName("priceComment")]
        public string PriceComment { get; set; }


        /// <summary>
        /// UID заказчика по заявке.
        /// Данные присутствуют в ответе, только если у пользователя есть полный доступ к контрагенту (см.метод "Список контрагентов", описание параметра ответа "info.accessLevel").
        /// </summary>
        [JsonPropertyName("customerUid")]
        public string CustomerUid { get; set; }


        /// <summary>
        /// Данные счёта-фактуры.
        /// </summary>
        [JsonPropertyName("acceptanceActs")]
        public List<AcceptanceAct> AcceptanceActs { get; set; }


        /// <summary>
        /// Артикул грузового места
        /// </summary>
        [JsonPropertyName("shipmentLabelCargoPlace")]
        public string ShipmentLabelCargoPlace { get; set; }
    }

}
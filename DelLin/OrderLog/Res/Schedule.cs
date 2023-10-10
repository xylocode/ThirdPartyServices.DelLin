using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Расчетный график движения груза.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Дата прибытия груза на терминал-получатель.
        /// </summary>
        [JsonPropertyName("arrivalToOspReceiver")]
        public DateOnly? ArrivalToOspReceiver { get; set; }


        /// <summary>
        /// Максимальная дата прибытия груза на терминал-получатель (в случае, если возможно увеличение срока прибытия).
        /// </summary>
        [JsonPropertyName("arrivalToOspReceiverMax")]
        public DateOnly? ArrivalToOspReceiverMax { get; set; }


        /// <summary>
        /// Дата прибытия сопроводительных документов на терминал-получатель.
        /// </summary>
        [JsonPropertyName("arrivalToOspReceiverAccdoc")]
        public DateOnly? ArrivalToOspReceiverAccdoc { get; set; }


        /// <summary>
        /// Дата прибытия груза на терминал-отправитель.
        /// </summary>
        [JsonPropertyName("arrivalToOspSender")]
        public DateOnly? ArrivalToOspSender { get; set; }


        /// <summary>
        /// Дата доставки груза до адреса:
        /// фактическая - для доcтавленных заказов(значение параметра ответа "orders.stateName" - "Заказ завершен", "Груз выдан. Возврат СД");
        /// расчётная - для заказов, принятых к перевозке, но ещё не доставленных.
        /// При отсутствии расчётной даты доставки, в ответе метода содержится расчётный срок доставки см.описание параметра ответа "orders.orderTimeInDays.delivery"
        /// </summary>
        [JsonPropertyName("arrivalToReceiver")]
        public DateOnly? ArrivalToReceiver { get; set; }


        /// <summary>
        /// Дата отклонения.
        /// В отдельных случаях данные могут отсутствовать.
        /// </summary>
        [JsonPropertyName("declineDate")]
        public DateOnly? DeclineDate { get; set; }


        /// <summary>
        /// Дата отправки с терминала-получателя.
        /// </summary>
        [JsonPropertyName("derivalFromOspReceiver")]
        public DateOnly? DerivalFromOspReceiver { get; set; }


        /// <summary>
        /// Максимальная дата отправки с терминала-получателя (в случае, если возможно увеличение срока отправки).
        /// </summary>
        [JsonPropertyName("derivalFromOspReceiverMax")]
        public DateOnly? DerivalFromOspReceiverMax { get; set; }


        /// <summary>
        /// Дата отправки сопроводительных документов с терминала-получателя.
        /// </summary>
        [JsonPropertyName("derivalFromOspReceiverAccdoc")]
        public DateOnly? DerivalFromOspReceiverAccdoc { get; set; }


        /// <summary>
        /// Ориентировочная дата готовности груза к выдаче на терминале-получателе.
        /// </summary>
        [JsonPropertyName("giveoutFromOspReceiver")]
        public DateOnly? GiveoutFromOspReceiver { get; set; }


        /// <summary>
        /// Максимальная дата готовности груза к выдаче на терминале-получателе (в случае, если возможно увеличение срока готовности).
        /// </summary>
        [JsonPropertyName("giveoutFromOspReceiverMax")]
        public DateOnly? GiveoutFromOspReceiverMax { get; set; }


        /// <summary>
        /// Дата отправления груза с терминала-отправителя.
        /// </summary>
        [JsonPropertyName("derivalFromOspSender")]
        public DateTime? DerivalFromOspSender { get; set; }


        /// <summary>
        /// Дата последнего сохранения черновика.
        /// </summary>
        [JsonPropertyName("draftLastUpdate")]
        public DateTime? DraftLastUpdate { get; set; }


        /// <summary>
        /// Дата исполнения заказа.
        /// </summary>
        [JsonPropertyName("finish")]
        public DateTime? Finish { get; set; }


        /// <summary>
        /// Дата создания первого документа по заказу.
        /// </summary>
        [JsonPropertyName("firstDocumentCreatedDate")]
        public DateTime? FirstDocumentCreatedDate { get; set; }


        /// <summary>
        /// Дата передачи груза на адресе отправителя.
        /// </summary>
        [JsonPropertyName("pickup")]
        public DateTime? Pickup { get; set; }


        /// <summary>
        /// Дата отправки заявки в обработку.
        /// </summary>
        [JsonPropertyName("processingDate")]
        public DateTime? ProcessingDate { get; set; }


        /// <summary>
        /// Дата начала платного хранения.
        /// </summary>
        [JsonPropertyName("warehousing")]
        public DateTime? Warehousing { get; set; }
    }
}

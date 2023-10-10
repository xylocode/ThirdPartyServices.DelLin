using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Документ заказа
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Номер документа
        /// </summary>
        [JsonPropertyName("id")]
        [JsonConverter(typeof(JsonObjectAsStringConverter))]
        public string Id { get; set; }


        /// <summary>
        /// UID накладной.
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }


        /// <summary>
        /// Тип документа.
        /// Возможные значения:
        /// "shipping" - накладная;
        /// "request" - заявка на доставку груза(от адреса отправителя или от терминала);
        /// "request_sf" - заявка на доставку до адреса получателя(от терминала);
        /// "request_ftl" - заявка на междугороднюю перевозку выделенной еврофурой
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }


        /// <summary>
        /// Дата создания документа
        /// </summary>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get; set; }


        /// <summary>
        /// Статус документа
        /// У заявки на доставку от адреса отправителя/до адреса получателя/на междугороднюю перевозку выделенной еврофурой (значение параметра "response.orders.documents.type" - "request"/"request_sf"/"request_ftl") могут быть следующие статусы:
        /// "temporary" - заявка не заполнена;
        /// "saved" - черновик;
        /// "ordered" - заявка в очереди на обработку;
        /// "loaded" - заявка взята на обработку;
        /// "processed" - заявка обработана;
        /// "declined" - заявка отклонена;
        /// "accepted" - заявка принята;
        /// "canceled" - заявка отменена.
        /// Для документа типа "Накладная" (значение параметра "response.orders.documents.type" - "shipping") статус присутствует в ответе, но не используется(всегда имеет значение "in_way").
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }


        /// <summary>
        /// Информация об отправителе
        /// </summary>
        [JsonPropertyName("sender")]
        public Member Sender { get; set; }


        /// <summary>
        /// Информация о получателе.
        /// </summary>
        [JsonPropertyName("receiver")]
        public Member Receiver { get; set; }


        /// <summary>
        /// Информация о плательщике.
        /// </summary>
        [JsonPropertyName("payer")]
        public Member Payer { get; set; }


        /// <summary>
        /// Дата исполнения заявки.
        /// </summary>
        [JsonPropertyName("produceDate")]
        public DateTime? ProduceDate { get; set; }


        /// <summary>
        /// Номер заявки экспедитора.
        /// </summary>
        [JsonPropertyName("forwarderId")]
        public string ForwarderId { get; set; }


        /// <summary>
        /// Комментарии к документам
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }


        /// <summary>
        /// Полный номер документа
        /// </summary>
        [JsonPropertyName("fullDocumentId")]
        public string FullDocumentId { get; set; }


        /// <summary>
        /// Информация о грузе.
        /// </summary>
        [JsonPropertyName("freight")]
        public Freight Freight { get; set; }


        /// <summary>
        /// Информация о месте отправки
        /// </summary>
        [JsonPropertyName("derival")]
        public DerivalArrival Derival { get; set; }


        /// <summary>
        /// Информация о месте получения
        /// </summary>
        [JsonPropertyName("arrival")]
        public DerivalArrival Arrival { get; set; }


        /// <summary>
        /// Barcode для формирования штрих-кода по алгоритму Code 128 (для заявки на предзаказ).
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }


        /// <summary>
        /// Статус оплаты.
        /// </summary>
        [JsonPropertyName("payment")]
        public bool? Payment { get; set; }


        /// <summary>
        /// Общая сумма по накладной.
        /// </summary>
        [JsonPropertyName("totalSum")]
        public decimal? TotalSum { get; set; }


        /// <summary>
        /// НДС
        /// </summary>
        [JsonPropertyName("vat")]
        [JsonConverter(typeof(JsonStringAsNDecimalConverter))]
        public decimal? Vat { get; set; }


        /// <summary>
        /// Тип перевозки
        /// </summary>
        [JsonPropertyName("serviceKind")]
        public string ServiceKind { get; set; }


        /// <summary>
        /// ID организации
        /// </summary>
        [JsonPropertyName("organization")]
        public string Organization { get; set; }


        /// <summary>
        /// Перечень услуг по накладной
        /// </summary>
        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }


        /// <summary>
        /// Перечень сопроводительных документов.
        /// </summary>
        [JsonPropertyName("accompanyingDocuments")]
        public List<AccompanyingDocument> AccompanyingDocuments { get; set; }

        /// <summary>
        /// Перечень документов, по которым можно получить печатные формы.
        /// </summary>
        [JsonPropertyName("availableDocs")]
        public List<string> AvailableDocs { get; set; }


        /// <summary>
        /// Направление перевозки груза.
        /// Возможные значения:
        /// straight - прямое направление;
        /// return - возврат груза отправителю;
        /// null - отсутствие данных.
        /// Значение "null" возвращается:
        /// для накладной, не являющейся основной накладной по заказу, для которого инициирован процесс возврата;
        /// для накладных по заказу без возврата груза
        /// </summary>
        [JsonPropertyName("freightDirection")]
        public string FreightDirection { get; set; }
    }


}

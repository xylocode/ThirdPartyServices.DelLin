using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderStatus.Res
{
    public class OrderStatusResponse
    {
        /// <summary>
        /// Перечень найденных заказов и история изменения их статусов
        /// </summary>
        [JsonPropertyName("statusHistory")]
        public Dictionary<string, List<OrderStatus>> StatusHistory { get; set; }


        /// <summary>
        /// Массив информационных сообщений.
        /// Выводится в ответе, если одновременно выполняются условия:
        /// в запросе было передано несколько номеров документов в параметре "docIds";
        /// хотя бы по одному номеру был найден ровно один заказ;
        /// хотя бы по одному номеру было найдено более одного заказа или не было найдено ни одного.
        /// В этом случае по однозначно найденным заказам выводится история изменения их статусов в блоке "data.statusHistory", а по остальным номерам выводятся соответствующие информационные сообщения в блоке "data.info".
        /// Примечание: Если в запросе был передан только один номер документа и по нему было найдено более одного заказа или не было найдено ни одного, то вместо блока "data" в ответ будет выведена ошибка 130002 с соответствующим описанием (см. "Ошибки методов API")
        /// </summary>
        [JsonPropertyName("info")]
        public List<MessageInfo> Info { get; set; }
    }


    public class OrderStatus
    {
        /// <summary>
        /// Переданный номер документа, по которому была найдена история изменения статусов.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }


        /// <summary>
        /// Статус заказа на английском языке (см. справочник "Справочник статусов заказа груза").
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }


        /// <summary>
        /// Статус заказа на русском языке (см. справочник "Справочник статусов заказа груза").
        /// </summary>
        [JsonPropertyName("stateName")]
        public string StateName { get; set; }


        /// <summary>
        /// Дата установки статуса.
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС+ЧЧ:ММ".
        /// </summary>
        [JsonPropertyName("stateDate")]
        public DateTimeOffset? StateDate { get; set; }


        /// <summary>
        /// Дополнительный статус заказа на английском языке.
        /// Возможные значения:
        /// "pickup_waiting_pickup";
        /// "pickup_departed";
        /// "pickup_arrived";
        /// "pickup_finished";
        /// "delivery_waiting_delivery";
        /// "delivery_departed";
        /// "delivery_arrived";
        /// "delivery_finished"
        /// </summary>
        [JsonPropertyName("detailedStatus")]
        public string DetailedStatus { get; set; }


        /// <summary>
        /// Дополнительный статус заказа на русском языке.
        /// Возможные значения(порядок соответствует порядку возможных значений параметра "docId.detailedStatus"):
        /// "Ожидается забор" - водитель ещё не выехал на адрес отправителя;
        /// "Машина едет на адрес";
        /// "Машина на адресе";
        /// "Груз забран. Едет на терминал";
        /// "Ожидается доставка" - водитель ещё не выехал на адрес получателя;
        /// "Машина едет на адрес";
        /// "Машина на адресе";
        /// "Груз доставлен"
        /// </summary>
        [JsonPropertyName("detailedStatusRus")]
        public string DetailedStatusRus { get; set; }


        /// <summary>
        /// Дата установки дополнительного статуса.
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС+ЧЧ:ММ"
        /// </summary>
        [JsonPropertyName("detailedStatusDate")]
        public DateTimeOffset? DetailedStatusDate { get; set; }
    }

    /// <summary>
    /// Информационное сообщение.
    /// </summary>
    public class MessageInfo
    {
        /// <summary>
        /// Переданный номер документа.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }


        /// <summary>
        /// Информационное сообщение.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

}

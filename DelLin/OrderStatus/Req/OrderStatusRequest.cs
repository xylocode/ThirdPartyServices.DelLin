using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.OrderStatus.Req
{
    /// <summary>
    /// Запрос истории статусов заказа
    /// </summary>
    public class OrderStatusRequest : Request
    {
        /// <summary>
        /// Номер заказа, накладной или заявки.
        /// Возможна передача нескольких параметров.
        /// Максимум может быть передано 5 значений.
        /// В запросе обязательно должен быть передан один из взаимоисключающих параметров: "docIds" или "webOrderNumber".
        /// </summary>
        [JsonPropertyName("docIds")]
        public List<string> DocIds { get; set; }


        /// <summary>
        /// Номер заказа интернет-магазина (внутренний номер заказа, ВНЗ).
        /// В запросе обязательно должен быть передан один из взаимоисключающих параметров: "docIds" или "webOrderNumber".
        /// </summary>
        [JsonPropertyName("webOrderNumber")]
        public string WebOrderNumber { get; set; }
    }
}

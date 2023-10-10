using System.Collections.Generic;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Responses;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class OrderLogResponse : Response<object>
    {

        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }
        /// <summary>
        /// Список удалённых заказов (при передаче в запросе параметра "request.lastUpdate").
        /// </summary>
        [JsonPropertyName("deleted")]
        public List<string> Deleted { get; set; }
    }
}

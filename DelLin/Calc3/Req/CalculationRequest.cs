using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.Calc3.Req
{
    public class CalculationRequest : Request
    {
        /// <summary>
        /// Информация по доставке груза от отправителя
        /// </summary>
        [JsonPropertyName("derival")]
        public DerivalArrival Derival { get; set; }


        /// <summary>
        /// Информация по доставке груза до получателя
        /// </summary>
        [JsonPropertyName("arrival")]
        public DerivalArrival Arrival { get; set; }
    }
}

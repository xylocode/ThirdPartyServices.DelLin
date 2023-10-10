using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    public class CalculationRequest : XyloCode.ThirdPartyServices.DelLin.Requests.Request
    {
        /// <summary>
        /// Информация по перевозке груза
        /// </summary>
        [JsonPropertyName("delivery")]
        public Delivery Delivery { get; set; }

        /// <summary>
        /// Участники перевозки
        /// </summary>
        [JsonPropertyName("members")]
        public Members Members { get; set; }

        /// <summary>
        /// Информация о грузе
        /// </summary>
        [JsonPropertyName("cargo")]
        public Cargo Cargo { get; set; }

        /// <summary>
        /// Оплата перевозки
        /// </summary>
        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }
    }

}

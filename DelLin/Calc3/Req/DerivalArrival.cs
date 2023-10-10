using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc3.Req
{
    public class DerivalArrival
    {
        /// <summary>
        /// Код КЛАДР города.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }
    }
}

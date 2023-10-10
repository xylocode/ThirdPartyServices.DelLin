using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Req
{
    /// <summary>
    /// Период времени доставки груза
    /// </summary>
    public class ArrivalPeriodVisit
    {
        /// <summary>
        /// Начало периода доставки груза
        /// </summary>
        [JsonPropertyName("start")]
        public TimeOnly? Start { get; set; }


        /// <summary>
        /// Окончание периода доставки груза
        /// </summary>
        [JsonPropertyName("end")]
        public TimeOnly? End { get; set; }
    }
}

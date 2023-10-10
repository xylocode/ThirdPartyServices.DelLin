using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// График работы терминала хранения в праздничные дни.
    /// </summary>
    public class SpecialWorktable
    {
        /// <summary>
        /// График работы терминала хранения на прием груза (в праздничные дни).
        /// </summary>
        [JsonPropertyName("receive")]
        public List<string> Receive { get; set; }


        /// <summary>
        /// График работы терминала хранения на выдачу груза (в праздничные дни).
        /// </summary>
        [JsonPropertyName("giveout")]
        public List<string> Giveout { get; set; }
    }
}

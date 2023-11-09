using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    public class Terminal
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("streetCode")]
        public string StreetCode { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("contractPrice")]
        public bool? ContractPrice { get; set; }

        [JsonPropertyName("default")]
        public bool? Default { get; set; }

        [JsonPropertyName("express")]
        public bool? Express { get; set; }

        [JsonPropertyName("isPVZ")]
        public bool? IsPVZ { get; set; }
    }

}

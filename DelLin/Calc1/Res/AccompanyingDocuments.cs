using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    public class AccompanyingDocuments
    {
        [JsonPropertyName("send")]
        public CostsCalculation Send { get; set; }

        [JsonPropertyName("return")]
        public CostsCalculation Return { get; set; }
    }
}

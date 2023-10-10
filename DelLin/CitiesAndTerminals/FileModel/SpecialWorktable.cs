using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class SpecialWorktable
    {
        [JsonPropertyName("receive")]
        public List<string> Receive { get; set; }

        [JsonPropertyName("giveout")]
        public List<string> Giveout { get; set; }
    }
}

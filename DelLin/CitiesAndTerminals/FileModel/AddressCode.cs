using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class AddressCode
    {
        [JsonPropertyName("street_code")]
        public string StreetCode { get; set; }
    }

}

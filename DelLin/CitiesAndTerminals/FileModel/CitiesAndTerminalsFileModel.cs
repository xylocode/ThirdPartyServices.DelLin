using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    public class CitiesAndTerminalsFileModel
    {
        [JsonPropertyName("city")]
        public List<City> Cities { get; set; }
    }
}

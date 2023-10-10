using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    /// <summary>
    /// Информация о терминалах в городе
    /// </summary>
    public class Terminals
    {
        /// <summary>
        /// Список терминалов в городе
        /// </summary>
        [JsonPropertyName("terminal")]
        public List<Terminal> Terminal { get; set; }
    }
}

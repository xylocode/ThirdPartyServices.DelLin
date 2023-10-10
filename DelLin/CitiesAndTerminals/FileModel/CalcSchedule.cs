using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.CitiesAndTerminals.FileModel
{
    /// <summary>
    /// Расписание работы терминала.
    /// </summary>
    public class CalcSchedule
    {
        /// <summary>
        /// График работы терминала по приему груза для отправки.
        /// </summary>
        [JsonPropertyName("derival")]
        public string Derival { get; set; }

        /// <summary>
        /// График работы терминала по выдаче поступившего груза.
        /// </summary>
        [JsonPropertyName("arrival")]
        public string Arrival { get; set; }
    }

}

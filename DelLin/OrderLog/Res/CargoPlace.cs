using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Грузовое место.
    /// </summary>
    public class CargoPlace
    {
        /// <summary>
        /// Номер грузового места
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }


        /// <summary>
        /// Количество грузовых мест с идентичным номером.
        /// </summary>
        [JsonPropertyName("amount")]
        public int? Amount { get; set; }
    }
}
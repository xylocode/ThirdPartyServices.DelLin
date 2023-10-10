using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc3.Res
{
    public class PeriodPrice
    {
        /// <summary>
        /// Минимальный ориентировочный срок перевозки (в днях)
        /// </summary>
        [JsonPropertyName("period_from")]
        public int? PeriodFrom { get; set; }

        /// <summary>
        /// Максимальный ориентировочный срок перевозки (в днях)
        /// </summary>
        [JsonPropertyName("period_to")]
        public int? PeriodTo { get; set; }

        /// <summary>
        /// Ориентировочная стоимость перевозки (в рублях)
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

    }
}

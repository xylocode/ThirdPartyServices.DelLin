using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Res
{
    /// <summary>
    /// Информация о стоимости ПРР
    /// </summary>
    public class Loadunload
    {
        /// <summary>
        /// Стоимость ПРР.
        /// Если ПРР выполняются бесплатно, то параметр содержит значение "0"
        /// </summary>
        [JsonPropertyName("arrival")]
        public decimal? Arrival { get; set; }

        /// <summary>
        /// Суммарный размер скидок на ПРР (при наличии)
        /// </summary>
        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }


        /// <summary>
        /// Суммарный размер наценок на ПРР (при наличии)
        /// </summary>
        [JsonPropertyName("premium")]
        public decimal? Premium { get; set; }


        /// <summary>
        /// Детализация стоимости услуг ПРР с учетом наценок и скидок
        /// </summary>
        [JsonPropertyName("premiumDetails")]
        public List<PricingDetails> PremiumDetails { get; set; }


        /// <summary>
        /// Детализация скидок на ПРР (при наличии)
        /// </summary>
        [JsonPropertyName("discountDetails")]
        public List<PricingDetails> DiscountDetails { get; set; }
    }
}

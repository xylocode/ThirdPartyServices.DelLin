using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    /// <summary>
    /// Информация о стоимости
    /// </summary>
    public class CostsCalculation
    {
        /// <summary>
        /// Стоимость услуги
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }


        /// <summary>
        /// Признак договорной цены.
        /// Если стоимость договорная (значение параметра - "true"), то значение параметра "price" - "null", информация о наценках и скидках отсутствует (значения параметров "premium" и "discount" - "0", массивы "premiumDetails" и "discountDetails" - пустые)
        /// </summary>
        [JsonPropertyName("contractPrice")]
        public bool? ContractPrice { get; set; }

        /// <summary>
        /// Размер наценки по услуге
        /// </summary>
        [JsonPropertyName("premium")]
        public decimal? Premium { get; set; }


        /// <summary>
        /// Размер скидки по услуге
        /// </summary>
        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }


        /// <summary>
        /// Подробная информация о наценках по услуге
        /// </summary>
        [JsonPropertyName("premiumDetails")]
        public List<PricingDetails> PremiumDetails { get; set; }

        
        /// <summary>
        /// Подробная информация о скидках по услуге
        /// </summary>
        [JsonPropertyName("discountDetails")]
        public List<PricingDetails> DiscountDetails { get; set; }
    }
}

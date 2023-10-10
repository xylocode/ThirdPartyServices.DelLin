using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc2.Res
{
    /// <summary>
    /// Информация о стоимости доставки груза до адреса получателя с учетом стоимости услуг, наценок и скидок на услуги, но без учета ПРР
    /// </summary>
    public class Arrival
    {
        /// <summary>
        /// Суммарный размер наценок на услуги (при наличии)
        /// </summary>
        [JsonPropertyName("premium")]
        public decimal? Premium { get; set; }


        /// <summary>
        /// Детализация стоимости услуг с учетом наценок и скидок
        /// </summary>
        [JsonPropertyName("premiumDetails")]
        public List<PremiumDetail> PremiumDetails { get; set; }


        /// <summary>
        /// Детализация скидок на услуги (при наличии)
        /// </summary>
        [JsonPropertyName("discountDetails")]
        public List<DiscountDetail> DiscountDetails { get; set; }


        /// <summary>
        /// Информация о стоимости ПРР
        /// </summary>
        [JsonPropertyName("price")]
        public decimal? Price { get; set; }


        /// <summary>
        /// Ближайший населённый пункт к адресу получателя, в котором имеется терминал (может совпадать со значением параметра "derival.terminal", если нет другого терминала, расположенного ближе к получателю)
        /// </summary>
        [JsonPropertyName("terminal")]
        public string Terminal { get; set; }


        /// <summary>
        /// Суммарный размер скидок на услуги (при наличии)
        /// </summary>
        [JsonPropertyName("discount")]
        public decimal? Discount { get; set; }
    }
}

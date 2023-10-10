using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    /// <summary>
    /// Характеристика заказа, которая инициировала применение скидки.
    /// </summary>
    public class Trigger
    {
        /// <summary>
        /// Характеристика заказа, которая инициировала применение скидки.
        /// Например, если скидка была применена по промокоду, то параметр содержит значение "promocode"
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}

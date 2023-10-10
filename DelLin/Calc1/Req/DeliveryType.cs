using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    public class DeliveryType
    {
        /// <summary>
        /// Вид межтерминальной перевозки груза, для которого будет рассчитана стоимость.
        /// Возможные значения:
        /// "auto"- автодоставка;
        /// "express" - экспресс-доставка;
        /// "letter" - письмо;
        /// "avia" - авиадоставка;
        /// "small" - доставка малогабаритного груза.
        /// </summary>
        [JsonPropertyName("type")]
        public DeliveryTypeCode Type { get; set; }
    }
}

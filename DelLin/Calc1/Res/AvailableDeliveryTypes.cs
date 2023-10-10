using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Res
{
    /// <summary>
    /// Список доступных видов перевозки и их стоимость
    /// </summary>
    public class AvailableDeliveryTypes
    {
        /// <summary>
        /// Стоимость автодоставки
        /// </summary>
        [JsonPropertyName("auto")]
        public decimal? Auto { get; set; }

        /// <summary>
        /// Стоимость доставки малогабаритного груза
        /// </summary>
        [JsonPropertyName("small")]
        public decimal? Small { get; set; }

        /// <summary>
        /// Стоимость авиадоставки
        /// </summary>
        [JsonPropertyName("avia")]
        public decimal? Avia { get; set; }

        /// <summary>
        /// Стоимость экспресс-доставки
        /// </summary>
        [JsonPropertyName("express")]
        public decimal? Express { get; set; }

        /// <summary>
        /// Стоимость доставки письма
        /// Информация о стоимости услуги доступна, только если значение параметра запроса "delivery.deliveryType.type" - "letter".
        /// В остальных случаях информация недоступна, значение параметра - "null"
        /// </summary>
        [JsonPropertyName("letter")]
        public decimal? Letter { get; set; }
    }

}

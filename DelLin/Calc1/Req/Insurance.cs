using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    /// <summary>
    /// Информация о страховке груза
    /// </summary>
    public class Insurance
    {
        /// <summary>
        /// Объявленная стоимость груза, руб.
        /// Максимальная длина поля - 12 символов
        /// </summary>
        [JsonPropertyName("statedValue")]
        public decimal? StatedValue { get; set; }

        /// <summary>
        /// Признак страхования срока доставки груза.
        /// Значение по умолчанию - "true"
        /// </summary>
        [JsonPropertyName("term")]
        public bool? Term { get; set; }
    }

}

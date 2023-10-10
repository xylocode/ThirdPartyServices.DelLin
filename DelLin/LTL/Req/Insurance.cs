using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
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


        /// <summary>
        /// Плательщик по услуге.
        /// Доступные значения:
        /// "sender" - отправитель;
        /// "receiver" - получатель;
        /// "third" - третье лицо.
        /// Если параметр не передан, то он принимает значение параметра "request.payment.primaryPayer"
        /// </summary>
        [JsonPropertyName("payer")]
        public RoleType? Payer { get; set; }

    }

}

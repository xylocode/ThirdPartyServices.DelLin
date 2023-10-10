using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    /// <summary>
    /// Оплата перевозки
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// Вид оплаты.
        /// Возможные значения:
        /// "cash" - оплата наличными или банковской картой;
        /// "noncash" - оплата посредством банковского перевода
        /// </summary>
        [JsonPropertyName("type")]
        public PaymentType? Type { get; set; }

        /// <summary>
        /// Промокод
        /// </summary>
        [JsonPropertyName("promocode")]
        public string Promocode { get; set; }

        /// <summary>
        /// Код КЛАДР населённого пункта оплаты (1).
        /// Может быть получен с помощью сервисов, представленных на странице "Поиск КЛАДР"
        /// </summary>
        [JsonPropertyName("paymentCity")]
        public string PaymentCity { get; set; }

        /// <summary>
        /// Населённый пункт в виде произвольной строки.
        /// Максимум - 1024 символа.
        /// Помимо наименования населённого пункта, в строке может быть передано наименование страны, региона, района - это позволит уточнить поиск и исключить ошибки, которые могут возникнуть из-за одинаковых названий населённых пунктов
        /// </summary>
        [JsonPropertyName("paymentCitySearch")]
        public Models.Search PaymentCitySearch { get; set; }
    }
}

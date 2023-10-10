using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Данные по упаковке. При отсутствии параметра расчёт производится без учёта услуги
    /// </summary>
    public class Package
    {
        /// <summary>
        /// Вид упаковки груза, UID упаковки из "Справочника дополнительных услуг"
        /// </summary>
        [JsonPropertyName("uid")]
        public Guid Uid { get; set; }

        /// <summary>
        /// Количество упаковок
        /// Если выбрана упаковка "Упаковка мешок" или "Картонная коробка", то параметр является обязательным
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count { get; set; }


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

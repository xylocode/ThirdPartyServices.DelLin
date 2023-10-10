using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
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
    }
}

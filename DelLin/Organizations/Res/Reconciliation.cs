using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Organizations.Res
{
    /// <summary>
    /// Информация о движении денежных средств контрагента.
    /// </summary>
    public class Reconciliation
    {
        [JsonPropertyName("opening")]
        public ReconciliationBalance Opening { get; set; }

        [JsonPropertyName("closing")]
        public ReconciliationBalance Closing { get; set; }
    }

    public class ReconciliationBalance
    {
        /// <summary>
        /// Дата начала/конца периода.
        /// Формат: "ГГГГ-ММ-ДД ЧЧ:ММ:СС"
        /// </summary>
        [JsonPropertyName("date")]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Сумма на начало/конец периода, руб
        /// </summary>
        [JsonPropertyName("sum")]
        public decimal? Sum { get; set; }
    }
}

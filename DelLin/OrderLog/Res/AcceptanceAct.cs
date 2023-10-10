using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Данные счёта-фактуры
    /// </summary>
    public class AcceptanceAct
    {
        /// <summary>
        /// Номер.
        /// </summary>
        [JsonPropertyName("acceptanceActNumber")]
        public string AcceptanceActNumber { get; set; }


        /// <summary>
        /// Дата
        /// </summary>
        [JsonPropertyName("acceptanceActDate")]
        public DateTimeOffset? AcceptanceActDate { get; set; }


        /// <summary>
        /// Тип.
        /// Возможные значения:
        /// Корректировочный;
        /// Исправленный
        /// В случае обычного счёта-фактуры параметр приходит пустым.
        /// </summary>
        [JsonPropertyName("acceptanceActType")]
        public string AcceptanceActType { get; set; }
    }
}

using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    /// <summary>
    /// Блокировки по грузу.
    /// </summary>
    public class Lock
    {
        /// <summary>
        /// Наименование блокировки.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }


        /// <summary>
        /// Тип блокировки.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }


        /// <summary>
        /// Дата установки блокировки.
        /// </summary>
        [JsonPropertyName("setDate")]
        public DateTime? SetDate { get; set; }


        /// <summary>
        /// Дата снятия блокировки.
        /// </summary>
        [JsonPropertyName("endDate")]
        public DateTime? EndDate { get; set; }
    }
}

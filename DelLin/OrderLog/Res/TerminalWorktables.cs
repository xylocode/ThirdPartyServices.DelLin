using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class TerminalWorktables
    {
        /// <summary>
        /// Время работы в понедельник.
        /// </summary>
        [JsonPropertyName("monday")]
        public string Monday { get; set; }


        /// <summary>
        /// Время работы во вторник.
        /// </summary>
        [JsonPropertyName("tuesday")]
        public string Tuesday { get; set; }


        /// <summary>
        /// Время работы в среду.
        /// </summary>
        [JsonPropertyName("wednesday")]
        public string Wednesday { get; set; }


        /// <summary>
        /// Время работы в четверг.
        /// </summary>
        [JsonPropertyName("thursday")]
        public string Thursday { get; set; }


        /// <summary>
        /// Время работы в пятницу.
        /// </summary>
        [JsonPropertyName("friday")]
        public string Friday { get; set; }


        /// <summary>
        /// Время работы в субботу.
        /// </summary>
        [JsonPropertyName("saturday")]
        public string Saturday { get; set; }


        /// <summary>
        /// Время работы в воскресенье.
        /// </summary>
        [JsonPropertyName("sunday")]
        public string Sunday { get; set; }
    }
}
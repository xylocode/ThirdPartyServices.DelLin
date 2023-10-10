using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Calc1.Req
{
    /// <summary>
    /// Время передачи груза отправителем/получателю на адресе.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Начало периода передачи груза.
        /// </summary>
        [JsonPropertyName("worktimeStart")]
        public TimeOnly WorktimeStart { get; set; }


        /// <summary>
        /// Окончание периода передачи груза.
        /// </summary>
        [JsonPropertyName("worktimeEnd")]
        public TimeOnly WorktimeEnd { get; set; }


        /// <summary>
        /// Начало перерыва.
        /// </summary>
        [JsonPropertyName("breakStart")]
        public TimeOnly? BreakStart { get; set; }


        /// <summary>
        /// Окончание перерыва.
        /// </summary>
        [JsonPropertyName("breakEnd")]
        public TimeOnly? BreakEnd { get; set; }


        /// <summary>
        /// Передача груза в точное время.
        /// </summary>
        [JsonPropertyName("exactTime")]
        public bool? ExactTime { get; set; }
    }
}

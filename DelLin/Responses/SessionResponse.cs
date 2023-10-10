using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Models;

namespace XyloCode.ThirdPartyServices.DelLin.Responses
{
    /// <summary>
    /// Ответ на запрос данных о сессии.
    /// </summary>
    internal class SessionResponse
    {
        /// <summary>
        /// Данные о сессии.
        /// </summary>
        [JsonPropertyName("session")]
        public Session Session { get; set; }
    }
}

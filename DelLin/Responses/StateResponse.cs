using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Responses
{
    /// <summary>
    /// Ответ на запрос.
    /// </summary>
    public class StateResponse
    {
        /// <summary>
        /// Статус обработки запроса.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}

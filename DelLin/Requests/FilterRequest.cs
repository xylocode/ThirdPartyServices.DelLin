using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Requests
{
    /// <summary>
    /// Используется для фильтрации контента, например для поиска страны.
    /// </summary>
    public class FilterRequest : Request
    {
        public FilterRequest() { }
        public FilterRequest(string filter) { Filter = filter; }
        /// <summary>
        /// Строка фильтра (поиска)
        /// </summary>
        [JsonPropertyName("filter")]
        public string Filter { get; set; }
    }
}

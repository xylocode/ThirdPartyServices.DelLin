using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Res
{
    public class FoundAddress
    {
        /// <summary>
        /// Объект, в котором был передан параметр "search"
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; }


        /// <summary>
        /// Введённое значение
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }


        /// <summary>
        /// Найденный адрес / населённый пункт
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
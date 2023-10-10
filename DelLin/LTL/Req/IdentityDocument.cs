using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Данные документа, удостоверяющего личность(для физических лиц)
    /// </summary>
    public class IdentityDocument
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonPropertyName("type")]
        public IdentityDocumentType? Type { get; set; }

        /// <summary>
        /// Серия документа
        /// </summary>
        [JsonPropertyName("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Номер документа. Формат номера зависит от страны
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}

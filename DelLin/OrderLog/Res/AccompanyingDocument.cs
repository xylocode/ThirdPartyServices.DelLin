using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.OrderLog.Res
{
    public class AccompanyingDocument
    {
        /// <summary>
        /// Дата создания сопроводительного документа.
        /// </summary>
        [JsonPropertyName("documentDate")]
        public DateOnly? DocumentDate { get; set; }

        /// <summary>
        /// Номер сопроводительного документа.
        /// </summary>
        [JsonPropertyName("documentNumber")]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Комментарий (тип документа).
        /// </summary>
        [JsonPropertyName("documentKind")]
        public string DocumentKind { get; set; }
    }
}

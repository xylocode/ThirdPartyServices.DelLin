using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Requests;

namespace XyloCode.ThirdPartyServices.DelLin.Organizations.Req
{
    internal class OrganizationsRequest : Request
    {
        /// <summary>
        /// UID контрагента, от имени которого должны создаваться заявки в рамках текущей сессии.
        /// Параметр позволяет изменить контрагента, выбранного по умолчанию, на другого контрагента
        /// </summary>
        [JsonPropertyName("cauid")]
        public Guid? OrganizationId { get; set; }

        /// <summary>
        /// Флаг, обозначающий, что запрошена полная информация по контрагентам, а также информация по взаиморасчётам
        /// </summary>
        [JsonPropertyName("fullInfo")]
        public bool? FullInfo { get; set; }
    }
}

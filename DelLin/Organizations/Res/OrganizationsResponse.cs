using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Organizations.Res
{
    public class OrganizationsResponse
    {
        /// <summary>
        /// Полный список доступных контрагентов
        /// </summary>
        [JsonPropertyName("counteragents")]
        public List<Organization> Organizations { get; set; }

    }
}

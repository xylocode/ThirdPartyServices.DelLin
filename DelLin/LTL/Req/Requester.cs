using System;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Enums;

namespace XyloCode.ThirdPartyServices.DelLin.LTL.Req
{
    /// <summary>
    /// Заказчик перевозки
    /// </summary>
    public class Requester
    {
        /// <summary>
        /// Роль в перевозке.
        /// </summary>
        [JsonPropertyName("role")]
        public RoleType? Role { get; set; }

        /// <summary>
        /// UID контрагента из "Списка контрагентов".
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }


        /// <summary>
        /// Email заказчика перевозки
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

    }
}

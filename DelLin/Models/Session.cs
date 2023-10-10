using System;
using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    internal class Session
    {
        [JsonPropertyName("expireTime")]
        public DateTime? ExpireTime { get; set; }


        [JsonPropertyName("expired")]
        public bool? IsExpired { get; set; }
    }
}

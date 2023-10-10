using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    internal class Login
    {
        [JsonPropertyName("sessionID")]
        public string SessionId { get; set; }
    }
}

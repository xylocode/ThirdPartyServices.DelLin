using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Requests
{
    internal class LoginRequest : Request
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}

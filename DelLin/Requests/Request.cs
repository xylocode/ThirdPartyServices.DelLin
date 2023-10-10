using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Requests
{
    public class Request
    {
        public Request() { }
        public Request(string appKey)
        {
            AppKey = appKey;
        }

        [JsonPropertyName("appkey")]
        public string AppKey { get; set; }

     
        [JsonPropertyName("sessionID")]
        public string SessionId { get; set; }
    }
}

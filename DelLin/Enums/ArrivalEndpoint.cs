using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum ArrivalEndpoint : byte
    {
        [EnumMember(Value = "address")]
        Address = 1,

        [EnumMember(Value = "terminal")]
        Terminal,

        [EnumMember(Value = "airport")]
        Airport
    }
}

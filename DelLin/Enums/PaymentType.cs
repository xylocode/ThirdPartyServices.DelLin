using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum PaymentType : byte
    {
        [EnumMember(Value = "cash")]
        Cash = 1,

        [EnumMember(Value = "noncash")]
        NonCash,
    }
}

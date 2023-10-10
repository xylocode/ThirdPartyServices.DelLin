using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum RoleType : byte
    {
        [EnumMember(Value = "sender")]
        Sender = 1,

        [EnumMember(Value = "receiver")]
        Receiver,

        [EnumMember(Value = "payer")]
        Payer,

        [EnumMember(Value = "third")]
        Third
    }
}

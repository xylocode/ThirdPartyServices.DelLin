using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum DeliveryTypeCode
    {
        [EnumMember(Value = "auto")]
        Auto = 1,

        [EnumMember(Value = "express")]
        Express,

        [EnumMember(Value = "letter")]
        Letter,

        [EnumMember(Value = "avia")]
        Avia,

        [EnumMember(Value = "small")]
        Small,
    }
}

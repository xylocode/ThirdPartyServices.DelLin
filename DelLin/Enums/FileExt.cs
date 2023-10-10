using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum FileExt
    {
        [EnumMember(Value = "pdf")]
        PDF,

        [EnumMember(Value = "jpg")]
        JPG,

        [EnumMember(Value = "png")]
        PNG
    }
}

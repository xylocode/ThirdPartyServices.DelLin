using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum OrderSortOrderBy
    {
        [EnumMember(Value = "ordered_at")]
        OrderedAt = 1,

        [EnumMember(Value = "updated_at")]
        UpdatedAt,
    }

}

using System.Text.Json.Serialization;
using XyloCode.ThirdPartyServices.DelLin.Helpers;

namespace XyloCode.ThirdPartyServices.DelLin.Enums
{
    [JsonConverter(typeof(JsonEnumConverter))]
    public enum IdentityDocumentType : byte
    {
        Passport = 1,
        DrivingLicence,
        ForeignPassport
    }
}

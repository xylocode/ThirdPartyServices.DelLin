using System.Text.Json;

namespace XyloCode.ThirdPartyServices.DelLin.Helpers
{
    internal class JsonLowerCaseNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            if (string.IsNullOrEmpty(name) || !char.IsUpper(name[0]))
                return name;

            return name.ToLower();
        }
    }
}

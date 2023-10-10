using System.Text.Json.Serialization;

namespace XyloCode.ThirdPartyServices.DelLin.Models
{
    public class Search
    {
        [JsonPropertyName("search")]
        public string SearchString { get; set; }

        public Search() { }
        public Search(string searchString) { SearchString = searchString; }
    }
}

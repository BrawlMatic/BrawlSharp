using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class Club
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

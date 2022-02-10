using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player
{
    public class Club
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

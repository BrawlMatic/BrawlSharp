using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class Map
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("map")]
        public string Name { get; set; }
    }
}

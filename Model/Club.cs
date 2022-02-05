using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class Club
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("badgeId")]
        public int BadgeId { get; set; }

        [JsonPropertyName("requiredTrophies")]
        public int RequiredTrophies { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("members")]
        public Player[] Members { get; set; }
    }
}

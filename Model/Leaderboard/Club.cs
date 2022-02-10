using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Leaderboard
{
    public class Club
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("BadgeId")]
        public int BadgeId { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("memberCount")]
        public int MemberCount { get; set; }
    }
}

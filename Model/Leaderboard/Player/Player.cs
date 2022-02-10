using BarwlSharp.Model.Player;
using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Leaderboard.Player
{
    public class Player
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nameColor")]
        public string NameColor { get; set; }

        [JsonPropertyName("icon")]
        public Icon Icon { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("club")]
        public Club Club { get; set; }
    }
}

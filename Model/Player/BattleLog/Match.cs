using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player.BattleLog
{
    public class Match
    {
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("trophyChange")]
        public int TrophyChange { get; set; }

        [JsonPropertyName("starPlayer")]
        public Player StarPlayer { get; set; }

        [JsonPropertyName("players")]
        public Player[] Players { get; set; }

        [JsonPropertyName("teams")]
        public Player[][] Teams { get; set; }
    }
}

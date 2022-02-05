using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public partial class Battle
    {
        [JsonPropertyName("battleTime")]
        public string Date { get; set; }

        [JsonPropertyName("event")]
        public Map Map { get; set; }

        [JsonPropertyName("battle")]
        public Match Match { get; set; }
    }

    public partial class Match
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
        public BattlePlayer StarPlayer { get; set; }

        [JsonPropertyName("players")]
        public BattlePlayer[] Players { get; set; }

        [JsonPropertyName("teams")]
        public BattlePlayer[][] Teams { get; set; }
    }

    public partial class BattlePlayer
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("brawler")]
        public Brawler Brawler { get; set; }
    }
}

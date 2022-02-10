using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player.BattleLog
{
    public class Player
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("brawler")]
        public Brawler Brawler { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player.BattleLog
{
    public class Battle
    {
        [JsonPropertyName("battleTime")]
        public string Date { get; set; }

        [JsonPropertyName("event")]
        public Map Map { get; set; }

        [JsonPropertyName("battle")]
        public Match Match { get; set; }
    }
}

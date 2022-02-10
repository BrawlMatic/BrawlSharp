using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player.BattleLog
{
    public class BattleLog
    {
        [JsonPropertyName("items")]
        public Battle[] Battles { get; set; }
    }
}

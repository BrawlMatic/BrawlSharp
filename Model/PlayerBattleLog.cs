using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class PlayerBattleLog
    {
        [JsonPropertyName("items")]
        public Battle[] Battles { get; set; }
    }
}

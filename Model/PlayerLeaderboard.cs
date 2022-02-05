using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class PlayerLeaderboard
    {
        [JsonPropertyName("items")]
        public Player[] Players { get; set; }
    }
}

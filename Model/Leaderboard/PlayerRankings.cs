using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Leaderboard
{
    public class PlayerRankings
    {
        [JsonPropertyName("items")]
        public Player.Player[] Players { get; set; }
    }
}

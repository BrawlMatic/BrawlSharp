using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Leaderboard
{
    public class ClubRankings
    {
        [JsonPropertyName("items")]
        public Club[] Clubs { get; set; }
    }
}

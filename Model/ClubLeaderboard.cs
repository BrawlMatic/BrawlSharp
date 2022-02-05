using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class ClubLeaderboard
    {
        [JsonPropertyName("items")]
        public Club[] Clubs { get; set; }
    }
}

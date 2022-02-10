using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Leaderboard.Player
{
    public class Club
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

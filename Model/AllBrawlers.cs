using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class AllBrawlers
    {
        [JsonPropertyName("items")]
        public Brawler[] Brawlers { get; set; }
    }
}

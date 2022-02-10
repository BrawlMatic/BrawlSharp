using System.Text.Json.Serialization;

namespace BrawlSharp.Model.BrawlerItem
{
    public class Gear
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }
    }
}

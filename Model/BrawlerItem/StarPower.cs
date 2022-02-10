using System.Text.Json.Serialization;

namespace BrawlSharp.Model.BrawlerItem
{
    public class StarPower
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

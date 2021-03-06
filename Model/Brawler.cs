using BrawlSharp.Model.BrawlerItem;
using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class Brawler
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("starPowers")]
        public StarPower[] StarPowers { get; set; }

        [JsonPropertyName("gadgets")]
        public Gadget[] Gadgets { get; set; }
    }
}

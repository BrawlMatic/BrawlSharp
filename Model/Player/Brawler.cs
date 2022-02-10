using BrawlSharp.Model.BrawlerItem;
using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player
{
    public class Brawler
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("power")]
        public int Power { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("highestTrophies")]
        public int HighestTrophies { get; set; }

        [JsonPropertyName("gears")]
        public Gear[] Gears { get; set; }

        [JsonPropertyName("starPowers")]
        public StarPower[] StarPowers { get; set; }

        [JsonPropertyName("gadgets")]
        public Gadget[] Gadgets { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BrawlSharp.Model
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

    public partial class Gear
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }
    }

    public partial class StarPower
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public partial class Gadget
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

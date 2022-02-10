using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Player.BattleLog
{
    public class Brawler
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("power")]
        public int Power { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }
    }
}

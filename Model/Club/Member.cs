using BarwlSharp.Model.Player;
using System.Text.Json.Serialization;

namespace BrawlSharp.Model.Club
{
    public class Member
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nameColor")]
        public string NameColor { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("icon")]
        public Icon Icon { get; set; }
    }
}

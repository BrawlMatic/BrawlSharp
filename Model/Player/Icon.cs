using System.Text.Json.Serialization;

namespace BarwlSharp.Model.Player
{
    public class Icon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}

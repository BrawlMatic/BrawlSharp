using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class PlayerIcon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}

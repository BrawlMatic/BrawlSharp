using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public class Event
    {
        [JsonPropertyName("startTime")]
        public string StartDate { get; set; }

        [JsonPropertyName("endTime")]
        public string EndDate { get; set; }

        [JsonPropertyName("event")]
        public Map Map { get; set; }
    }
}

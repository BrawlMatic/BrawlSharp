using System.Text.Json.Serialization;

namespace BrawlSharp.Model
{
    public partial class Player
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nameColor")]
        public string NameColor { get; set; }

        [JsonPropertyName("icon")]
        public Icon Icon { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("highestTrophies")]
        public int HighestTrophies { get; set; }

        [JsonPropertyName("highestPowerPlayPoints")]
        public int HighestPowerPlayPoints { get; set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; set; }

        [JsonPropertyName("expPoints")]
        public int ExpPoints { get; set; }

        [JsonPropertyName("isQualifiedFromChampionshipChallenge")]
        public bool IsQualifiedFromChampionshipChallenge { get; set; }

        [JsonPropertyName("3vs3Victories")]
        public int Victories { get; set; }

        [JsonPropertyName("soloVictories")]
        public int SoloVictories { get; set; }

        [JsonPropertyName("duoVictories")]
        public int DuoVictories { get; set; }

        [JsonPropertyName("bestRoboRumbleTime")]
        public int BestRoboRumbleTime { get; set; }

        [JsonPropertyName("bestTimeAsBigBrawler")]
        public int BestTimeAsBigBrawler { get; set; }

        [JsonPropertyName("club")]
        public Club Club { get; set; }

        [JsonPropertyName("brawlers")]
        public Brawler[] Brawlers { get; set; }
    }

    public partial class Icon
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public partial class Club
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

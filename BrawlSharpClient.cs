using BrawlSharp.Model;
using BrawlSharp.Model.Leaderboard;
using BrawlSharp.Model.Player.BattleLog;
using RestSharp;
using System.Threading.Tasks;

namespace BrawlSharp
{
    public class BrawlSharpClient
    {
        readonly RestClient client;

        public BrawlSharpClient(string token)
        {
            client = new RestClient("https://api.brawlstars.com/v1");

            client.AddDefaultHeader("User-Agent", "BrawlSharp/2.0.0");
            client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<Model.Player.Player> GetPlayerAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<Model.Player.Player>($"/players/%23{tag}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<BattleLog> GetPlayerBattleLogAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<BattleLog>($"/players/%23{tag}/battlelog");
            }
            catch
            {
                throw;
            }
        }

        public async Task<Model.Club.Club> GetClubAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<Model.Club.Club>($"/clubs/%23{tag}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<PlayerRankings> GetPlayerLeaderboardAsync(string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<PlayerRankings>($"/rankings/{country}/players");
            }
            catch
            {
                throw;
            }
        }

        public async Task<ClubRankings> GetClubLeaderboardAsync(string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<ClubRankings>($"/rankings/{country}/clubs");
            }
            catch
            {
                throw;
            }
        }

        public async Task<PlayerRankings> GetBrawlerLeaderboardAsync(int brawler, string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<PlayerRankings>($"/rankings/{country}/brawlers/{brawler}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<AllBrawlers> GetBrawlersAsync()
        {
            try
            {
                return await client.GetJsonAsync<AllBrawlers>("/brawlers");
            }
            catch
            {
                throw;
            }
        }

        public async Task<Model.Brawler> GetBrawlerAsync(int brawler)
        {
            try
            {
                return await client.GetJsonAsync<Model.Brawler>($"/brawlers/{brawler}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<Event[]> GetEventsAsync()
        {
            try
            {
                return await client.GetJsonAsync<Event[]>("/events/rotation");
            }
            catch
            {
                throw;
            }
        }
    }
}

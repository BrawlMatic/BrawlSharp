using BrawlSharp.Model;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace BrawlSharp
{
    public class BrawlAPI
    {
        RestClient client;

        public BrawlAPI(string token)
        {
            client = new RestClient("https://api.brawlstars.com/v1");
            client.AddDefaultHeader("User-Agent", "BrawlSharp/1.0.1");
            client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<Player> GetPlayerAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<Player>($"/players/%23{tag}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<PlayerBattleLog> GetPlayerBattleLogAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<PlayerBattleLog>($"/players/%23{tag}/battlelog");
            }
            catch
            {
                throw;
            }
        }

        public async Task<Club> GetClubAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<Club>($"/clubs/%23{tag}");
            }
            catch
            {
                throw;
            }
        }

        public async Task<PlayerLeaderboard> GetPlayerLeaderboardAsync(string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<PlayerLeaderboard>($"/rankings/{country}/players");
            }
            catch
            {
                throw;
            }
        }

        public async Task<ClubLeaderboard> GetClubLeaderboardAsync(string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<ClubLeaderboard>($"/rankings/{country}/clubs");
            }
            catch
            {
                throw;
            }
        }

        public async Task<PlayerLeaderboard> GetBrawlerLeaderboardAsync(int brawler, string country = "global")
        {
            try
            {
                return await client.GetJsonAsync<PlayerLeaderboard>($"/rankings/{country}/brawlers/{brawler}");
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

        public async Task<Brawler> GetBrawlerAsync(int brawler)
        {
            try
            {
                return await client.GetJsonAsync<Brawler>($"/brawlers/{brawler}");
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

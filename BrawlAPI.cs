using BrawlSharp.Model;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace BrawlSharp
{
    class BrawlAPI
    {
        RestClient client;

        public BrawlAPI(string token)
        {
            client = new RestClient("https://api.brawlstars.com/v1");
            client.AddDefaultHeader("User-Agent", "BrawlSharp/1.0.0");
            client.AddDefaultHeader("Authorization", $"Bearer {token}");
        }

        public async Task<Player> GetPlayerAsync(string tag)
        {
            try
            {
                return await client.GetJsonAsync<Player>($"/players/%23{tag}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}

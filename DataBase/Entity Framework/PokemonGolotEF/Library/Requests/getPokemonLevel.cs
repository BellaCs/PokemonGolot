using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Library.Requests
{
    internal class getPokemonLevel
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<String> getCpMultiplier()
        {
            string sURL;
            sURL = "https://pogoapi.net/api/v1/cp_multiplier.json";

            try
            {
                HttpResponseMessage response = await client.GetAsync(sURL);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                return null;
            }


        }

        public static async Task<String> getRequirementsToPowerUp()
        {
            string sURL;
            sURL = "https://pogoapi.net/api/v1/pokemon_powerup_requirements.json";

            try
            {
                HttpResponseMessage response = await client.GetAsync(sURL);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);

                return null;
            }


        }
    }
}

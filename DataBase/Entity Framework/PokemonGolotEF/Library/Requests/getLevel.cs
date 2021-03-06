using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Library.Requests
{
    class getLevel
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<String> getLevels()
        {
            string sURL;
            sURL = "https://pogoapi.net/api/v1/player_xp_requirements.json";

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

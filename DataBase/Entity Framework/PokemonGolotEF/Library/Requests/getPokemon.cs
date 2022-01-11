using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Library.Requests
{
    internal class getPokemon
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<String> getPokemons(string gen)
        {
            string sURL;
            sURL = "https://db.pokemongohub.net/pokemon-list/gen-" + gen;

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

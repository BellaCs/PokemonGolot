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
    internal class getElement
    {
        static readonly HttpClient client = new HttpClient();

        public static async Task<String> getElements()
        {
            string sURL;
            sURL = "https://pokeapi.co/api/v2/type/";

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

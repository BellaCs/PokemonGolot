using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
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
            sURL = "https://db.pokemongohub.net/api/pokemon/with-generation/" + gen + "?locale=en";
            var productValue = new ProductInfoHeaderValue("Mozilla","5.0");
            var request = new HttpRequestMessage(HttpMethod.Get, sURL);

            request.Headers.Add("Accept", "application/json");
            request.Headers.UserAgent.Add(productValue);

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message : {0} ", e.Message);

                return null;
            }


        }

        public static async Task<String> getPokemonDetails(string numPokedex)
        {

            string sURL;
            sURL = "https://db.pokemongohub.net/api/pokemon/" + numPokedex + "?locale=en&form=";
            var productValue = new ProductInfoHeaderValue("Mozilla", "5.0");
            var request = new HttpRequestMessage(HttpMethod.Get, sURL);

            request.Headers.Add("Accept", "application/json");
            request.Headers.UserAgent.Add(productValue);

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message : {0} ", e.Message);

                return null;
            }


        }


        public static async Task<String> getPokemonImages(int namePokemon)
        {

            string sURL;
            sURL = "https://pokeapi.co/api/v2/pokemon/" + namePokemon;
            var request = new HttpRequestMessage(HttpMethod.Get, sURL);

            request.Headers.Add("Accept", "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message : {0} ", e.Message);

                return null;
            }

        }

        public static async Task<String> getPokemonGenders()
        {

            string sURL;
            sURL = "https://pogoapi.net/api/v1/pokemon_genders.json";
            var request = new HttpRequestMessage(HttpMethod.Get, sURL);
            request.Headers.Add("Accept", "application/json");

            try
            {
                HttpResponseMessage response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message : {0} ", e.Message);

                return null;
            }


        }
    }
}

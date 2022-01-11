using System;
using PokemonGolotEF.Model;
using PokemonGolotEF.Library;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using PokemonGolotEF.Data;

namespace PokemonGolotEF
{
    class Program
    {
        public static LoadData pokemonData;
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            pokemonData = new LoadData();
            getDataTry();

        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(
                webBuilder => webBuilder.UseStartup<Startup>());

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
                => services.AddDbContext<PokemonGolotDBContext>();

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
            }
        }

        static void getDataTry() 
        {

            Console.WriteLine("User levels data:\n\n");

            foreach (Level actual in pokemonData.pokemonGolot.userLevels)              
                Console.WriteLine("Level: " + actual.level + "\nXP: " + actual.necessary_xp + "\n");

            Console.WriteLine("\n----------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Pokemon levels data:\n\n");
            
            foreach(PokemonLevel actual in pokemonData.pokemonGolot.pokemonsLevels)
                Console.WriteLine("Level: " + actual.pokemon_level + "\nMultiplier: " + actual.cp_multiplier + "\nCandy: " + actual.candy_to_upgrade + "\nStardust: " + actual.stardust_to_upgrade + "\n");

            Console.WriteLine("\n----------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Elements data:\n\n");

            foreach (Element actual in pokemonData.pokemonGolot.elements)
                Console.WriteLine("Name: " + actual.name + "\n");

            Console.WriteLine("\n----------------------------------------------------------------------------------------\n\n");

            Console.WriteLine("Pokestops data:");

            foreach (PokeStop actual in pokemonData.pokemonGolot.pokestops) 
            {
                String latitude = actual.location.Substring(0, actual.location.IndexOf("#"));
                String longitude = actual.location.Substring(actual.location.IndexOf("#") + 1);
                Console.WriteLine("Name: " + actual.name + "\nLatitude: " + latitude + "\nLongitude: " + longitude + "\n");
            }

        }
    }
}

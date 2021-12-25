using System;
using PokemonGolotEF.Library.Requests;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PokemonGolotEF.Model;
using System.Collections.Generic;
using PokemonGolotEF.Library;

namespace PokemonGolotEF
{
    class Program
    {
        public static LoadData pokemonData;
        static void Main(string[] args)
        {

            pokemonData = new LoadData();
            getDataTry().Wait();

        }

       

        static async Task getDataTry() 
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

        }
    }
}

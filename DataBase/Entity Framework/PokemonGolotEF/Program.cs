using System;
using PokemonGolotEF.Library.Requests;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using PokemonGolotEF.Model;
using System.Collections.Generic;

namespace PokemonGolotEF
{
    class Program
    {
       static void Main(string[] args)
        {

            getLevelTry().Wait();
            getPokemonLevelTry().Wait();

        }

        static async Task getPokemonLevelTry()
        {
            PokemonLevel actual;
            String cpMultiplierJson = await getPokemonLevel.getCpMultiplier();
            String requirementsToPowerUpJson = await getPokemonLevel.getRequirementsToPowerUp();
            JToken cpMultiplier = JToken.Parse(cpMultiplierJson);
            JObject requirementsToPowerUp = JObject.Parse(requirementsToPowerUpJson);
            foreach (JToken pokemonLevel in cpMultiplier)
            {
                if ((int)pokemonLevel["level"] < 40)
                {
                    actual = new PokemonLevel(pokemonLevel);
                    foreach (KeyValuePair<String, JToken> requirment in requirementsToPowerUp)
                    {
                        if (requirment.Key.Replace('.', ',').Equals(actual.pokemon_level.ToString()))
                        {
                            actual.addData(requirment);
                        }
                    }
                    Console.WriteLine("Level: " + actual.pokemon_level + "\nMultiplier: " + actual.cp_multiplier + "\nCandy: " + actual.candy_to_upgrade + "\nStardust: " + actual.stardust_to_upgrade + "\n");
                }
            }
        }

        static async Task getLevelTry() 
        {
            Level actual;
            String levelJsonString = await getLevel.getLevels();
            JObject levelJson = JObject.Parse(levelJsonString);
            foreach (KeyValuePair<String, JToken> level in levelJson)
            {
                actual = new Level(level);
                Console.WriteLine("Level: " + actual.level + "\nXP: " + actual.necessary_xp + "\n");

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonGolotEF.Model;
using PokemonGolotEF.Library.Requests;
using Newtonsoft.Json.Linq;

namespace PokemonGolotEF.Library
{
    internal class LoadData
    {
        public PokemonGolot pokemonGolot = new PokemonGolot();

        public LoadData()
        {
            LoadLevel().Wait();
        }

        public void LoadPokemon() 
        {
            
        }

        public async Task LoadLevel()
        {
            Level actual;
            String levelJsonString = await getLevel.getLevels();
            JObject levelJson = JObject.Parse(levelJsonString);
            foreach (KeyValuePair<String, JToken> level in levelJson)
            {

                actual = new Level(level);
                pokemonGolot.userLevels.Add(actual);              
            }
        }
    }
}

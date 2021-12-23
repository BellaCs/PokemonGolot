using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace PokemonGolotEF.Model
{
    class PokemonLevel
    {
        public PokemonLevel()
        {
            pokemons = new HashSet<PokemonOwned>();
        }

        public PokemonLevel(JToken pokemonLevelJson)
        {
            this.pokemon_level = (float)pokemonLevelJson["level"];
            this.cp_multiplier = (double)pokemonLevelJson["multiplier"];
        }

        public void addData(KeyValuePair<String, JToken> jsonData) 
        {
            this.candy_to_upgrade = (int)jsonData.Value["candy_to_upgrade"];
            this.stardust_to_upgrade = (int)jsonData.Value["stardust_to_upgrade"];
        }

        [Key]
        public float pokemon_level { get; set; }
        [Required]
        public double cp_multiplier { get; set; }
        [Required]
        public int stardust_to_upgrade { get; set; }
        [Required]
        public int candy_to_upgrade { get; set; }


        public virtual ICollection<PokemonOwned> pokemons { get; set; }
    }
}

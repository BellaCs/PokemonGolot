using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace PokemonGolotEF.Model
{
    class Pokemon
    {
        public Pokemon() 
        {
            Owners = new HashSet<PokemonOwned>();
        }

        public Pokemon(KeyValuePair<String, JToken> pokemonJson)
        {
            
        }

        [Key]
        public int num_pokedex { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double attack { get; set; }
        [Required]
        public double stamina { get; set; }
        [Required]
        public double defense { get; set; }
        [Required]
        public float male_gender { get; set; } //Rate
        [Required]
        public float female_gender { get; set; } //Rate
        [Required]
        public string rarity { get; set; }
        [Required]
        public string img_front { get; set; }
        [Required]
        public string img_back { get; set; }
        [Required]
        public string description { get; set; }


        public virtual ICollection<PokemonOwned> Owners { get; set; }
    }
}

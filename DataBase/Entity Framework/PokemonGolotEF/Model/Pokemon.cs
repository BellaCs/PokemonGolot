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

        public Pokemon(JToken pokemonJson)
        {

            num_pokedex = (int)pokemonJson["id"];
            name = (string)pokemonJson["name"];
            attack = (double)pokemonJson["atk"];
            stamina = (double)pokemonJson["sta"];
            defense = (double)pokemonJson["def"];
            
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
        public string rarity { get; set; }
        [Required]
        public string img_front { get; set; }
        [Required]
        public string img_back { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public float male_gender_rate { get; set; }
        [Required]
        public float female_gender_rate { get; set; }


        public virtual ICollection<PokemonOwned> Owners { get; set; }
    }
}

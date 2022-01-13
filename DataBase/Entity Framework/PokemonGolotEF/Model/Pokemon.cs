using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace PokemonGolotEF.Model
{
    internal class Pokemon
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
        public string img_front_female { get; set; }
        [Required]
        public string img_back { get; set; }  
        public string img_back_female { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public float male_gender_rate { get; set; } //%
        [Required]
        public float female_gender_rate { get; set; }  //%
        [Required]
        public bool isActive { get; set; }


        public virtual ICollection<PokemonOwned> Owners { get; set; }

        public void addImages(JToken pokemonImages)
        {
            img_front = (string)pokemonImages["front_default"];
            img_front_female = (string)pokemonImages["front_female"];
            img_back = (string)pokemonImages["back_default"];
            img_back_female = (string)pokemonImages["back_female"];
        }

        public void setDetails(JToken pokemonDetails) 
        {
            rarity = (int)pokemonDetails["isMythical"] == 1 ? "Mythical" : (int)pokemonDetails["isLegendary"] == 1 ? "Legendary" : "common";
            description = (string)pokemonDetails["description"];
            isActive = (int)pokemonDetails["isAvailable"] == 1;
        }

        public void setGenders(List<float?> genders) 
        {
            this.male_gender_rate = (float)genders[0];
            this.female_gender_rate = (float)genders[1];
            
        }
    }
}

﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class Pokemon
    {
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
        public bool male_gender { get; set; }
        [Required]
        public bool female_gender { get; set; }
        [Required]
        public string rarity { get; set; }
        [Required]
        public string img_front { get; set; }
        [Required]
        public string img_back { get; set; }
        [Required]
        public string description { get; set; }
    }
}
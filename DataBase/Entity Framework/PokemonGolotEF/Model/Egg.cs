﻿using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class Egg
    {
        [Key]
        public double km_egg { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string image { get; set; }
    }
}

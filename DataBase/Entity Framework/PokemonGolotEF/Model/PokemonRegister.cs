using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class PokemonRegister
    {
        [ForeignKey("Pokemon")]
        public int pokemon { get; set; }
        [ForeignKey("User")]
        public string user { get; set; }
        [Required]
        public bool sawed { get; set; }
        public char gender { get; set; }
        public double weight { get; set; }
        public int height { get; set; }
        [Required]
        public int capturedNumber { get; set; }




        [ForeignKey("pokemon")]
        public virtual Pokemon Pokemon { get; set; }
        [ForeignKey("user")]
        public virtual User User { get; set; }  
    }
}

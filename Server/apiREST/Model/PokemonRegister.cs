using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class PokemonRegister
    {
        [ForeignKey("Pokemon")]
        public int? pokemon { get; set; }
        [ForeignKey("Player")]
        public string? player { get; set; }
        [Required]
        public bool? sawed { get; set; }
        public char? gender { get; set; }
        public double? weight { get; set; }
        public double? height { get; set; }
        [Required]
        public int? capturedNumber { get; set; }




        [ForeignKey("pokemon")]
        public virtual Pokemon? Pokemon { get; set; }
        [ForeignKey("player")]
        public virtual Player? Player { get; set; }  
    }
}

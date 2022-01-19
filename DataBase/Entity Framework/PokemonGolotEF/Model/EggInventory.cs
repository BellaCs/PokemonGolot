using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class EggInventory
    {
        [ForeignKey("Egg")]
        public double egg { get; set; }
        [ForeignKey("Player")]
        public string player { get; set; }
        public double remaining_km { get; set; }


        [ForeignKey("player")]
        public virtual Player Player { get; set; }
        [ForeignKey("egg")]
        public virtual Egg Egg { get; set; }
    }
}

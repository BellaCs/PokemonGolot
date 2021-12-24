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
        public double remainingKm { get; set; }


        [ForeignKey("player")]
        public virtual User Player { get; set; }
        [ForeignKey("egg")]
        public virtual Egg Egg { get; set; }
    }
}

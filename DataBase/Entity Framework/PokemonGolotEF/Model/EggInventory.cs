using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class EggInventory
    {
        [ForeignKey("Egg")]
        public double egg { get; set; }
        [ForeignKey("User")]
        public string user { get; set; }
        public double remainingKm { get; set; }


        [ForeignKey("user")]
        public virtual User User { get; set; }
        [ForeignKey("egg")]
        public virtual Egg Egg { get; set; }
    }
}

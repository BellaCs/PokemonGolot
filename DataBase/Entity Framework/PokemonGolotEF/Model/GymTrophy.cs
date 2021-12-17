using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class GymTrophy
    {
        [ForeignKey("Gym")]
        public string gym { get; set; }
        [ForeignKey("User")]
        public string user { get; set; }
        public int fights_won { get; set; }
        public int pokemon_time { get; set; } // in seconds
        public int times_feeded { get; set; }



        [ForeignKey("gym")]
        public virtual Gym Gym { get; set; }
        [ForeignKey("user")]
        public virtual User User { get; set; }
    }
}

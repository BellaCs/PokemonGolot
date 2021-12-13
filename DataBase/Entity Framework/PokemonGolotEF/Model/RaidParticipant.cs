using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class RaidParticipant
    {
        [ForeignKey("Gym")]
        public string gym { get; set; }
        [ForeignKey("User")]
        public string user { get; set; }



        [ForeignKey("gym")]
        public virtual Gym Gym { get; set; }
        [ForeignKey("user")]
        public virtual User User { get; set; }
    }
}

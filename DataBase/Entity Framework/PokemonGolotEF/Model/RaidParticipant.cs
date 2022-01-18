using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class RaidParticipant
    {
        [ForeignKey("Gym")]
        public string gym { get; set; }
        [ForeignKey("Player")]
        public string player { get; set; }



        [ForeignKey("gym")]
        public virtual Gym Gym { get; set; }
        [ForeignKey("player")]
        public virtual Player Player { get; set; }
    }
}

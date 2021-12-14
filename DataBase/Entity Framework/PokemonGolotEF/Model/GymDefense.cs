using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class GymDefense
    {
        [ForeignKey("Gym")]
        public string gym { get; set; }  
        [ForeignKey("Pokemon")]
        public int pokemon { get; set; }
        public int defenseTime { get; set; }
        public int timesFeeded { get; set; }
        

        [ForeignKey("gym")]
        public virtual Gym Gym { get; set; }
        [ForeignKey("pokemon")]
        public virtual Pokemon Pokemon { get; set; }
    }
}

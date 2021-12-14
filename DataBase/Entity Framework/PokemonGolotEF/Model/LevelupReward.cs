using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class LevelupObjectReward
    {
        [ForeignKey("Level")]
        public short level { get; set; }
        [ForeignKey("ObjectReference")]
        public string object_name { get; set; }
        [Required]
        public int quantity { get; set; }


        [ForeignKey("level")]
        public virtual Level Level { get; set; }
        [ForeignKey("object_name")]
        public virtual Object Object { get; set; }

    }
}

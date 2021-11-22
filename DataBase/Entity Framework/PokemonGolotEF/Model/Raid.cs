using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace PokemonGolotEF.Model
{
    class Raid
    {
        [Key]
        [ForeignKey("Gym")]
        public string location { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        [ForeignKey("Pokemon")]
        public int boss { get; set; }

        [ForeignKey("boss")]
        public virtual Pokemon Pokemon { get; set; }
        [ForeignKey("location")]
        public virtual Gym Gym { get; set; }
    }
}

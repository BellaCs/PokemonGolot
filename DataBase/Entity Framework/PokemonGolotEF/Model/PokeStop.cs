using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokemonGolotEF.Model
{
    class PokeStop
    {

        public PokeStop()
        {
            presents = new HashSet<Present>();
        }

        [Key]
        public string location { get; set; }
        [Required]
        public string name { get; set; }


        public virtual ICollection<Present> presents { get; set; }

    }
}

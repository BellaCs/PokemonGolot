using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    internal class Egg
    {
        public Egg() 
        {
            //PokemonPool = new HashSet<Pokemon>();
        }

        [Key]
        public double km_egg { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string image { get; set; }

        //public virtual ICollection<Pokemon> PokemonPool { get; set; }
    }
}

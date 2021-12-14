using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class PokemonLevel
    {
        public PokemonLevel()
        {
            pokemons = new HashSet<PokemonOwned>();
        }
        [Key]
        public float pokemon_level { get; set; }
        [Required]
        public double pc_multiplier { get; set; }
        [Required]
        public int stardust_to_upgrade { get; set; }
        [Required]
        public int candy_to_upgrade { get; set; }


        public virtual ICollection<PokemonOwned> pokemons { get; set; }
    }
}

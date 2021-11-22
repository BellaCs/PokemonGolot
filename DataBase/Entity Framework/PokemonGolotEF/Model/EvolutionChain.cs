using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class EvolutionChain
    {
        
        [ForeignKey("PokemonBase")]
        public int pokemon_base { get; set; }
        [ForeignKey("PokemonEvolved")]
        public int pokemon_evolved { get; set; }
        [Required]
        public int candy_needed { get; set; }


        [ForeignKey("pokemon_base")]
        public virtual Pokemon PokemonBase { get; set; }
        [ForeignKey("pokemon_evolved")]
        public virtual Pokemon PokemonEvolved { get; set; }
    }
}

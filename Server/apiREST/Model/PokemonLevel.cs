using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class PokemonLevel
    {
        public PokemonLevel()
        {
            pokemons = new HashSet<PokemonOwned>();
        }

        [Key]
        public float? pokemon_level { get; set; }
        [Required]
        public double? cp_multiplier { get; set; }
        [Required]
        public int? stardust_to_upgrade { get; set; }
        [Required]
        public int? candy_to_upgrade { get; set; }


        public virtual ICollection<PokemonOwned> pokemons { get; set; }
    }
}

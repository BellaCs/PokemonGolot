using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class Pokemon_level
    {
        [Key]
        public float pokemon_level { get; set; }
        [Required]
        public double pc_multiplier { get; set; }
        [Required]
        public int stardust_to_upgrade { get; set; }
        [Required]
        public int candy_to_upgrade { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class PokeStop
    {
        [Key]
        public string location { get; set; }
        [Required]
        public string image { get; set; }

    }
}

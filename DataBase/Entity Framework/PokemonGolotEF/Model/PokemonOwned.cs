using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class PokemonOwned
    {
        [Key]
        public int pokemonId { get; set; }
        [ForeignKey("Pokemon")]
        [Required]
        public int pokemon { get; set; }
        [ForeignKey("Owner")]
        [Required]
        public string owner { get; set; }
        [Required]
        public int atack_iv { get; set; }
        [Required]
        public int stamina_iv { get; set; }
        [Required]
        public int defense_iv { get; set; }
        [Required]
        public string name { get; set; }
        [ForeignKey("Level")]
        [Required]
        public float level { get; set; }

        [ForeignKey("pokemon")]
        public virtual Pokemon Pokemon { get; set; }
        [ForeignKey("owner")]
        public virtual User Owner { get; set; }
        [ForeignKey("level")]
        public virtual PokemonLevel Level { get; set; }

    }
}

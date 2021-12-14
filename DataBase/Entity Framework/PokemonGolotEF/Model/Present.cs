using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class Present
    {
        [Key]
        public int presentId { get; set; }
        [ForeignKey("Owner")]
        [Required]
        public string owner { get; set; }
        [ForeignKey("PokeStop")]
        [Required]
        public string pokeStop { get; set; }
        [ForeignKey("Receptor")]
        public string receptor { get; set; }
        [Required]
        public bool opened { get; set; }
        [Required]
        public DateTime getDate { get; set; }
        public DateTime sendDate { get; set; } 


        [ForeignKey("owner")]
        public virtual User Owner { get; set; }
        [ForeignKey("pokeStop")]
        public virtual PokeStop PokeStop { get; set; }
        [ForeignKey("receptor")]
        public virtual User Receptor { get; set; }

    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class User
    {
        [Key]
        [StringLength(20)]
        public string user_name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("Team")]
        public string team_name { get; set; }
        public char gender { get; set; }
        [Required]
        [ForeignKey("Level")]
        public short level { get; set; }
        public DateTime birth_date { get; set; }
        [Required]
        public int inventory_capacity { get; set; }
        [Required]
        public int remaining_experience { get; set; }
        [Required]
        public int pokemon_slots { get; set; }
        public int won_battles { get; set; }
        public int caputred_pokemon { get; set; }






        [ForeignKey("team_name")]
        public virtual Team Team { get; set; }
        [ForeignKey("level")]
        public virtual Level Level { get; set; }

    }
}

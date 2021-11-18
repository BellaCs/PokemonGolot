
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class Gym
    {
        [Key]
        [ForeignKey("PokeStop")]
        public string location { get; set; }
        [Required]
        public string name { get; set; }
        [ForeignKey("Team")]
        public string team_name { get; set; }





        [ForeignKey("location")]
        public virtual PokeStop PokeStop { get; set; }
        [ForeignKey("team_name")]
        public virtual Team Team { get; set; }
    }
}

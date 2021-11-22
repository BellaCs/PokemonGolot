
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class Gym
    {

        public Gym()
        {
            raids = new HashSet<Raid>();
        }

        [Key]
        [ForeignKey("PokeStop")]
        public string location { get; set; }
        [Required]
        public string name { get; set; }
        [ForeignKey("Team")]
        public string team { get; set; }





        [ForeignKey("location")]
        public virtual PokeStop PokeStop { get; set; }
        [ForeignKey("team")]
        public virtual Team Team { get; set; }
        public virtual ICollection<Raid> raids { get; set; }
    }
}

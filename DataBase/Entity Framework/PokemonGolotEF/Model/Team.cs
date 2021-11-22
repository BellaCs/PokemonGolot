using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokemonGolotEF.Model
{
    class Team
    {
        public Team()
        {
            Users = new HashSet<User>();
            Gyms = new HashSet<Gym>();
        }

        [Key]
        public string name { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public string image { get; set; }


        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Gym> Gyms { get; set; }
    }
}

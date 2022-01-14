using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace apiREST.Model
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<User>();
            Gyms = new HashSet<Gym>();
        }

        [Key]
        public string? name { get; set; }
        [Required]
        public string? color { get; set; }
        [Required]
        public string? image { get; set; }


        public virtual ICollection<User> Players { get; set; }
        public virtual ICollection<Gym> Gyms { get; set; }
    }
}

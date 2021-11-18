using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokemonGolotEF.Model
{
    class Level
    {

        public Level()
        {
            users = new HashSet<User>();
        }

        [Key]
        public short level { get; set; }
        [Required]
        public int necessary_xp { get; set; }



        public virtual ICollection<User> users { get; set; }
    }
}

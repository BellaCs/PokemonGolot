using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    public class PlayerRol
    {
        [Key]
        public string rol { get; set; }
        

        ICollection<Player> players { get; set; }
    }
}

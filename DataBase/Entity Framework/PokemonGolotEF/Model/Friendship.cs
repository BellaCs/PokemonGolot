using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class Friendship
    {
        [ForeignKey("User")]
        public string user { get; set; }
        [ForeignKey("Friend")]
        public string friend { get; set; }

        [ForeignKey("user")]
        public virtual User User { get; set; }
        [ForeignKey("friend")]
        public virtual User Friend { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class Friendship
    {
        [ForeignKey("Player")]
        public string player { get; set; }
        [ForeignKey("Friend")]
        public string friend { get; set; }

        [ForeignKey("player")]
        public virtual Player Player { get; set; }
        [ForeignKey("friend")]
        public virtual Player Friend { get; set; }
    }
}

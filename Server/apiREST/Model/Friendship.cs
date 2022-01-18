using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class Friendship
    {
        [ForeignKey("Player")]
        public string? player { get; set; }
        [ForeignKey("Friend")]
        public string? friend { get; set; }

        [ForeignKey("player")]
        public virtual User? Player { get; set; }
        [ForeignKey("friend")]
        public virtual User? Friend { get; set; }
    }
}

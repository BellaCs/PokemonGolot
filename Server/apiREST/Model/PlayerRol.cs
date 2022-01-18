using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class PlayerRol
    {
        [Key]
        public string? rol { get; set; }
        

        ICollection<Player>? players { get; set; }
    }
}

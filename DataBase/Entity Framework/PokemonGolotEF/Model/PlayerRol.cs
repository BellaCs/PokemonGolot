using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    public class PlayerRol
    {
        public PlayerRol() 
        {
            users = new HashSet<User>();
        }

        public PlayerRol(JToken newRol) 
        {
            this.rol = newRol["name"].ToString();
        }

        [Key]
        public string rol { get; set; }
        

        ICollection<User> users { get; set; }
    }
}

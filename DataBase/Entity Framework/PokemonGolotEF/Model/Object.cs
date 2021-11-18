using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace PokemonGolotEF.Model
{
    class Object
    {
        [Key]
        public string name { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public string description { get; set; }
    }
}

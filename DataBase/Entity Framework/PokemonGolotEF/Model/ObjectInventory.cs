using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class ObjectInventory
    {
        [ForeignKey("Object")]
        public string objectName { get; set; }
        [ForeignKey("User")]
        public string user { get; set; }
        [Required]
        public int quantity { get; set; }


        [ForeignKey("objectName")]
        public virtual Object Object { get; set; }
        [ForeignKey("user")]
        public virtual User User { get; set; }

    }
}

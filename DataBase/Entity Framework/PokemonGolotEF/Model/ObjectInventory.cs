using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class ObjectInventory
    {
        [ForeignKey("Object")]
        public string objectName { get; set; }
        [ForeignKey("Player")]
        public string player { get; set; }
        [Required]
        public int quantity { get; set; }


        [ForeignKey("objectName")]
        public virtual Object Object { get; set; }
        [ForeignKey("player")]
        public virtual User Player { get; set; }

    }
}

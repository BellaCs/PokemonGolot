using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class PackageItems
    {
       [ForeignKey("Object")]
       public string object_name { get; set; }
        [ForeignKey("Package")]
        public string package { get; set; }
        [Required]
        public int quantity { get; set; }


        [ForeignKey("object_name")]
        public Object Object { get; set; }
        [ForeignKey("package")]
        public PackageOffer Package { get; set; }
    }
}

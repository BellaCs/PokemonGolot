using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    internal class PackageItems
    {
       [ForeignKey("Object")]
       public string objectName { get; set; }
        [ForeignKey("Package")]
        public string package { get; set; }
        [Required]
        public int units { get; set; }


        [ForeignKey("objectName")]
        public Object Object { get; set; }
        [ForeignKey("package")]
        public PackageOffer Package { get; set; }
    }
}

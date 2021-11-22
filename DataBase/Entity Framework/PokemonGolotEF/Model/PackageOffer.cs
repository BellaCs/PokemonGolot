using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class PackageOffer
    {
        [Key]
        public string name { get; set; }
        public double price { get; set; }
        public bool active { get; set; }
    }
}

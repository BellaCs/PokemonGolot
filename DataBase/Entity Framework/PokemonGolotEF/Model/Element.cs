using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    class Element
    {
        [Key]
        public string name { get; set; }
        public string image { get; set; }


    }
}

using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace PokemonGolotEF.Model
{
    internal class Element
    {
        public Element() 
        {
            
        }

        public Element(JToken element) 
        {
            this.name = element["name"].ToString();
        }

        [Key]
        public string name { get; set; }
        public string image { get; set; }


    }
}

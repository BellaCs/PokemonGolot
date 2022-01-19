using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class Movement
    {
        public Movement() { }
        public Movement(JToken movementJson, List<Element> elements)
        {
            this.name = (string)movementJson["name"];
            this.power = (int)movementJson["power"];
            this.duration = (int)movementJson["duration"];
            this.energy = (double)movementJson["energy"];
            this.isCharged = (int)movementJson["isQuickMove"] == 0;
            foreach (var element in elements) {
                if (element.name.ToLower().Equals((string)movementJson["type"])) 
                {
                    
                    this.element = element.name;
                }
            }
        }

        [Required]
        public string name { get; set; }
        [ForeignKey("Element")]
        [Required]
        public string element { get; set; }
        [Required]
        public bool isCharged { get; set; }
        [Required]
        public int power { get; set; }
        [Required]
        public int duration { get; set; } // in millisec
        [Required]
        public double energy { get; set; }



        [ForeignKey("element")]
        public virtual Element Element { get; set; }
    }
}

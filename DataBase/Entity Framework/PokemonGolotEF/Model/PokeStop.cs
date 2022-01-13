using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;

namespace PokemonGolotEF.Model
{
    class PokeStop
    {
        public PokeStop()
        {
            presents = new HashSet<Present>();
        }
        public PokeStop(KeyValuePair<String, JToken> pokestopData) 
        {
            location = pokestopData.Value["lat"].ToString() + "#"+pokestopData.Value["lng"].ToString();
            name = pokestopData.Value["name"].ToString(); 
        }


        [Key]
        public string location { get; set; } // latitude#longitude
        [Required]
        public string name { get; set; }


        public virtual ICollection<Present> presents { get; set; }

    }
}

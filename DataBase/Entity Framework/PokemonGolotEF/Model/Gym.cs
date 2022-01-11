using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json.Linq;
using System;

namespace PokemonGolotEF.Model
{
    class Gym
    {

        public Gym()
        {
            raids = new HashSet<Raid>();
            defensors = new HashSet<GymDefense>();
        }

        public Gym(KeyValuePair<String, JToken> pokestopData)
        {
            location = pokestopData.Value["lat"].ToString() + "#" + pokestopData.Value["lng"].ToString();
        }

        [Key]
        [ForeignKey("PokeStop")]
        public string location { get; set; }
        [ForeignKey("Team")]
        public string team { get; set; }



        [ForeignKey("location")]
        public virtual PokeStop PokeStop { get; set; }
        [ForeignKey("team")]
        public virtual Team Team { get; set; }
        public virtual ICollection<Raid> raids { get; set; }
        public virtual ICollection<GymDefense> defensors { get; set; }
      
    }
}

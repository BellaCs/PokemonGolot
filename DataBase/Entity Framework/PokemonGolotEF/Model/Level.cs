using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;

namespace PokemonGolotEF.Model
{
    class Level
    {

        public Level()
        {
            users = new HashSet<Player>();
            rewards = new HashSet<LevelupObjectReward>();
        }

        public Level(KeyValuePair<String, JToken> levelJson)  
        {

            level = Convert.ToInt16(levelJson.Key);
            necessary_xp = (int)levelJson.Value;

        }

        [Key]
        public short level { get; set; }
        [Required]
        public int necessary_xp { get; set; }



        public virtual ICollection<Player> users { get; set; }
        public virtual ICollection<LevelupObjectReward> rewards { get; set; }

    }

   
}

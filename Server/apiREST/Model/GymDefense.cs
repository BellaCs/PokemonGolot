using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class GymDefense
    {
        [ForeignKey("Gym")]
        public string? gym { get; set; }  
        [ForeignKey("Pokemon")]
        public int? pokemon { get; set; }
        public int? defense_time { get; set; } // seconds
        public int? times_feeded { get; set; }
        

        [ForeignKey("gym")]
        public virtual Gym? Gym { get; set; }
        [ForeignKey("pokemon")]
        public virtual Pokemon? Pokemon { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace apiREST.Model
{
    public class Objects
    {
        Objects()
        {
            levels = new HashSet<LevelupObjectReward>();
        }


        [Key]
        public string? name { get; set; }
        [Required]
        public string? type { get; set; }
        [Required]
        public string? description { get; set; }


        public virtual ICollection<LevelupObjectReward> levels { get; set;}
    }
}

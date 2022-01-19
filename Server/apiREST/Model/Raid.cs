using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace apiREST.Model
{
    public class Raid
    {
        public Raid()
        {
            Participants = new HashSet<RaidParticipant>();
        }

        [Key]
        [ForeignKey("Gym")]
        public string? location { get; set; }
        [Required]
        public string? type { get; set; }
        [Required]
        [ForeignKey("Pokemon")]
        public int? boss { get; set; }

        [ForeignKey("boss")]
        public virtual Pokemon? Pokemon { get; set; }
        [ForeignKey("location")]
        public virtual Gym? Gym { get; set; }


        public virtual ICollection<RaidParticipant> Participants { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class Level
    {

        public Level()
        {
            users = new HashSet<Player>();
            rewards = new HashSet<LevelupObjectReward>();
        }

        [Key]
        public short? level { get; set; }
        [Required]
        public int? necessary_xp { get; set; }



        public virtual ICollection<Player> users { get; set; }
        public virtual ICollection<LevelupObjectReward> rewards { get; set; }

    }

   
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace apiREST.Model
{
    public class Gym
    {

        public Gym()
        {
            raids = new HashSet<Raid>();
            defensors = new HashSet<GymDefense>();
        }

        [Key]
        [ForeignKey("PokeStop")]
        public string? location { get; set; }
        [ForeignKey("Team")]
        public string? team { get; set; }



        [ForeignKey("location")]
        public virtual PokeStop? PokeStop { get; set; }
        [ForeignKey("team")]
        public virtual Team? Team { get; set; }
        public virtual ICollection<Raid> raids { get; set; }
        public virtual ICollection<GymDefense> defensors { get; set; }
      
    }
}

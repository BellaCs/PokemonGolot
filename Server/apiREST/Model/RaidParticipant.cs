using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class RaidParticipant
    {
        [ForeignKey("Gym")]
        public string? gym { get; set; }
        [ForeignKey("Player")]
        public string? player { get; set; }



        [ForeignKey("gym")]
        public virtual Gym? Gym { get; set; }
        [ForeignKey("player")]
        public virtual User? Player { get; set; }
    }
}

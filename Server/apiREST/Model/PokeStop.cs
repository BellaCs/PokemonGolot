using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class PokeStop
    {
        public PokeStop()
        {
            presents = new HashSet<Present>();
        }


        [Key]
        public string? location { get; set; } // latitude#longitude
        [Required]
        public string? name { get; set; }


        public virtual ICollection<Present> presents { get; set; }

    }
}

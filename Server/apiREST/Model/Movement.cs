using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class Movement
    {

        [Required]
        public string? name { get; set; }
        [ForeignKey("Element")]
        [Required]
        public string? element { get; set; }
        [Required]
        public bool? isCharged { get; set; }
        [Required]
        public int? power { get; set; }
        [Required]
        public int? duration { get; set; } // in millisec
        [Required]
        public double? energy { get; set; }



        [ForeignKey("element")]
        public virtual Element? Element { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class Present
    {
        [Key]
        public int? present_id { get; set; }
        [ForeignKey("Owner")]
        [Required]
        public string? owner { get; set; }
        [ForeignKey("PokeStop")]
        [Required]
        public string? pokestop { get; set; }
        [ForeignKey("Receptor")]
        public string? receptor { get; set; }
        [Required]
        public bool? opened { get; set; }
        [Required]
        public DateTime get_date { get; set; }
        public DateTime send_date { get; set; } 


        [ForeignKey("owner")]
        public virtual User? Owner { get; set; }
        [ForeignKey("pokestop")]
        public virtual PokeStop? PokeStop { get; set; }
        [ForeignKey("receptor")]
        public virtual User? Receptor { get; set; }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class TypeTable
    {
        [ForeignKey("Element")]
        public string? element { get; set; }
        [ForeignKey("Affected_element")]
        public string? affected_element { get; set; }
        [Required]
        public double? multiplier { get; set; }

        [ForeignKey("element")]
        public virtual Element? Element { get; set; }
        [ForeignKey("affected_element")]
        public virtual Element? Affected_element { get; set; }
        
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class ObjectInventory
    {
        [ForeignKey("Object")]
        public string? object_name { get; set; }
        [ForeignKey("Player")]
        public string? player { get; set; }
        [Required]
        public int? quantity { get; set; }


        [ForeignKey("object_name")]
        public virtual Objects? Object { get; set; }
        [ForeignKey("player")]
        public virtual Player? Player { get; set; }

    }
}

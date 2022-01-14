using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class Player
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string? user_name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? password { get; set; }
        public char gender { get; set; }
        public DateTime birth_date { get; set; }
        [ForeignKey("Rol")]
        public string? rol { get; set; }
        [ForeignKey("rol")]
        public virtual PlayerRol? Rol { get; set; }
    }

    public class PlayerLogin
    {
        [Required]
        public string? user_name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }
    }
}

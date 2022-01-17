using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGolotEF.Model
{
    internal class Player
    {
        [Key]
        [StringLength(20)]
        public string user_name { get; set; }
        [Index(IsUnique = true)]
        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        public string gender { get; set; }
        public DateTime birth_date { get; set; }
        [ForeignKey("Rol")]
        public string rol { get; set; }
        [ForeignKey("rol")]
        public virtual PlayerRol Rol { get; set; }
    }
}

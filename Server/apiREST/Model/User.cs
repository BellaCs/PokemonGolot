using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class User
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
        public string? gender { get; set; }
        public DateTime birth_date { get; set; }
        [ForeignKey("Rol")]
        public string? rol { get; set; }
        [ForeignKey("rol")]
        public virtual PlayerRol? Rol { get; set; }

        /// <summary>
        /// Custom user extension that converts a user object to simple data response user
        /// </summary>
        /// <returns></returns>

        public SimpleUserData toSimpleResponseUserData()
        {
            SimpleUserData response = new SimpleUserData();

            response.name = name;
            response.email = email;
            response.user_name = user_name;

            return response;
        }
    }

    public class GlobalUserRegister
    {
        [Required]
        public string? user_name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? password { get; set; }
        public string? gender { get; set; }
        public DateTime birth_date { get; set; }
        public string? rol { get; set; }
    }

    public class UserLogin
    {
        [Required]
        public string? user_name { get; set; }
        [Required]
        public string? password { get; set; }
    }

    public class UserRegister
    {
        [Required]
        public string? user_name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? password { get; set; }
        public string? gender { get; set; }
        public DateTime birth_date { get; set; }
    }

    public class SimpleUserData
    {
        public string? user_name { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? email { get; set; }
        
    }

    public class ResponseUser
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string? User_name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public DateTime Birth_date { get; set; }
    }

}

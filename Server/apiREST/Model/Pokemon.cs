using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class Pokemon
    {
        public Pokemon() 
        {
            
        }

      
        [Key]
        public int? num_pokedex { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public double? attack { get; set; }
        [Required]
        public double? stamina { get; set; }
        [Required]
        public double? defense { get; set; }
        [Required]
        public string? rarity { get; set; }
        [Required]
        public string? img_front { get; set; }
        public string? img_front_female { get; set; }
        [Required]
        public string? img_back { get; set; }  
        public string? img_back_female { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public float? male_gender_rate { get; set; } //%
        [Required]
        public float? female_gender_rate { get; set; }  //%
        [Required]
        public bool? isActive { get; set; }


    }
}

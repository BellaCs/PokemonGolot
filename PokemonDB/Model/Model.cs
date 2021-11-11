using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace VSProjects.Model
{


    public class Pokemon
    {
        [Key]
        [Column(TypeName ="integer")]
        public string num_pokedex {get; set;}

        [Required]  
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}

        [Required]  
        [Column(TypeName ="integer")]
        public string attack {get; set;}

        [Required]  
        [Column(TypeName ="integer")]
        public string stamina {get; set;}

        [Required]  
        [Column(TypeName ="integer")]
        public string defense {get; set;}

        [Required]  
        [Column(TypeName ="boolean")]
        public string male_gender {get; set;}
        
        [Required]  
        [Column(TypeName ="boolean")]
        public string female_gender {get; set;}

        [Required]  
        [Column(TypeName ="varchar(20)")]
        public string rarity {get; set;}

        [Required]  
        [Column(TypeName ="varchar(100)")]
        public string img_front {get; set;}

        [Required]  
        [Column(TypeName ="varchar(100)")]
        public string img_back {get; set;}

        [Required]  
        [Column(TypeName ="varchar(500)")]
        public string description {get; set;}
    }

    public class User
    {
        [Key]
        [Column(TypeName ="varchar(20)")]
        public string username {get; set;}

        [Required]  
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}

        [Required]  
        [Column(TypeName = "varchar(30)")]
        public string password {get; set;}

        [Required]  
        [Column(TypeName = "varchar(10)")]
        public string team {get; set;}

        [Required]  
        [Column(TypeName = "char")]
        public string gender {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string actual_level {get; set;}

        [Required]  
        [Column(TypeName = "datetime")]
        public string birth_date {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string inventory_capacity {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string remaining_experience {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string pokemon_capacity {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string win_battles {get; set;}

        [Required]  
        [Column(TypeName = "integer")]
        public string captured_pokemons {get; set;}
    }    

    public class Object
    {
        [Key]
        [Column(TypeName ="varchar(25)")]
        public string name {get; set;}

        [Required]  
        [Column(TypeName ="varchar(100)")]
        public string type {get; set;}

        [Required]  
        [Column(TypeName ="varchar(150)")]
        public string description {get; set;}
    }
    
    public class Gym
    {
        [Key]
        [Column(TypeName ="varchar(25)")]
        public string location {get; set;}

        [Required]  
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}

        [Column(TypeName ="varchar(20)")]
        public string team {get; set;}
    }

    public class Raid
    {
        [Key]
        [Column(TypeName ="varchar(25)")]
        public string location {get; set;}

        [Required]  
        [Column(TypeName ="varchar(30)")]
        public string type {get; set;}

        [Column(TypeName ="varchar(30)")]
        public string boss {get; set;}
    }

    public class Element
    {
        [Key]
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}
    }

    public class Evolution_chain
    {
        [Key]
        [Column(TypeName ="integer")]
        public string pokemon_base {get; set;}
        [Key]
        [Column(TypeName ="integer")]
        public string evolve_to {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string candy_needed {get; set;}
    }

    public class Pokestop
    {
        [Key]
        [Column(TypeName ="varchar(25)")]
        public string location {get; set;}

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string image {get; set;}
    }

    public class Team
    {
        [Key]
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string color {get; set;}

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string image {get; set;}
    }

    public class Egg
    {
        [Key]
        [Column(TypeName ="integer")]
        public string km_egg {get; set;}

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string description {get; set;}

        [Required]
        [Column(TypeName ="varchar(100)")]
        public string image {get; set;}
    }

    public class Level
    {
        [Key]
        [Column(TypeName ="integer")]
        public string level {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string necessary_xp {get; set;}
    }
    public class Package_offer
    {
        [Key]
        [Column(TypeName ="varchar(20)")]
        public string package_name {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string price {get; set;}

        [Required]
        [Column(TypeName ="boolean")]
        public string active {get; set;}
    }

    public class Movement
    {
        [Key]
        [Column(TypeName ="varchar(20)")]
        public string name {get; set;}

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string element {get; set;}

        [Required]
        [Column(TypeName ="varchar(20)")]
        public string type {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string power {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string duration {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string energy {get; set;}
    }

    public class Pokemon_level
    {
        [Key]
        [Column(TypeName ="integer")]
        public string pokemon_level {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string pc_multiplier {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string stardust_to_upgrade {get; set;}

        [Required]
        [Column(TypeName ="integer")]
        public string candy_to_upgrade {get; set;}
    }

}
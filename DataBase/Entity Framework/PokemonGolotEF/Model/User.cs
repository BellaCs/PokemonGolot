using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonGolotEF.Model
{
    class User
    {
        public User() 
        {
            recivedPresents = new HashSet<Present>();
            presentsToSend = new HashSet<Present>();
            raidsParticipated = new HashSet<RaidParticipant>();
            pokemons = new HashSet<PokemonOwned>();
            friends = new HashSet<Friendship>();
            pokedex = new HashSet<PokemonRegister>();
            eggs = new HashSet<EggInventory>();
            packagesOfferBought = new HashSet<PackageOfferBought>();
            inventory = new HashSet<ObjectInventory>();
        }

        [Key]
        [StringLength(20)]
        public string user_name { get; set; }
        [Index(IsUnique =true)]
        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string password { get; set; }
        [ForeignKey("Team")]
        public string team { get; set; }
        public char gender { get; set; }
        [Required]
        [ForeignKey("Level")]
        public short level { get; set; }
        public DateTime birth_date { get; set; }
        [Required]
        public int inventory_capacity { get; set; }
        [Required]
        public int remaining_experience { get; set; }
        [Required]
        public int pokemon_slots { get; set; }
        public int won_battles { get; set; }
        public int caputred_pokemon { get; set; }






        [ForeignKey("team")]
        public virtual Team Team { get; set; }
        [ForeignKey("level")]
        public virtual Level Level { get; set; }

        public virtual ICollection<Present> recivedPresents { get; set; }
        public virtual ICollection<Present> presentsToSend { get; set; }
        public virtual ICollection<RaidParticipant> raidsParticipated { get; set; }
        public virtual ICollection<PokemonOwned> pokemons { get; set; }
        public virtual ICollection<Friendship> friends { get; set; }
        public virtual ICollection<PokemonRegister> pokedex { get; set; }
        public virtual ICollection<EggInventory> eggs { get; set; }
        public virtual ICollection<PackageOfferBought> packagesOfferBought { get; set; }
        public virtual ICollection<ObjectInventory> inventory { get; set; }

    }
}

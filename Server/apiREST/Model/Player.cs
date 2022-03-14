using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class Player
    {
        public Player()
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
            trophys = new HashSet<GymTrophy>();
        }

        [Key]
        [ForeignKey("Player")]
        [StringLength(20)]
        public string? user_name { get; set; }
        [ForeignKey("Team")]
        public string? team { get; set; }
        [Required]
        [ForeignKey("Level")]
        public short? level { get; set; }
        [Required]
        public int? inventory_capacity { get; set; }
        [Required]
        public int? current_level_experience { get; set; }
        [Required]
        public int? experience { get; set; }
        [Required]
        public int? pokemon_slots { get; set; }
        public int? won_battles { get; set; }
        public int? caputred_pokemon { get; set; }






        [ForeignKey("team")]
        public virtual Team? Team { get; set; }
        [ForeignKey("level")]
        public virtual Level? Level { get; set; }
        [ForeignKey("user_name")]
        public virtual User? User { get; set; }

        public virtual ICollection<Present> recivedPresents { get; set; }
        public virtual ICollection<Present> presentsToSend { get; set; }
        public virtual ICollection<RaidParticipant> raidsParticipated { get; set; }
        public virtual ICollection<PokemonOwned> pokemons { get; set; }
        public virtual ICollection<Friendship> friends { get; set; }
        public virtual ICollection<PokemonRegister> pokedex { get; set; }
        public virtual ICollection<EggInventory> eggs { get; set; }
        public virtual ICollection<PackageOfferBought> packagesOfferBought { get; set; }
        public virtual ICollection<ObjectInventory> inventory { get; set; }
        public virtual ICollection<GymTrophy> trophys { get; set; }

    }

    public class ResponsePlayer
    {
        public string? Team { get; set; }
        [Required]
        public short? Level { get; set; }
        [Required]
        public int? Inventory_capacity { get; set; }
        [Required]
        public int? Current_level_experience { get; set; }
        [Required]
        public int? Experience { get; set; }
        [Required]
        public int? Pokemon_slots { get; set; }
        public int? Won_battles { get; set; }
        public int? Caputred_pokemon { get; set; }
    }
}

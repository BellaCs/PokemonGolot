using Microsoft.EntityFrameworkCore;
using PokemonGolotEF.Model;

namespace PokemonGolotEF.Data
{
    class PokemonGolotDBContext : DbContext
    {
        public PokemonGolotDBContext()
        { 
        }

        public PokemonGolotDBContext(DbContextOptions options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder model) 
        {
            model.Entity<EvolutionChain>().HasKey(nameof(EvolutionChain.pokemon_base), nameof(EvolutionChain.pokemon_evolved));
            model.Entity<Present>().HasOne(p => p.Receptor).WithMany(u => u.recivedPresents);
            model.Entity<Present>().HasOne(p => p.Owner).WithMany(u => u.presentsToSend);
            model.Entity<RaidParticipant>().HasKey(nameof(RaidParticipant.gym), nameof(RaidParticipant.user));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string con = "Host=172.24.127.1;Port=5432;Database=pokemonGolot;Username=dbuser;password=patata123";
                optionsBuilder.UseNpgsql(con);
            }
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Level> Level { get; set; }
        public virtual DbSet<Object> Object { get; set; }
        public virtual DbSet<Pokemon> Pokemon { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<PokeStop> PokeStop { get; set; }
        public virtual DbSet<Gym> Gym { get; set; }
        public virtual DbSet<PokemonLevel> Pokemon_level { get; set; }
        public virtual DbSet<Raid> Raid { get; set; }
        public virtual DbSet<EvolutionChain> Evolution_chain { get; set; }
        public virtual DbSet<Egg> Egg { get; set; }
        public virtual DbSet<PackageOffer> Package_offer { get; set; }
        public virtual DbSet<Movement> Movement { get; set; }
        public virtual DbSet<Present> Present { get; set; }
        public virtual DbSet<RaidParticipant> Raid_participants { get; set; }
        public virtual DbSet<PokemonOwned> Pokemon_owned { get; set; }
    }
}

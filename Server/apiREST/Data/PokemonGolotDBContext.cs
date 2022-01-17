using Microsoft.EntityFrameworkCore;
using apiREST.Model;


namespace apiREST.Data
{
    public class pokemonGolotApi : DbContext
    {

        protected override void OnModelCreating(ModelBuilder model) 
        {
            // Evolution Chain

            model.Entity<EvolutionChain>()
                .HasKey(nameof(EvolutionChain.pokemon_base), nameof(EvolutionChain.pokemon_evolved));

            // Present

            model.Entity<Present>()
                .HasOne(p => p.Receptor)
                .WithMany(u => u.recivedPresents);

            model.Entity<Present>()
                .HasOne(p => p.Owner)
                .WithMany(u => u.presentsToSend);

            // Raid Participant

            model.Entity<RaidParticipant>()
                .HasKey(nameof(RaidParticipant.gym), nameof(RaidParticipant.player));

            // LevelUp Reward

            model.Entity<LevelupObjectReward>()
                .HasKey(nameof(LevelupObjectReward.level), nameof(LevelupObjectReward.object_name));

            // Gym Defensors

            model.Entity<GymDefense>()
                .HasKey(nameof(GymDefense.gym), nameof(GymDefense.pokemon));

            // Friendship

            model.Entity<Friendship>()
                .HasKey(nameof(Friendship.player), nameof(Friendship.friend));

            model.Entity<Friendship>()
                .HasOne(f => f.Friend)
                .WithMany(u => u.friends);

            // Type Table

            model.Entity<TypeTable>()
                .HasKey(nameof(TypeTable.element), nameof(TypeTable.affected_element));

            // Pokemon Register

            model.Entity<PokemonRegister>()
                .HasKey(nameof(PokemonRegister.pokemon), nameof(PokemonRegister.player), nameof(PokemonRegister.gender));

            // Egg Inventory

            model.Entity<EggInventory>()
                .HasKey(nameof(EggInventory.egg), nameof(EggInventory.player));

            // Package Bought 

            model.Entity<PackageOfferBought>()
                .HasKey(nameof(PackageOfferBought.package), nameof(PackageOfferBought.user));

            // Object Inventory

            model.Entity<ObjectInventory>()
                .HasKey(nameof(ObjectInventory.object_name), nameof(ObjectInventory.player));

            // Package items

            model.Entity<PackageItems>()
                .HasKey(nameof(PackageItems.object_name), nameof(PackageItems.package));

            // Trophys

            model.Entity<GymTrophy>()
                .HasKey(nameof(GymTrophy.gym), nameof(GymTrophy.player));

            // Pokemon Exchange

            model.Entity<PokemonExchange>()
                .HasKey(nameof(PokemonExchange.pokemon), nameof(PokemonExchange.ex_owner));

            // Egg Pokemon Pool

            model.Entity<EggPokemonPool>()
                .HasKey(nameof(EggPokemonPool.pokemon), nameof(EggPokemonPool.egg));

            // Movements

            model.Entity<Movement>()
                .HasKey(nameof(Movement.name), nameof(Movement.element));

            // Pokemon Element

            model.Entity<PokemonElement>()
                .HasKey(nameof(PokemonElement.pokemon), nameof(PokemonElement.element));

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string con = "Host=172.24.127.1;Port=5432;Database=pokemonGolot;Username=dbuser;password=patata123";
                string con = "Host=192.168.1.249;Port=5432;Database=pokemonGolot;Username=dbuser;password=patata123";
                optionsBuilder.UseNpgsql(con);
            }
        }

#pragma warning disable CS8618
        public DbSet<User> User { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<apiREST.Model.Egg> Egg { get; set; }
    }
}

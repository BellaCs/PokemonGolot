using Microsoft.EntityFrameworkCore;
using PokemonGolotEF.Model;
using PokemonGolotEF.Library;


namespace PokemonGolotEF.Data
{
    class PokemonGolotDBContext : DbContext
    {
        LoadData data = new LoadData();
        public PokemonGolotDBContext()
        { 
        }

        public PokemonGolotDBContext(DbContextOptions options) : base(options)
        { 
        }

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

            // User Level

            model.Entity<Level>()
                .HasData(data.pokemonGolot.userLevels);

            // Pokemon Level

            model.Entity<PokemonLevel>()
                .HasData(data.pokemonGolot.pokemonsLevels);

            // Element

            model.Entity<Element>()
                .HasData(data.pokemonGolot.elements);

            // Egg Pokemon Pool

            model.Entity<EggPokemonPool>()
                .HasKey(nameof(EggPokemonPool.pokemon), nameof(EggPokemonPool.egg));

            // Pokestop
            model.Entity<PokeStop>()
                .HasData(data.pokemonGolot.pokestops);

            // Gyms
            
            model.Entity<Gym>()
                .HasData(data.pokemonGolot.gyms);

            // Movements

            model.Entity<Movement>()
                .HasKey(nameof(Movement.name), nameof(Movement.element));
            model.Entity<Movement>()
                .HasData(data.pokemonGolot.moves);

            // Pokemon

            model.Entity<Pokemon>()
                .HasData(data.pokemonGolot.pokemons);

            // Pokemon Element

            model.Entity<PokemonElement>()
                .HasKey(nameof(PokemonElement.pokemon), nameof(PokemonElement.element));

            // Player Rols

            model.Entity<PlayerRol>()
                .HasData(data.pokemonGolot.rols);

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

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Player> Player { get; set; }
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
        public virtual DbSet<Movement> Movements { get; set; }
        public virtual DbSet<Present> Present { get; set; }
        public virtual DbSet<RaidParticipant> Raid_participants { get; set; }
        public virtual DbSet<PokemonOwned> Pokemon_owned { get; set; }
        public virtual DbSet<LevelupObjectReward> Levelup_object_rewards { get; set; }
        public virtual DbSet<GymDefense> Gym_defensors { get; set; }
        public virtual DbSet<Friendship> Friendships { get; set; }
        public virtual DbSet<TypeTable> Type_table { get; set; }
        public virtual DbSet<PokemonRegister> Pokemon_register { get; set; }
        public virtual DbSet<EggInventory> Egg_inventory { get; set;}
        public virtual DbSet<PackageOfferBought> Package_offers_bought { get; set; }
        public virtual DbSet<ObjectInventory> Object_inventories { get; set; }
        public virtual DbSet<PackageItems> Package_items { get; set; }
        public virtual DbSet<GymTrophy> Gym_trophies { get; set; }
        public virtual DbSet<PokemonExchange> Pokemon_exchange { get; set;}
        public virtual DbSet<EggPokemonPool> Egg_pokemon_pool { get; set; }
        public virtual DbSet<PokemonElement> Pokemon_element { get; set; }
        public virtual DbSet<PlayerRol> Player_rols { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using VSProjects.Model;


namespace VSProjects.Data
{
    public class Produccio : DbContext
    {

        public DbSet<User> Users {get; set;}
        public DbSet<Pokemon> Pokemons {get; set;}
        public DbSet<Object> Objects {get; set;}
        public DbSet<Gym> Gyms {get; set;}
        public DbSet<Raid> Raids {get; set;}
        public DbSet<Element> Elements {get; set;}
        public DbSet<Evolution_chain> Evolution_chains {get; set;}
        public DbSet<Pokestop> Pokestops {get; set;}
        public DbSet<Team> Teams {get; set;}
        public DbSet<Egg> Eggs {get; set;}
        public DbSet<Level> Levels {get; set;}
        public DbSet<Package_offer> Package_offers {get; set;}
        public DbSet<Movement> Movements {get; set;}
        public DbSet<Pokemon_level> Pokemon_levels {get; set;}














        protected override void OnModelCreating(ModelBuilder mdb)
        {
            //Un producte està format per varis productes
            //mdb.Entity<Producte>().HasMany(p => p.Productes);

           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

            string con = "Host=localhost;Port=5432;Database=Pt2;Username=postgres;password=kiwi12";
            optionsBuilder.UseNpgsql(con);
        }    }

}
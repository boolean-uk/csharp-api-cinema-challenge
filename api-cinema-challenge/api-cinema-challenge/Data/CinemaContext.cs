using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new();
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);

            modelBuilder.Entity<Movie>().Navigation(x => x.Screenings).AutoInclude();
            modelBuilder.Entity<Screening>().Navigation(x => x.Movie).AutoInclude();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }

    }
    
}

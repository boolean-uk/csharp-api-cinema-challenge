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
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            Seeder seeder = new Seeder();
            modelBuilder.Entity<Movies>().
                HasData(seeder.Movies);
            modelBuilder.Entity<Screenings>().
                HasData(seeder.Screenings);
            modelBuilder.Entity<Tickets>().
                HasData(seeder.Tickets);
            modelBuilder.Entity<Customers>().
                HasData(seeder.Customers);

        }

        public DbSet<Movies> movies { get; set; }
        public DbSet<Screenings> screenings { get; set; }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Tickets> tickets { get; set; }
    }
}

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
            modelBuilder.Entity<Ticket>()
                .HasKey(t => new { t.ScreeningId, t.CustomerID });

            Seeder seeder = new Seeder();

            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

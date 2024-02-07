using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;

        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);


        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

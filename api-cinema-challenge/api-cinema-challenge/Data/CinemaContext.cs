using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using api_cinema_challenge.Models;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime utc = DateTime.Now.ToUniversalTime();
            modelBuilder.Entity<Screening>().HasKey(s => new {s.Id, s.MovieId, s.ScreenNumber, s.Capacity, s.StartTime, s.CreatedAt, s.UpdatedAt});

            // SEED Costumers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Chris Wolstenholme", Email = "chris@muse.mu", Phone = "+44729388192", CreatedAt = utc, UpdatedAt = utc },
                new Customer { Id = 2, Name = "Max Peter", Email = "max.peter@gmail.com", Phone = "+49123456789", CreatedAt = utc, UpdatedAt = utc }
            );

            // SEED Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Dodgeball", Rating = "PG-13", Description = "The greatest movie ever made.", RunTimeMinutes = 126, CreatedAt = utc, UpdatedAt = utc },
                new Movie { Id = 2, Title = "The Matrix", Rating = "R", Description = "The greatest movie ever made.", RunTimeMinutes = 126, CreatedAt = utc, UpdatedAt = utc }
            );

            // SEED Screenings
            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, MovieId = 1, ScreenNumber = 1, Capacity = 100, StartTime = utc, CreatedAt = utc, UpdatedAt = utc },
                new Screening { Id = 2, MovieId = 2, ScreenNumber = 2, Capacity = 100, StartTime = utc, CreatedAt = utc, UpdatedAt = utc },
                new Screening { Id = 3, MovieId = 1, ScreenNumber = 3, Capacity = 40, StartTime = utc, CreatedAt = utc, UpdatedAt = utc }
            );

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

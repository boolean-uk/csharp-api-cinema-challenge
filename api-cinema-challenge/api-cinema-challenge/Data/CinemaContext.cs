using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Key
            modelBuilder.Entity<Customer>().HasKey(k => k.Id);
            modelBuilder.Entity<Movie>().HasKey(k => k.Id);
            modelBuilder.Entity<Screening>().HasKey(k => k.Id);
            modelBuilder.Entity<Movie>().HasMany(k => k.Screenings);

            // Seed
            modelBuilder.Entity<Customer>().HasData(
                new { Id = 1, Name = "Ola Nordmann", Email = "ola@nordmann.no", Phone = "+123456789", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 2, Name = "Kari Nordmann", Email = "kari@nordmann.no", Phone = "+987654321", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Movie>().HasData(
                new { Id = 1, Title = "Titanic", Rating = "PG-13", Description = "You won't believe what happens", RuntimeMins = 120, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 2, Title = "John Wick", Rating = "M-17", Description = "With a pencil", RuntimeMins = 90, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 3, Title = "Matrix", Rating = "PG-13", Description = "He's beginning to believe", RuntimeMins = 120, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Screening>().HasData(
                new { Id = 1, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 2, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 3, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 4, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 5, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 6, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 7, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 8, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 9, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 10, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 11, ScreenNumber = 2, Capacity = 50, StartsAt = DateTime.UtcNow, MovieId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new { Id = 12, ScreenNumber = 4, Capacity = 25, StartsAt = DateTime.UtcNow, MovieId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

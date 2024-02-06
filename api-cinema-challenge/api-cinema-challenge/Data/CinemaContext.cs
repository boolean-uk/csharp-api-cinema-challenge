using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Numerics;
using api_cinema_challenge.Models;
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
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* 
                modelBuilder.Entity<Screening>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Screenings)
                .HasForeignKey(s => s.CustomerId);
           */
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);

            // Seed Data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Henrik Rosenkilde", Email = "john@example.com", Phone = "1234567890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer { Id = 2, Name = "Anette Mari Rosenkilde", Email = "john@example.com", Phone = "1234567890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "The Matrix", Rating = "R", Description = "A computer hacker learns about the true nature of reality and his role in the war against its controllers.", RuntimeMins = 136, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Movie
                {
                    Id = 2,
                    Title = "The Hobbit",
                    Rating = "PG-13",
                    Description = "A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it, from the dragon Smaug.",
                    RuntimeMins = 169,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, ScreenNumber = 5, Capacity = 40, StartsAt = DateTime.UtcNow, MovieId = 1}
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

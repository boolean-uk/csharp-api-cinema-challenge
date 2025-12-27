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
            // Configuring the relationships and keys (if needed)
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)  // One Screening is linked to one Movie
                .WithMany()             // Movie can have multiple Screenings
                .HasForeignKey(s => s.MovieId);

            // Optional: you can set up additional configurations here, e.g. table names, indexes, etc.
        }

        // DbSets for the models
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // Seeder method
        public void SeedData()
        {
            if (!Movies.Any())
            {
                Movies.AddRange(
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Rating = "PG-13",
                        Description = "Batman faces the Joker, a criminal mastermind who wants to plunge Gotham into anarchy.",
                        RuntimeMins = 152,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Movie
                    {
                        Title = "Inception",
                        Rating = "PG-13",
                        Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given the task of planting an idea into a CEO's mind.",
                        RuntimeMins = 148,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Movie
                    {
                        Title = "Interstellar",
                        Rating = "PG-13",
                        Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                        RuntimeMins = 169,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    }
                );

                SaveChanges();  // ✅ Viktig! Lagre filmene før vi bruker dem i Screenings
            }

            if (!Screenings.Any())
            {
                var darkKnight = Movies.FirstOrDefault(m => m.Title == "The Dark Knight");
                var inception = Movies.FirstOrDefault(m => m.Title == "Inception");
                var interstellar = Movies.FirstOrDefault(m => m.Title == "Interstellar");

                if (darkKnight == null || inception == null || interstellar == null)
                {
                    return; // Feilsikring i tilfelle filmene ikke ble lagret
                }

                Screenings.AddRange(
                    new Screening
                    {
                        ScreenNumber = 1,
                        Capacity = 100,
                        StartsAt = new DateTime(2025, 2, 1, 22, 30, 0, DateTimeKind.Utc),
                        MovieId = darkKnight.Id,  // ✅ Nå vil dette fungere
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Screening
                    {
                        ScreenNumber = 2,
                        Capacity = 120,
                        StartsAt = new DateTime(2025, 2, 1, 19, 45, 0, DateTimeKind.Utc),
                        MovieId = inception.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Screening
                    {
                        ScreenNumber = 3,
                        Capacity = 80,
                        StartsAt = new DateTime(2025, 2, 1, 18, 30, 0, DateTimeKind.Utc),
                        MovieId = interstellar.Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    }
                );

                SaveChanges();
            }

            if (!Customers.Any())
            {
                Customers.AddRange(
                    new Customer
                    {
                        Name = "John Doe",
                        Email = "johndoe@example.com",
                        Phone = "+1234567890",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Customer
                    {
                        Name = "Jane Smith",
                        Email = "janesmith@example.com",
                        Phone = "+0987654321",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    },
                    new Customer
                    {
                        Name = "Alice Johnson",
                        Email = "alicej@example.com",
                        Phone = "+1122334455",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                    }
                );

                SaveChanges();
            }
        }

    }
}


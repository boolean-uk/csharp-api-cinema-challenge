using api_cinema_challenge.DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : IdentityUserContext<ApplicationUser>
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
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, Name = "Nigel", Email = "nigel@nigel.nigel", Phone = "+44729388192", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            customers.Add(new Customer { Id = 2, Name = "Dave", Email = "dave@dave.dave", Phone = "+44729388180", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            customers.Add(new Customer { Id = 3, Name = "Walter", Email = "walter@white.bb", Phone = "+44729383492", CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            modelBuilder.Entity<Customer>().HasData(customers);

            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie {Id = 1, Title = "Dodgeball", Rating = "PG-13", Description = "Dodge this", RuntimeMins = 126, CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            movies.Add(new Movie {Id = 2, Title = "Dune: Part 3", Rating = "PG-100", Description = "Spice", RuntimeMins = 158, CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            movies.Add(new Movie { Id = 3, Title = "Return of the King", Rating = "PG-18", Description = "Epic", RuntimeMins = 240, CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            modelBuilder.Entity<Movie>().HasData(movies);

            List<Screening> screenings = new List<Screening>();
            screenings.Add(new Screening {Id = 1, MovieId = 2, ScreenNumber=1, Capacity=100, StartsAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            screenings.Add(new Screening {Id = 2, MovieId = 2, ScreenNumber=2, Capacity=150, StartsAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            screenings.Add(new Screening { Id = 3, MovieId = 3, ScreenNumber = 3, Capacity = 60, StartsAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            screenings.Add(new Screening { Id = 4, MovieId = 1, ScreenNumber = 4, Capacity = 700, StartsAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), CreatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 25, 10, 00, 00, 00, DateTimeKind.Utc) });
            modelBuilder.Entity<Screening>().HasData(screenings);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

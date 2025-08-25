using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                 new Customer { Id = 1, Name = "John Doe", Email = "john.doe@email.com", Phone = "+4792763498", CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc) },
                 new Customer { Id = 2, Name = "Jane Doe", Email = "jane.doe@email.com", Phone = "+4743761209", CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc) }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Rating = "PG-13", Description = "The film stars Leonardo DiCaprio as a professional " +
                    "thief who steals information by infiltrating the subconscious of his targets. He is offered a chance to have his criminal " +
                    "history erased as payment for the implantation of another person's idea into a target's subconscious.", RuntimeMins = 148,
                    CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc)},
                new Movie { Id = 2, Title = "The Godfather", Rating = "R", Description = "\"The Godfather\" is based on Mario Puzo's novel of the " +
                    "same name. The film chronicles the life of the Corleone family, a powerful Italian-American mafia clan in New York City, focusing " +
                    "on the patriarch, Don Vito Corleone, and his youngest son, Michael Corleone.", RuntimeMins = 175,
                    CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc)}
            );

            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, MovieId = 1, ScreenNumber = 5, Capacity = 100, StartsAt = new DateTime(2025, 10, 01, 11, 3, 0, DateTimeKind.Utc),
                    CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc)},
                new Screening { Id = 2, MovieId = 2, ScreenNumber = 3, Capacity = 150, StartsAt = new DateTime(2025, 10, 01, 12, 3, 0, DateTimeKind.Utc),
                    CreatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 15, 10, 0, 0, DateTimeKind.Utc)}
            );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

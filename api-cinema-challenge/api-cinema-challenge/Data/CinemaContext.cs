using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.CustomerId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.ScreeningId);

            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);

            base.OnModelCreating(modelBuilder);

            // Seeder

            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Name = "Chris Evans", Email = "chris@evans.com", Phone = "11111111" },
                new Customer() { Id = 2, Name = "Chris Hemsworth", Email = "chris@hemsworth.com", Phone = "22222222" },
                new Customer() { Id = 3, Name = "Chris Pine", Email = "chris@pine.com", Phone = "33333333" },
                new Customer() { Id = 4, Name = "Chris Pratt", Email = "chris@pratt.com", Phone = "44444444" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Inception", Description = "WE HAVE TO GO DEEPER", Rating = "Very good", RuntimeMins = 150 },
                new Movie() { Id = 2, Title = "Interstellar", Description = "COME ON TARS", Rating = "Very good", RuntimeMins = 150 },
                new Movie() { Id = 3, Title = "Oppenheimer", Description = "I HAVE BECOME DEATH", Rating = "Very good", RuntimeMins = 150 }
                );

            modelBuilder.Entity<Screening>().HasData(
                new Screening() { Id = 1, MovieId = 1, ScreenNumber = 1, StartsAt = new DateTime(2010, 1, 1, 20, 0, 0, DateTimeKind.Utc) },
                new Screening() { Id = 2, MovieId = 1, ScreenNumber = 2, StartsAt = new DateTime(2010, 1, 1, 20, 0, 0, DateTimeKind.Utc) },
                new Screening() { Id = 3, MovieId = 2, ScreenNumber = 1, StartsAt = new DateTime(2014, 1, 1, 20, 0, 0, DateTimeKind.Utc) },
                new Screening() { Id = 4, MovieId = 3, ScreenNumber = 1, StartsAt = new DateTime(2023, 1, 1, 20, 0, 0, DateTimeKind.Utc) },
                new Screening() { Id = 5, MovieId = 3, ScreenNumber = 2, StartsAt = new DateTime(2023, 1, 1, 20, 0, 0, DateTimeKind.Utc) }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket() { Id = 1, CustomerId = 1, ScreeningId = 1, numSeats = 1 },
                new Ticket() { Id = 2, CustomerId = 1, ScreeningId = 2, numSeats = 2 },
                new Ticket() { Id = 3, CustomerId = 1, ScreeningId = 3, numSeats = 4 },
                new Ticket() { Id = 4, CustomerId = 2, ScreeningId = 1, numSeats = 2 },
                new Ticket() { Id = 5, CustomerId = 3, ScreeningId = 2, numSeats = 1 },
                new Ticket() { Id = 6, CustomerId = 4, ScreeningId = 3, numSeats = 2 }
                );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

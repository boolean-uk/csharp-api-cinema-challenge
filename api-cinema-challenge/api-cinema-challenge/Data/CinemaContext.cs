using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Bob",
                    Email = "boby@koak.com",
                    Phone = "12341512",
                    createdAt = DateTime.UtcNow,
                    updatedAt = DateTime.UtcNow
                });
            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Lion King",
                    Rating = Rating.PG,
                    Description = "Description",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
            modelBuilder.Entity<Screening>()
                .HasData(
                new Screening
                {
                    Id = 1,
                    Capacity = 30,
                    StartsAt = DateTime.UtcNow.AddMinutes(12),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = 1
                });

            modelBuilder.Entity<Ticket>()
                .HasData(
                new Ticket
                {
                    Id = 1,
                    NumberOfSeats = 1,
                    createdAt = DateTime.UtcNow,
                    updatedAt = DateTime.UtcNow,
                    CustomerId = 1,
                    ScreeningId = 1

                });
            modelBuilder.Entity<Movie>().Navigation(x => x.Screenings).AutoInclude();

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

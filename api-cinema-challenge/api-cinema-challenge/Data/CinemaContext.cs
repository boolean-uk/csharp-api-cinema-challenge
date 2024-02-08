using api_cinema_challenge.Models.NewFolder;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Numerics;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define foreign key relationship between Appointment and Prescription using Appointment.PrescriptionId
            modelBuilder.Entity<Screening>()
                .HasOne<Movie>()
                .WithMany()
                .HasForeignKey(a => a.MovieId);

            // Seeded data
            modelBuilder.Entity<Movie>().HasData(
                new Movie {
                    Id = 1,
                    Title = "How to Train your Dragon",
                    Description = "Movie about dragons",
                    Rating = "Excellent",
                    Runtime = 145,
                    CreatedAt = new DateTime(2024,3,2).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 3, 2).ToUniversalTime()
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Secret Garden",
                    Description = "A magical journey in a hidden garden",
                    Rating = "Enchanting",
                    Runtime = 110,
                    CreatedAt = new DateTime(2024, 4, 15).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 4, 15).ToUniversalTime()
                },
                new Movie
                {
                    Id = 3,
                    Title = "Inception",
                    Description = "A mind-bending heist in dreams",
                    Rating = "Masterpiece",
                    Runtime = 148,
                    CreatedAt = new DateTime(2024, 5, 20).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 5, 20).ToUniversalTime()
                },
                new Movie
                {
                    Id = 4,
                    Title = "Wonder Woman",
                    Description = "A superhero's journey to save the world",
                    Rating = "Epic",
                    Runtime = 152,
                    CreatedAt = new DateTime(2024, 6, 10).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 6, 10).ToUniversalTime()
                }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Frank Ocean",
                    Email ="FrankOcean@Orange.com",
                    Phone = "+3382798719",
                    CreatedAt = new DateTime(2024, 6, 10).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 6, 10).ToUniversalTime()
                },
                new Customer
                {
                    Id = 2,
                    Name = "Alice Wonderland",
                    Email = "Alice@Wonderland.com",
                    Phone = "+44123456789",
                    CreatedAt = new DateTime(2024, 7, 5).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 7, 5).ToUniversalTime()
                },
                new Customer
                {
                    Id = 3,
                    Name = "John Doe",
                    Email = "JohnDoe@email.com",
                    Phone = "+15555555555",
                    CreatedAt = new DateTime(2024, 8, 15).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 8, 15).ToUniversalTime()
                },
                new Customer
                {
                    Id = 4,
                    Name = "Mia Johnson",
                    Email = "MiaJohnson@email.com",
                    Phone = "+18881234567",
                    CreatedAt = new DateTime(2024, 9, 25).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 9, 25).ToUniversalTime()
                }
            );
            modelBuilder.Entity<Screening>().HasData(
                new Screening
                {
                    Id = 1,
                    MovieId = 1,
                    StartsAt = new DateTime(2024, 9, 25).ToUniversalTime(),
                    Capacity = 30,
                    ScreenNumber = 1,
                    CreatedAt = new DateTime(2024, 8, 15).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 8, 15).ToUniversalTime()
                },
                new Screening
                {
                    Id = 2,
                    MovieId = 2,
                    StartsAt = new DateTime(2024, 10, 10).ToUniversalTime(),
                    Capacity = 40,
                    ScreenNumber = 5,
                    CreatedAt = new DateTime(2024, 9, 5).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 9, 5).ToUniversalTime()
                },
                new Screening
                {
                    Id = 3,
                    MovieId = 3,
                    StartsAt = new DateTime(2024, 11, 1).ToUniversalTime(),
                    Capacity = 25,
                    ScreenNumber = 2,
                    CreatedAt = new DateTime(2024, 10, 20).ToUniversalTime(),
                    UpdatedAt = new DateTime(2024, 10, 20).ToUniversalTime()
                }
            );


        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

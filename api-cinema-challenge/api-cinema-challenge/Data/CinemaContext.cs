using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using api_cinema_challenge.Models;
using System.Numerics;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screens { get; set; }
        
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
            modelBuilder.Entity<User>().HasKey(u => u.Id); //Primary key
            modelBuilder.Entity<User>().HasData(
                //users
                new User 
                { 
                    Id = 1, 
                    Name = "Joel Joelsson", 
                    Email = "joel@email.com", 
                    PhoneNumber = "0700050088",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow               
                },

                new User
                {
                    Id = 2,
                    Name = "Alice Johnson",
                    Email = "alice@email.com",
                    PhoneNumber = "0701122334",
                    CreatedAt = DateTime.UtcNow.AddDays(-2),
                    UpdatedAt = DateTime.UtcNow.AddDays(-2)
                },

                new User
                {
                    Id = 3,
                    Name = "Bob Smith",
                    Email = "bob@email.com",
                    PhoneNumber = "0709876543",
                    CreatedAt = DateTime.UtcNow.AddDays(-5),
                    UpdatedAt = DateTime.UtcNow.AddDays(-3)
                },

                new User
                {
                    Id = 4,
                    Name = "Emma White",
                    Email = "emma@email.com",
                    PhoneNumber = "0703344556",
                    CreatedAt = DateTime.UtcNow.AddDays(-8),
                    UpdatedAt = DateTime.UtcNow.AddDays(-6)
                },

                new User
                {
                    Id = 5,
                    Name = "David Brown",
                    Email = "david@email.com",
                    PhoneNumber = "0706677889",
                    CreatedAt = DateTime.UtcNow.AddDays(-10),
                    UpdatedAt = DateTime.UtcNow.AddDays(-7)
                }
                );

            modelBuilder.Entity<Movie>().HasKey(u => u.Id); //primary key
            modelBuilder.Entity<Movie>().HasData(
                //movies
                new Movie
                {
                    Id = 1,
                    Title = "The Sweet Potato",
                    Rating = "Good",
                    Description = "A short comedy movie",
                    RuntimeMins = 77,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },

                new Movie
                {
                    Id = 2,
                    Title = "Mystery Mansion",
                    Rating = "Excellent",
                    Description = "A thrilling mystery movie",
                    RuntimeMins = 120,
                    CreatedAt = DateTime.UtcNow.AddDays(-5),
                    UpdatedAt = DateTime.UtcNow.AddDays(-3)

                },

                new Movie
                {
                    Id = 3,
                    Title = "Romantic Sunset",
                    Rating = "Great",
                    Description = "A beautiful romantic movie",
                    RuntimeMins = 90,
                    CreatedAt = DateTime.UtcNow.AddDays(-10),
                    UpdatedAt = DateTime.UtcNow.AddDays(-8)
                },

                new Movie
                {
                    Id = 4,
                    Title = "Sci-Fi Odyssey",
                    Rating = "Excellent",
                    Description = "An epic science fiction movie",
                    RuntimeMins = 150,
                    CreatedAt = DateTime.UtcNow.AddDays(-15),
                    UpdatedAt = DateTime.UtcNow.AddDays(-12)
                },

                new Movie
                {
                    Id = 5,
                    Title = "Drama Junction",
                    Rating = "Good",
                    Description = "A gripping drama movie",
                    RuntimeMins = 110,
                    CreatedAt = DateTime.UtcNow.AddDays(-20),
                    UpdatedAt = DateTime.UtcNow.AddDays(-18)
                }
                );

            modelBuilder.Entity<Screening>()
            // Primary key, composite
            .HasKey(s => new { s.MovieId, s.ScreenNumber, s.StartTime }); 
            modelBuilder.Entity<Screening>().HasData(
                //Screenings
                new Screening
                {
                    //Id = 1,
                    ScreenNumber = 1,
                    MovieId = 1,
                    Capacity = 100,
                    StartTime = DateTime.UtcNow.AddHours(1),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },

                new Screening
                {
                    //Id = 2,
                    ScreenNumber = 2,
                    MovieId = 1,
                    Capacity = 120,
                    StartTime = DateTime.UtcNow.AddHours(3),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },

                new Screening
                {
                    //Id = 3,
                    ScreenNumber = 3,
                    MovieId = 2,
                    Capacity = 70,
                    StartTime = DateTime.UtcNow.AddHours(4),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },

                new Screening
                {
                    //Id = 4,
                    ScreenNumber = 4,
                    MovieId = 2,
                    Capacity = 80,
                    StartTime = DateTime.UtcNow.AddHours(1),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },

                new Screening
                {
                    //Id = 5,
                    ScreenNumber = 5,
                    MovieId = 3,
                    Capacity = 83,
                    StartTime = DateTime.UtcNow.AddHours(5),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
                );
        }
    }
}

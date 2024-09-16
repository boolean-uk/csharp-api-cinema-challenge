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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Name = "Bjorg", Email = "bjorg@bjorg.no", Phone = "45215121", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer() { Id = 2, Name = "Ali", Email = "ali@ali.org", Phone = "77887788", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer() { Id = 3, Name = "Kaja", Email = "kaja@kaja.plazk", Phone = "33343334", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Stop or my mom will shoot", Rating = "R", Description = "Widely recognized as the worst movie ever made", RuntimeMins = 87, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Movie() { Id = 2, Title = "Ronja Rövardotter", Rating = "G", Description = "Romeo and Juliet, but better", RuntimeMins = 126, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Movie() { Id = 3, Title = "Super Mario Bros.", Rating = "PG-13", Description = "Bob Hoskins called it his biggest regret",  RuntimeMins = 104, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
            modelBuilder.Entity<Screening>().HasData(
                new Screening() { Id = 1, MovieId = 1, ScreenNumber = 2, Capacity = 20, StartsAt = new DateTime(2024, 9, 18, 14, 15, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Screening() { Id = 2, MovieId = 1, ScreenNumber = 3, Capacity = 15, StartsAt = new DateTime(2024, 9, 19, 15, 0, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Screening() { Id = 3, MovieId = 2, ScreenNumber = 1, Capacity = 300, StartsAt = new DateTime(2024, 9, 28, 20, 30, 0, DateTimeKind.Utc), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace api_cinema_challenge.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(

            new Customer() { Id = 1, Name = "Ali Haider Khan", Email = "aliali@live.no", Phone = "112",
                createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow, ScreeningId = 1 },
            new Customer() { Id = 2, Name = "Lionel Messi", Email = "messi786@live.com", Phone = "1881",
                createdAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow, ScreeningId = 2 }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Bodyguard", Rating = "6", Description = "Typical Bollywood",
                    RunTimeMins = 184, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, },
                new Movie() { Id = 2, Title = "DDLJ", Rating = "5", Description = "Love story",
                    RunTimeMins = 200, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, }
                
             );

            modelBuilder.Entity<Screening>().HasData(
                
                new Screening() { Id = 1, ScreenNumber = 1, Capacity = 50, StartsAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow, MovieId = 1 },
                new Screening() { Id = 2, ScreenNumber = 2, Capacity = 100, StartsAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow, updatedAt = DateTime.UtcNow, MovieId = 2 }

                );
            
            


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

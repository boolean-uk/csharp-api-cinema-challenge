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
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 1, Name = "Tom Hanks", Email = "tom.hanks@example.com", Phone = "123-456-7890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer() { Id = 2, Name = "Leonardo DiCaprio", Email = "leo.dicaprio@example.com", Phone = "123-456-7891", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer() {Id = 3, Name = "Scarlett Johansson", Email = "scarlett.johansson@example.com", Phone = "123-456-7892", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer() {Id = 4, Name = "Brad Pitt", Email = "brad.pitt@example.com", Phone = "123-456-7893", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }, 
                new Customer() {Id = 5, Name = "Angelina Jolie", Email = "angelina.jolie@example.com", Phone = "123-456-7894", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Title = "Forrest Gump", Rating = "PG-13", Description = "The story of a man with a low IQ who accomplished great things in his life.", RuntimeMins = 142 },
                new Movie() { Id = 2, Title = "Titanic", Rating = "PG-13", Description = "A love story between Jack and Rose aboard the ill-fated Titanic.", RuntimeMins = 195 },
                new Movie() { Id = 3, Title = "The Avengers", Rating = "PG-13", Description = "A team of superheroes including Iron Man, Captain America, and Thor, come together to save the world.", RuntimeMins = 143 },
                new Movie() { Id = 4, Title = "Fight Club", Rating = "R", Description = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", RuntimeMins = 139 },
                new Movie() { Id = 5, Title = "Mr. & Mrs. Smith", Rating = "PG-13", Description = "A bored married couple is surprised to learn that they are both assassins hired by competing agencies to kill each other.", RuntimeMins = 120 }
            );

            modelBuilder.Entity<Screening>().HasData(
                new Screening() { Id = 1, ScreenNumber = 1, Capacity = 100, StartsAt = DateTime.UtcNow.AddHours(1) },
                new Screening() { Id = 2, ScreenNumber = 2, Capacity = 120, StartsAt = DateTime.UtcNow.AddHours(2) },
                new Screening() { Id = 3, ScreenNumber = 3, Capacity = 80, StartsAt = DateTime.UtcNow.AddHours(3) },
                new Screening() { Id = 4, ScreenNumber = 4, Capacity = 90, StartsAt = DateTime.UtcNow.AddHours(4) },
                new Screening() { Id = 5, ScreenNumber = 5, Capacity = 110, StartsAt = DateTime.UtcNow.AddHours(5) }
            );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

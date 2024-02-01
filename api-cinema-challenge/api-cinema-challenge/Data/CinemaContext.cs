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
            modelBuilder.Entity<User>().HasData(
                new User() { UserId = 1, Name = "John Doe", Email = "john.doe@example.com", Phone = "+1234567890", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 2, Name = "Jane Smith", Email = "jane.smith@example.com", Phone = "+9876543210", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 3, Name = "Alice Johnson", Email = "alice.johnson@example.com", Phone = "+1122334455", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 4, Name = "Bob Anderson", Email = "bob.anderson@example.com", Phone = "+9988776655", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 5, Name = "Eva White", Email = "eva.white@example.com", Phone = "+6677889900", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 6, Name = "David Brown", Email = "david.brown@example.com", Phone = "+1122337788", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 7, Name = "Sophia Miller", Email = "sophia.miller@example.com", Phone = "+9988771122", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 8, Name = "Michael Wilson", Email = "michael.wilson@example.com", Phone = "+4455667788", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 9, Name = "Olivia Davis", Email = "olivia.davis@example.com", Phone = "+1122334466", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow },
                new User() { UserId = 10, Name = "Daniel Taylor", Email = "daniel.taylor@example.com", Phone = "+9988775544", Created_at = DateTime.UtcNow, Updated_at = DateTime.UtcNow }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    MovieId = 1,
                    Title = "The Matrix",
                    Rating = "R",
                    Description = "A computer hacker learns about the true nature of his reality",
                    RuntimeMins = 136,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 2,
                    Title = "Inception",
                    Rating = "PG-13",
                    Description = "A thief who enters the dreams of others to steal their secrets",
                    RuntimeMins = 148,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 3,
                    Title = "The Shawshank Redemption",
                    Rating = "R",
                    Description = "Two imprisoned men bond over a number of years",
                    RuntimeMins = 142,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 4,
                    Title = "Pulp Fiction",
                    Rating = "R",
                    Description = "Various interconnected stories of criminals in Los Angeles",
                    RuntimeMins = 154,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 5,
                    Title = "The Godfather",
                    Rating = "R",
                    Description = "The aging patriarch of an organized crime dynasty transfers control to his son",
                    RuntimeMins = 175,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 6,
                    Title = "Forrest Gump",
                    Rating = "PG-13",
                    Description = "A man with a low IQ witnesses and unwittingly influences several defining historical events",
                    RuntimeMins = 142,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 7,
                    Title = "The Dark Knight",
                    Rating = "PG-13",
                    Description = "A masked vigilante battles the criminal underworld in Gotham City",
                    RuntimeMins = 152,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 8,
                    Title = "Fight Club",
                    Rating = "R",
                    Description = "An insomniac office worker and a soapmaker form an underground fight club",
                    RuntimeMins = 139,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 9,
                    Title = "The Silence of the Lambs",
                    Rating = "R",
                    Description = "A young FBI cadet must receive the help of an incarcerated and manipulative cannibal killer",
                    RuntimeMins = 118,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                },
                new Movie()
                {
                    MovieId = 10,
                    Title = "Inglourious Basterds",
                    Rating = "R",
                    Description = "In Nazi-occupied France, a group of Jewish-American soldiers plan to assassinate Hitler",
                    RuntimeMins = 153,
                    Created_at = DateTime.UtcNow,
                    Updated_at = DateTime.UtcNow
                }
            );
        }



        public DbSet<User> Users { get; set; }  

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Screening> Screenings { get; set; }
    }
}

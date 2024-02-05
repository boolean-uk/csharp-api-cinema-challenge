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
            // this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);

            Customer firstCustomer = new Customer
            {
                Id = 1,
                Name = "Bobby Bob",
                Email = "bobby@email.com",
                PhoneNumber = "1234567890"
            };

            Customer secondCustomer = new Customer
            {
                Id = 2,
                Name = "Georgy George",
                Email = "georgy@email.com",
                PhoneNumber = "0987654321"
            };

            Movie firstMovie = new Movie
            {
                Id = 1,
                Title = "Inception",
                Rating = "PG-13",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., " +
                "but his tragic past may doom the project and his team to disaster.",
                Runtime = 148
            };

            Movie secondMovie = new Movie
            {
                Id = 2,
                Title = "Interstellar",
                Rating = "PG-13",
                Description = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, " +
                "Joseph Cooper, is tasked to pilot a spacecraft, along with a team of researchers, " +
                "to find a new planet for humans.",
                Runtime = 169
            };

            Screening firstScreening = new Screening
            {
                Id = 1,
                ScreenNumber = 1,
                Capacity = 50,
                MovieId = 1,
                StartsAt = DateTime.UtcNow.AddDays(1)
            };

            Screening secondScreening = new Screening
            {
                Id = 2,
                ScreenNumber = 2,
                Capacity = 50,
                MovieId = 2,
                StartsAt = DateTime.UtcNow.AddDays(1)
            };

            modelBuilder.Entity<Screening>()
                .HasData(firstScreening, secondScreening);

            modelBuilder.Entity<Customer>()
                .HasData(firstCustomer, secondCustomer);

            modelBuilder.Entity<Movie>()
                .HasData(firstMovie, secondMovie);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

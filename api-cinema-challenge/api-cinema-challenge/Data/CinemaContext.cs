using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
            string dateString = "2023-03-14T11:01:56.633+00:00";
            DateTimeOffset dateTime = DateTimeOffset.Parse(dateString);
            DateTime dateTimeUtc = dateTime.UtcDateTime;


            modelBuilder.Entity<Customer>().HasData(new Customer()
            {
                Id = 1,
                Name = "Chris Wolstenholme",
                Email = "Chris@muse.mu",
                Phone = "+44729388192",
                CreatedAt = dateTimeUtc,
                UpdatedAt = dateTimeUtc
            });


            modelBuilder.Entity<Movie>().HasData(new Movie()
            {
                Id = 1,
                Title = "Dodgeball",
                Rating = "PG-13",
                Description = "The greatest movie ever made.",
                RuntimeMins = 126,
                CreatedAt = dateTimeUtc,
                UpdatedAt = dateTimeUtc
            });

            modelBuilder.Entity<Screening>().HasData(new Screening()
            {
                Id = 1,
                ScreenNumber = 5,
                Capacity = 40,
                StartsAt = dateTimeUtc.AddHours(3),
                MovieId = 1,
                CreatedAt = dateTimeUtc,
                UpdatedAt = dateTimeUtc
            }) ;


        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }

    }
}

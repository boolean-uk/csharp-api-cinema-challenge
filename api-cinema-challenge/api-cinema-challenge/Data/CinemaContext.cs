using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.LogTo(message => Debug.WriteLine("DEBUGGING " + message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screening>()
            .HasOne(e => e.Movie)
            .WithMany(e => e.Screenings)
            .HasForeignKey(e => e.MovieId)
            .IsRequired();

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Chris Wolstenholme",
                    Email = "chris@muse.mu",
                    Phone = "+44729388192",
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Dodgeball",
                    Rating = "PG-13",
                    Description = "The greatest movie ever made.",
                    RuntimeMins = 126,
                }
            );
            modelBuilder.Entity<Screening>().HasData(
                new Screening
                {
                    Id = 1,
                    MovieId = 1,
                    ScreenNumber = 5,
                    Capacity = 40,
                    StartsAt = DateTime.UtcNow.AddDays(5)
                }
            );
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

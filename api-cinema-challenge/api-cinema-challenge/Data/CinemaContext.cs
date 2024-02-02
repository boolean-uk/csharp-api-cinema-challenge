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
            this.Database.EnsureCreated(); // IF ERROR HERE, CHECK ZSCALER!!
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().HasKey(x => new { x.Id });
            modelBuilder.Entity<Screenings>().HasKey(x => new { x.Id});
            modelBuilder.Entity<Customer>().HasKey(x => new { x.Id});

            modelBuilder.Entity<Movies>().HasData(
                new Movies { Id = 1, Title = "So Lonesome I Could Cry", Description = "Amazing but imaginary Hank Williams movie", Rating = "PG-16", RuntimeMins = 114},
                new Movies { Id = 2, Title = "Texas Cowboy Rides Again", Description = "Western B-Movie", Rating = "PG-16", RuntimeMins =  120}
            );
            DateTime utc1 = DateTime.Now.ToUniversalTime();
            modelBuilder.Entity<Screenings>().HasData(
                new Screenings { Id = 1, ScreenNr = 1, Capacity = 64, StartsAt = utc1, MoviesId = 1 },
                new Screenings { Id = 2, ScreenNr = 2, Capacity = 64, StartsAt = utc1, MoviesId = 1 },
                new Screenings { Id = 3, ScreenNr = 3, Capacity = 32, StartsAt = utc1, MoviesId = 2 }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Victor Adamson", Email = "Victor@Adamson.se", PhoneNr = 070666123, ScreeningId = 2 },
                new Customer { Id = 2, Name = "Phill Collins", Email = "Phill@Collins.com", PhoneNr = 321566322, ScreeningId = 3 },
                new Customer { Id = 3, Name = "Person Humansson", Email = "Real@Email.mars", PhoneNr = 325666442, ScreeningId = 1 }
            );
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screenings> Screenings { get; set; }
        public DbSet<Movies> Movies { get; set; }
    }
}

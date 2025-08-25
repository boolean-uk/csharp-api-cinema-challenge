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
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { 
                    Id = 1,
                    Name = "Trym Berger",
                    Email = "Trym@Berger.no",
                    Phone = "12459732"
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Monika Synnove",
                    Email = "mogak@haugan.no",
                    Phone = "56753212"
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { 
                    Id = 1,
                    Title = "Howl's Moving Castle",
                    Description = "Howl's Moving Castle is a 2004 Japanese animated fantasy film written and directed by Hayao Miyazaki",
                    Rating = "G",
                    RuntimeMins = 119,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt = DateTime.MinValue
                },
                new Movie()
                {
                    Id = 2,
                    Title = "Kiki's Delivery Service",
                    Description = "A 1989 Japanese animated fantasy film written, produced, and directed by Hayao Miyazaki, based on Eiko Kadono's 1985 novel Kiki's Delivery Service.",
                    Rating = "G",
                    RuntimeMins = 102,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt = DateTime.MinValue
                }
            );
            modelBuilder.Entity<Screening>().HasData(
                new Screening()
                {
                    Id = 1,
                    ScreenNumber = 1,
                    Capacity = 200,
                    StartsAt = DateTime.Parse("2025-09-12 14:30").ToUniversalTime(),
                    MovieId = 1,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt = DateTime.MinValue
                },
                new Screening()
                {
                    Id = 2,
                    ScreenNumber = 2,
                    Capacity = 130,
                    StartsAt = DateTime.Parse("2025-09-13 20:30").ToUniversalTime(),
                    MovieId = 2,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt = DateTime.MinValue
                }
            );

                modelBuilder.Entity<Ticket>().HasData(
                new Ticket()
                {
                    Id = 1,
                    NumSeats = 1,
                    ScreeningId = 2,
                    CustomerId = 1,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt = DateTime.MinValue
                },
                new Ticket()
                {
                    Id = 2,
                    NumSeats = 3,
                    ScreeningId = 1,
                    CustomerId = 2,
                    CreatedAt = DateTime.MinValue,
                    UpdatedAt= DateTime.MinValue
                }
            );
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
    }
}

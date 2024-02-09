using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;

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
            
            modelBuilder.Entity<Customer>().HasMany(t => t.Tickets).WithOne(c => c.customer).HasForeignKey(t => t.CustomerId); 
         



            DateTime now = DateTime.Now.ToUniversalTime();

            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, Capacity = 200, MovieId = 1, ScreenNumber = 1, StartsAt = now.AddDays(1), CreatedAt = now, UpdatedAt = now },
                new Screening { Id = 2, Capacity = 150, MovieId = 2, ScreenNumber = 2, StartsAt = now.AddDays(2), CreatedAt = now, UpdatedAt = now },
                new Screening { Id = 3, Capacity = 75, MovieId = 3, ScreenNumber = 3, StartsAt = now.AddDays(3), CreatedAt = now, UpdatedAt = now }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "The Dark Knight",
                    Description = "Greatest superhero movie ever.",
                    Rating = "PG-13",
                    RuntimeMins = 152,
                    CreatedAt = now,
                    UpdatedAt = now
                },

                new Movie
                {
                    Id = 2,
                    Title = "Inglourious Basterds",
                    Description = "Bon giourno.",
                    Rating = "R",
                    RuntimeMins = 153,
                    CreatedAt = now,
                    UpdatedAt = now
                },

                new Movie
                {
                    Id = 3,
                    Title = "Star Wars: Revenge of the Sith",
                    Description = "I AM the Senate",
                    Rating = "PG",
                    RuntimeMins = 140,
                    CreatedAt = now,
                    UpdatedAt = now
                }

                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Oneal", Email = "onilmobil@gmail.com", Phone = "94557112", CreatedAt = now, UpdatedAt = now },
                new Customer { Id = 2, Name = "Orjan", Email = "fedme@hotmail.com", Phone = "55678946", CreatedAt = now, UpdatedAt = now },
                new Customer { Id = 3, Name = "Reidar", Email = "nitterISkjegget@online.no", Phone = "12345678", CreatedAt = now, UpdatedAt = now }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket { Id = 1, NumSeats = 3, CustomerId = 1, ScreeningId = 1, CreatedAt = now, UpdatedAt = now },
                new Ticket { Id = 2, NumSeats = 1, CustomerId = 2, ScreeningId = 2, CreatedAt = now, UpdatedAt = now },
                new Ticket { Id = 3, NumSeats = 3, CustomerId = 3, ScreeningId = 3, CreatedAt = now, UpdatedAt = now });

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> screenings { get; set; }
        public DbSet<Ticket> tickets { get; set; }

    }
}

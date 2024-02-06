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
            //optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime utc = DateTime.Now.ToUniversalTime();
            // modelBuilder.Entity<Screening>().HasKey(m => new { m.Id , m.MovieId });
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);



            // Data seeding

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Jhon Axe", Email = "Jhon@gmail.com", Phone = "+44729388192", CreatedAt = utc, UpdatedAt = utc },
                new Customer { Id = 2, Name = "Alice Darry", Email = "Alice@gmail.com", Phone = "+44729388193", CreatedAt = utc, UpdatedAt = utc });


            modelBuilder.Entity<Movie>().HasData(
               new Movie { Id = 1, Title = "Dodgeball", Rating = "PG-13", Description = "The greatest movie ever made", RuntimeMins = 124, CreatedAt = utc, UpdatedAt = utc },
               new Movie { Id = 2, Title = "Dodgeball Part2", Rating = "PG-13", Description = "One of the best movies", RuntimeMins = 133, CreatedAt = utc, UpdatedAt = utc }
           );

            
            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, ScreenNumber = 1, Capacity = 50, StartsAt = utc, CreatedAt = utc, UpdatedAt = utc, MovieId = 1},
                new Screening { Id = 2, ScreenNumber = 2, Capacity = 150, StartsAt = utc, CreatedAt = utc, UpdatedAt = utc, MovieId = 2}
      
            );

            modelBuilder.Entity<Ticket>().HasData(
               new Ticket { Id = 1, numSeats = 1, CustomerId = 1, ScreeningId = 1, CreatedAt = utc, UpdatedAt = utc },
               new Ticket { Id = 2, numSeats = 2, CustomerId = 2, ScreeningId = 2, CreatedAt = utc, UpdatedAt = utc }
               
           );
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

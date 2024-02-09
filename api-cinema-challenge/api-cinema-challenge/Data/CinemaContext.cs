using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Numerics;

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
            

            modelBuilder.Entity<Ticket>().HasOne(t => t.Screening).WithMany(s => s.Tickets).HasForeignKey(t => new { t.ScreeningId });
            modelBuilder.Entity<Ticket>().HasOne(t => t.Customer).WithMany(c => c.Tickets).HasForeignKey(t => t.CustomerId);


            modelBuilder.Entity<Customer>().HasData(
               new Customer { Id = 1, Name = "Jensemann", Email ="Amail@email.no", Phone = "12345678", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
               new Customer { Id = 2, Name = "Kristian", Email = "Bmail@email.no", Phone = "12345679", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
               new Customer { Id = 3, Name = "Mahmoud", Email = "Cmail@email.no", Phone = "12345670", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
               new Customer { Id = 4, Name = "Aziz" ,Email = "Dmail@email.no", Phone = "12345648", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
               new Customer { Id = 5, Name = "Henrik", Email = "Email@email.no", Phone = "12245678", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<Movie>().HasData(
       new Movie { Id = 1, Title = "Indiana Jones", Rating = 10, Description = "Another one of these", RuntimeMins = 90, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
       new Movie { Id = 2, Title = "Lord Of The Rings", Rating = 13, Description = "Goated", RuntimeMins = 2000, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
       new Movie { Id = 3, Title = "Star Wars", Rating = 18, Description = "Order 66", RuntimeMins = 110, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
       new Movie { Id = 4, Title = "Fight Club", Rating = 16, Description = "First Rule", RuntimeMins = 87,  CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1, ScreenNumber = 1, Capacity = 60, StartsAt = DateTime.UtcNow.AddDays(1), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 1 },
                new Screening { Id = 2, ScreenNumber = 2, Capacity = 90, StartsAt = DateTime.UtcNow.AddDays(1), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 2 },
                new Screening { Id = 3, ScreenNumber = 1, Capacity = 60, StartsAt = DateTime.UtcNow.AddDays(2), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 3 },
                new Screening { Id = 4, ScreenNumber = 2, Capacity = 90, StartsAt = DateTime.UtcNow.AddDays(2), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 4 }
                );
            modelBuilder.Entity<Ticket>().HasData(
            new Ticket { Id = 1, CustomerId= 1, ScreeningId = 1, numSeats = 1, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
            new Ticket { Id = 2, CustomerId = 2, ScreeningId = 2,numSeats = 3, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
            new Ticket { Id = 3, CustomerId = 3, ScreeningId = 3,numSeats = 1, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() }
            );

        }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Screening> Screenings { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    }
}
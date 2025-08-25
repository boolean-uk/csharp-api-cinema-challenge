using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : IdentityUserContext<ApplicationUser>
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Isabell Tran",
                    Email = "isabell@experis.com",
                    Phone = "12345678",
                    CreatedAt = new DateTime(2025, 08, 22, 10, 00, 00, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 22, 10, 00, 00, DateTimeKind.Utc)
                }
            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 2,
                    Name = "Marie Hansen",
                    Email = "Marie@experis.com",
                    Phone = "98989898",
                    CreatedAt = new DateTime(2025, 08, 23, 10, 00, 00, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 23, 10, 00, 00, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Rating = "PG-13",
                    Description = "A mind-bending thriller",
                    RuntimeMins = 148,
                    CreatedAt = new DateTime(2025, 08, 22, 15, 00, 00, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 22, 15, 00, 00, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Movie>().HasData(
               new Movie
               {
                   Id = 2,
                   Title = "F1",
                   Rating = "PG-13",
                   Description = "Action",
                   RuntimeMins = 155,
                   CreatedAt = new DateTime(2025, 08, 22, 15, 00, 00, DateTimeKind.Utc),
                   UpdatedAt = new DateTime(2025, 08, 22, 15, 00, 00, DateTimeKind.Utc)
               }
           );

            modelBuilder.Entity<Screening>().HasData(
                new Screening
                {
                    Id = 1,
                    MovieId = 1,
                    ScreenNumber = 5,
                    StartsAt = new DateTime(2025, 08, 22, 14, 00, 00, DateTimeKind.Utc),
                    Capacity = 100,
                    CreatedAt = new DateTime(2025, 08, 22, 14, 00, 00, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 22, 14, 00, 00, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    CustomerId = 1,
                    ScreeningId = 1,
                    NumSeats = 2,
                    CreatedAt = new DateTime(2025, 08, 22, 13, 00, 00, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2025, 08, 22, 13, 00, 00, DateTimeKind.Utc)
                }
            );
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

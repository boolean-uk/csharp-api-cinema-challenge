using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.screenings)
                .WithOne(s => s.movie)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.tickets)
                .WithOne(t => t.customer)
                .HasForeignKey(t => t.CustomerId);

            modelBuilder.Entity<Screening>()
                .HasMany(s => s.tickets)
                .WithOne(t => t.screening)
                .HasForeignKey(t => t.screeningId); 

            Customer customer = new Customer()
            {
                Id = 1,
                Name = "John Doe",
                Email = "JohnDoe12342@gmail.com",
                Phone = "12345678",
                tickets = new List<Ticket>()
            };

            Customer customer1 = new Customer()
            {

                Id = 2,
                Name = "Amy Smith",
                Email = "AmySmith1234@gmail.com",
                Phone = "11223344",
                tickets = new List<Ticket>()
            };

            Customer customer2 = new Customer()
            {
                Id = 3,
                Name = "Mike Jonhson",
                Email = "Mike1234@hotmail.com",
                Phone = "87654321",
                tickets = new List<Ticket>()

            };

            Movie movie = new Movie()
            {
                Id = 1,
                Title = "Harry Potter",
                Description = "fantasy movie about sorcercy",
                Rating = 8,
                Runtime = 122,
                screenings = new List<Screening>()

            };
            Movie movie1 = new Movie()
            {
                Id = 2,
                Title = "Lord of the Rings",
                Rating = 9,
                Description = "High fantasy tolkiens classic",
                Runtime = 208,
                screenings = new List<Screening>()
            };
            Movie movie2 = new Movie()
            {
                Id = 3,
                Title = "Taken",
                Rating = 10,
                Description = "Intense action thriller",
                Runtime = 137,
                screenings = new List<Screening>(),
            };
            Screening screening = new Screening()
            {
                Id = 1,
                capacity = 78,
                startsAT = DateTime.UtcNow,
                MovieId = 1,
                customers = new List<Customer>(),
                tickets = new List<Ticket>()
            };
            Ticket ticket = new Ticket()
            {
                Id = 1,
                screeningId = 1,
                numOfSeats = 2,
                CustomerId = 1,

            };
            Ticket ticket1 = new Ticket()
            {
                Id = 2,
                screeningId = 1,
                numOfSeats = 4,
                CustomerId = 2,

            };
            Ticket ticket2 = new Ticket()
            {
                Id = 3,
                screeningId = 1,
                numOfSeats = 1,
                CustomerId = 3,

            };

            modelBuilder.Entity<Customer>().HasData(customer, customer1, customer2);
            modelBuilder.Entity<Movie>().HasData(movie, movie1, movie2);
            modelBuilder.Entity<Screening>().HasData(screening);
            modelBuilder.Entity<Ticket>().HasData(ticket, ticket1, ticket2);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}

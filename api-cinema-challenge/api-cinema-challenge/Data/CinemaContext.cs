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
            this.Database.EnsureCreated();
        }
        public CinemaContext() 
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
            /*
            if (!Customers.Any())
            {
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer()
                {
                    Name = "Daniel",
                    Email = "Daniel@mail.com",
                });
                customers.Add(new Customer()
                {
                    Name = "David",
                    Email = "David@mail.com",
                });
                customers.Add(new Customer()
                {
                    Name = "John",
                    Email = "John@mail.com",
                });
                modelBuilder.Entity<Customer>().HasData(customers);
            }
            if (!Movies.Any())
            {
                List<Movie> movies = new List<Movie>();
                movies.Add(new Movie()
                {
                    MovieName = "Oppenheimer"
                });
                movies.Add(new Movie()
                {
                    MovieName = "Barbie"
                });
                movies.Add(new Movie()
                {
                    MovieName = "Shrek"
                });
                modelBuilder.Entity<Movie>().HasData(movies);
            }
            if (!Screens.Any())
            {
                List<Screen> screens = new List<Screen>();
                screens.Add(new Screen()
                {
                    ScreenNumber = 1
                });
                screens.Add(new Screen()
                {
                    ScreenNumber = 2
                });
                screens.Add(new Screen()
                {
                    ScreenNumber = 3
                });
                modelBuilder.Entity<Screen>().HasData(screens);
            }
            if (!Screenings.Any())
            {
                List<Screening> screenings = new List<Screening>();
                screenings.Add(new Screening()
                {
                    ScreenId = 1,
                    MovieId = 1,
                    ScreeningTime = DateTime.UtcNow.AddDays(1)

                });
                screenings.Add(new Screening()
                {
                    ScreenId = 2,
                    MovieId = 2,
                    ScreeningTime = DateTime.UtcNow.AddDays(2)

                });
                screenings.Add(new Screening()
                {
                    ScreenId = 3,
                    MovieId = 3,
                    ScreeningTime = DateTime.UtcNow.AddDays(3)

                });
                modelBuilder.Entity<Screening>().HasData(screenings);
            }
            if (!Tickets.Any())
            {
                List<Ticket> tickets = new List<Ticket>();
                tickets.Add(new Ticket()
                {
                    CustomerID = 1,
                    ScreeningID = 1
                });
                tickets.Add(new Ticket()
                {
                    CustomerID = 2,
                    ScreeningID = 2
                });
                tickets.Add(new Ticket()
                {
                    CustomerID = 3,
                    ScreeningID = 3
                });
                modelBuilder.Entity<Ticket>().HasData(tickets);
            }
            */
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using api_cinema_challenge.Models;

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
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<ScreeningTicket>().HasKey(k => new { k.TicketId, k.ScreeningId });
            modelBuilder.Entity<CustomerTicket>().HasKey(k => new { k.CustomerId, k.TicketId });
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Screenings)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screening>()
                .HasData(seeder.Screenings);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);

            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);

            modelBuilder.Entity<CustomerTicket>().HasData(seeder.CustomerTickets);

            modelBuilder.Entity<ScreeningTicket>().HasData(seeder.ScreeningTickets);

        }

        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Customer> Customers {get; set;}
        public DbSet<Movie> Movies {get; set;}
        public DbSet<Screening> Screenings {get; set;}
        public DbSet<CustomerTicket> CustomerTickets {get; set;}
        public DbSet<ScreeningTicket> ScreeningTickets {get; set;}

    }
}

using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Screening)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.ScreeningId)
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Seat)
                .WithMany(x => x.Tickets)
                .HasForeignKey(x => x.SeatId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Seat>()
                .HasOne(x => x.Screen)
                .WithMany(x => x.Seats)
                .HasForeignKey(x => x.ScreenId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Screening>()
                .HasOne(x => x.Movie)
                .WithMany(x => x.Screenings)
                .HasForeignKey(x => x.MovieId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Screening>()
                .HasOne(x => x.Screen)
                .WithMany(x => x.Screenings)
                .HasForeignKey(x => x.ScreenId)
                .OnDelete(DeleteBehavior.Cascade);

            // Do seeding here!
        }

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Movie> Movies { get; set; }    
        public DbSet<Screen> Screens { get; set; }
    }
}

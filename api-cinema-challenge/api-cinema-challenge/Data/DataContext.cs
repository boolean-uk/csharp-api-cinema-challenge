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
                .HasForeignKey(x => new { x.SeatId, x.ScreenId })
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Ticket>()
                .HasIndex(x => new { x.SeatId, x.ScreeningId })
                .IsUnique();
            modelBuilder.Entity<Ticket>()
                .Property(x => x.TicketType)
                .HasConversion<string>();

            modelBuilder.Entity<Seat>().HasKey(e => new {e.Id, e.ScreenId});
            modelBuilder.Entity<Seat>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
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
            Seeder seeder = new Seeder();
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screen>().HasData(seeder.Screens);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Seat>().HasData(seeder.Seats);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);
        }

        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Movie> Movies { get; set; }    
        public DbSet<Screen> Screens { get; set; }
    }
}

using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

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
            //optionsBuilder.LogTo(message => Debug.WriteLine("DEBUGGING " + message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screening>()
            .HasOne(e => e.Screen)
            .WithMany(e => e.Screenings)
            .HasForeignKey(e => e.ScreenId)
            .IsRequired();
            modelBuilder.Entity<Screening>()
            .HasOne(e => e.Movie)
            .WithMany(e => e.Screenings)
            .HasForeignKey(e => e.MovieId)
            .IsRequired();

            modelBuilder.Entity<Booking>()
                .HasOne(c => c.Customer)
                .WithMany(b => b.Bookings)
                .HasForeignKey(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Booking>()
                .HasOne(s => s.Screening)
                .WithMany(b => b.Bookings)
                .HasForeignKey(s => s.ScreeningId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Jon Doe",
                    Email = "jon@example.com",
                    Phone = "+123"
                });
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

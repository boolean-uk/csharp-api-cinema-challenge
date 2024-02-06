using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options, IConfiguration configuration) : base(options)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Screenings)
                .WithMany(s => s.Customers)
                .UsingEntity<Ticket>();

            modelBuilder.Entity<Customer>().HasData(CustomerSeeder.Generate(10));
            modelBuilder.Entity<Movie>().HasData(MovieSeeder.Generate(13));
            modelBuilder.Entity<Screening>().HasData(ScreeningSeeder.Generate(6, 13));
            modelBuilder.Entity<Ticket>().HasData(TicketSeeder.Generate());
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<Screening> Screenings { get; set; }
        DbSet<Ticket> Tickets { get; set; }
    }
}

using api_cinema_challenge.Application.Models;
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
        }

        DbSet<Customer> Customers { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<Screening> Screenings { get; set; }
        DbSet<Ticket> Tickets { get; set; }
    }
}

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
            //this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Movie>().HasMany<Screening>();

            modelBuilder.Entity<Screening>()
                .HasMany(s => s.Customers)
                .WithMany(c => c.Screenings)
                .UsingEntity<Ticket>();

            modelBuilder.Entity<Screening>()
                .HasOne<Movie>()
                .WithMany(m => m.Screenings);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        public DbSet<Screening> Screening { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movie { get; set; }
    }
}

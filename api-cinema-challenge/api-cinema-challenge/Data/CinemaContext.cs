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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Screening>().
               HasKey(p => new { p.Id });

            modelBuilder.Entity<Ticket>().
                HasKey(p => new { p.Id });

            modelBuilder.Entity<Movie>().
                HasKey(p => new { p.Id });
            
            modelBuilder.Entity<Customer>().
                HasKey(p => new { p.Id });

            modelBuilder.Entity<Screening>().
                HasOne(x => x.Movie).
                WithMany(x => x.Screenings).
                HasForeignKey(x => x.MovieId);

            modelBuilder.Entity<Ticket>().
                HasOne(x => x.Screening).
                WithMany(x => x.Tickets).
                HasForeignKey(x => x.ScreeningId);

            modelBuilder.Entity<Ticket>().
                HasOne(x => x.Customer).
                WithMany(x => x.Tickets).
                HasForeignKey(x => x.CustomerId);

            Seeder seeder = new Seeder();
            modelBuilder.Entity<Movie>().
                HasData(seeder.Movies);
            modelBuilder.Entity<Customer>().
                HasData(seeder.Customers);
            modelBuilder.Entity<Ticket>().
                HasData(seeder.Tickets);
            modelBuilder.Entity<Screening>().
                HasData(seeder.Screenings);

        }

        public DbSet<Movie> movies { get; set; }
        public DbSet<Screening> screenings { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Ticket> tickets { get; set; }
    }
}

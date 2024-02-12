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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            seeder seeder = new seeder();

            modelBuilder.Entity<Customer>().Navigation(x => x.Tickets).AutoInclude();
            modelBuilder.Entity<Movie>().Navigation(x => x.Screenings).AutoInclude();
            modelBuilder.Entity<Screening>().Navigation(x => x.Tickets).AutoInclude();

            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Screenings)
                .WithOne(e => e.Movie).HasForeignKey(e => e.MovieId);

            modelBuilder.Entity<Customer>().HasMany(e => e.Tickets).WithOne(e => e.Customer).HasForeignKey(e => e.CustomerID);
            modelBuilder.Entity<Screening>().HasMany(e => e.Tickets).WithOne(e => e.Screening).HasForeignKey(e => e.ScreeningId);

        }

        public DbSet<Customer> Customers { get; set; }
        public  DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }

        public DbSet<Ticket> Tickets { get; set; }
    }
}

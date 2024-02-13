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
            //optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seed = new Seeder();

            modelBuilder.Entity<Customer>().Navigation(x => x.Tickets).AutoInclude();
            modelBuilder.Entity<Ticket>().Navigation(x => x.Customer).AutoInclude();
            modelBuilder.Entity<Ticket>().Navigation(x => x.Screening).AutoInclude();
            modelBuilder.Entity<Movie>().Navigation(x => x.Screenings).AutoInclude();
            modelBuilder.Entity<Screening>().Navigation(x => x.PlayingMovie).AutoInclude();




            modelBuilder.Entity<Customer>().HasData(seed.Customers);
            modelBuilder.Entity<Movie>().HasData(seed.Movies);


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

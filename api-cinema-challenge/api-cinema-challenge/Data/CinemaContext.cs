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
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Movie>().HasKey(m => new {m.id});
            modelBuilder.Entity<Customer>().HasKey(c => new { c.id });
            modelBuilder.Entity<Screening>().HasKey(s => new { s.id});

            modelBuilder.Entity<Movie>().HasData(seeder.movies);
            modelBuilder.Entity<Customer>().HasData(seeder.customers);
            modelBuilder.Entity<Screening>().HasData(seeder.screenings);
        }





        public DbSet<Movie> Movies { get; set;}
        public DbSet<Customer> Customers { get; set;}
        public DbSet<Screening> Screenings { get; set;}
    }

    

}

using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Keys
            modelBuilder.Entity<Screening>().HasKey(s => new { s.Id });

            modelBuilder.Entity<Screening>().HasOne(s => s.Movie).WithMany(m => m.Screenings).HasForeignKey(s => s.MovieId);

            //Seeder
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Customer>().HasData(seeder.customers);
            modelBuilder.Entity<Movie>().HasData(seeder.movies);
            modelBuilder.Entity<Screening>().HasData(seeder.screenings);
        }
        public DbSet<Customer> Customers {  get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
    }
}

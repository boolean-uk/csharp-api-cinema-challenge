using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        //private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            //var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //_connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message)); //see the sql EF using in the console
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO: Appointment Key etc.. Add Here

            //TODO: Seed Data Here

            Seeder seeder = new Seeder();

            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);
            modelBuilder.Entity<Customer>().HasData(seeder.Customers);

            modelBuilder.Entity<Screening>()
                .HasOne<Movie>(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Screening> Screenings { get; set; }
    }
}

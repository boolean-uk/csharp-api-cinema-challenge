using api_cinema_challenge.Models.DatabaseModels;
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
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeder = new Seeder();

            modelBuilder.Entity<Customer>().HasMany(x => x.Screenings).WithMany(x => x.Customers);
            modelBuilder.Entity<Movie>().HasMany(x => x.Screenings).WithOne(x => x.Movie).HasForeignKey(x => x.MovieId);
            modelBuilder.Entity<Screen>().HasOne(x => x.Movie).WithMany(x => x.Screenings);
            modelBuilder.Entity<Screen>().HasMany(x => x.Customers).WithMany(x => x.Screenings);
            modelBuilder.Entity<Ticket>().HasOne(x => x.Customer);
            modelBuilder.Entity<Ticket>().HasOne(x => x.Screen);


            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Screen>().HasData(seeder.Screens);
            modelBuilder.Entity<CustomerScreening>().HasData(seeder.CustomerScreenings);
            modelBuilder.Entity<Ticket>().HasData(seeder.Tickets);


        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<CustomerScreening> CustomerScreenings { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}

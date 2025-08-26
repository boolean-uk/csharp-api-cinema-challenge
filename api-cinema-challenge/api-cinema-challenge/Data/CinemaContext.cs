using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
            modelBuilder.Entity<Customer>().HasMany(c => c.Tickets).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerId);
            modelBuilder.Entity<Movie>().HasMany(m => m.Screenings).WithOne(s => s.Movie).HasForeignKey(m =>  m.MovieId);
            modelBuilder.Entity<Ticket>().HasOne(t => t.Screening).WithMany(s => s.Tickets).HasForeignKey(t => t.ScreeningId);

            modelBuilder.Entity<Customer>().HasData(seeder.Customers);
            modelBuilder.Entity<Movie>().HasData(seeder.Movies);
            modelBuilder.Entity<Ticket>().HasData(seeder.tickets);
            modelBuilder.Entity<Screening>().HasData(seeder.Screenings);



        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }



    }
}

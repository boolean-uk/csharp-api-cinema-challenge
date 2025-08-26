using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
            //modelBuilder.Entity<Customer>().HasMany(t => t.Tickets);
            /*modelBuilder.Entity<Customer>()
                .HasMany(c => c.Tickets)
                .WithOne(c => c.Customer);*/
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany(t => t.Tickets)
                .HasForeignKey(t => t.ScreeningId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(t => t.Tickets)
                .HasForeignKey(t => t.CustomerId);

            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(s => s.Screenings)
                .HasForeignKey(s => s.MovieId);

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }


        //public DbSet<Ticket> Ticket { get; set; }
        //publi
    }
}

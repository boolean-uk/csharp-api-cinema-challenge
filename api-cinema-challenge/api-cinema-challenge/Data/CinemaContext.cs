using System.Numerics;
using api_cinema_challenge.Data.api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnectionString"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seed = new Seeder();

            modelBuilder.Entity<Customer>().HasKey(c => c.Id);
            modelBuilder.Entity<Movie>().HasKey(m => m.Id);
            modelBuilder.Entity<Screening>().HasKey(s => s.Id);
            modelBuilder.Entity<Ticket>().HasKey(t => t.Id);

            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Screening)
                .WithMany(s => s.Tickets)
                .HasForeignKey(t => t.ScreeningId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Customer>().HasData(seed.Customers);
            modelBuilder.Entity<Movie>().HasData(seed.Movies);
            modelBuilder.Entity<Screening>().HasData(seed.Screenings);
            modelBuilder.Entity<Ticket>().HasData(seed.Tickets);
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }


    }
}

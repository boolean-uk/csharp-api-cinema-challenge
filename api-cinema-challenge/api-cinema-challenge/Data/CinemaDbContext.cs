using System.Diagnostics;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public sealed class CinemaDbContext : DbContext
    {
        private readonly string _connectionString;

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnection")!;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seeder seeds = new Seeder();

            // One-to-many relationships
            // One customer to many tickets
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Tickets)
                .WithOne(t => t.Customer)
                .HasForeignKey(t => t.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            //Many tickets to one screening
            modelBuilder.Entity<Screening>()
                .HasMany(c => c.Tickets)
                .WithOne(t => t.Screening)
                .HasForeignKey(t => t.ScreeningId)
                .OnDelete(DeleteBehavior.Cascade);

            // Many screenings to one movie
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Screenings)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data
            modelBuilder.Entity<Movie>().HasData(seeds.Movies);
            modelBuilder.Entity<Customer>().HasData(seeds.Customers);
            modelBuilder.Entity<Screening>().HasData(seeds.Screenings);
            modelBuilder.Entity<Ticket>().HasData(seeds.Tickets);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
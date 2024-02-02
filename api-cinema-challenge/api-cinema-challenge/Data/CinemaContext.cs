using api_cinema_challenge.Model;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public CinemaContext(DbContextOptions<CinemaContext> options , IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
            this.Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships
            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId);

            // Seed data
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1 , Title = "Movie 1" , Rating = "PG" , Description = "Description 1" , RuntimeMins = 120 } ,
                new Movie { Id = 2 , Title = "Movie 2" , Rating = "PG-13" , Description = "Description 2" , RuntimeMins = 130 }
            );

            modelBuilder.Entity<Screening>().HasData(
                new Screening { Id = 1 , ScreenNumber = 1 , Capacity = 100 , StartsAt = DateTime.UtcNow , MovieId = 1 } ,
                new Screening { Id = 2 , ScreenNumber = 2 , Capacity = 200 , StartsAt = DateTime.UtcNow , MovieId = 2 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1 , Name = "Customer 1" , Email = "customer1@example.com" , Phone = "1234567890" } ,
                new Customer { Id = 2 , Name = "Customer 2" , Email = "customer2@example.com" , Phone = "0987654321" }
            );
        }
    }
}

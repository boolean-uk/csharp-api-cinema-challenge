using System.Diagnostics;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "John Doe", Email = "JohnDoe@gmail.com", Phone = "+2434234255", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow},
                new Customer { Id = 2, Name = "Jane Doe", Email = "JaneJane@Jane.com", Phone = "+8888888888", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Doctor Dolittle", Rating = "PG-13", Description = "Friendly animal man.", RunTimeMins = 91, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Movie { Id = 2, Title = "Bullet Train", Rating = "R", Description ="Brad Pitt goes on a train ride.", RunTimeMins = 125, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets {  get; set; }
    }
}

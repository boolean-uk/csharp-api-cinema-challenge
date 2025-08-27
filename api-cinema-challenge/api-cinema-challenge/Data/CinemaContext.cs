using api_cinema_challenge.DataModels;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : IdentityUserContext<ApplicationUser>
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
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Description = "t", Rating = "1", Title = "bullshit", CreatedAt = new DateTime(2025, 8, 21, 13, 30, 0, DateTimeKind.Utc), UpdatedAt = new DateTime(2025, 8, 21, 13, 30, 0, DateTimeKind.Utc), RuntimeMins = 10 });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

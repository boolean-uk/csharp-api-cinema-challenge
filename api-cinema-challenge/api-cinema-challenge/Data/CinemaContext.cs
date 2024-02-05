using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System.Numerics;
using api_cinema_challenge.Models;

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
            modelBuilder.Entity<Screening>().HasKey(e => new { e.Id });
            modelBuilder.Entity<Ticket>().HasOne(u => u.Customer).WithMany(t => t.Tickets).HasForeignKey(fk => fk.CustomerId);
            modelBuilder.Entity<Ticket>().HasOne(s => s.Screening).WithMany(t => t.Tickets).HasForeignKey(fk => fk.ScreeningId);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Klara Andersson", Email = "klara.andersson@telia.com", Phone = "123854", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
                new Customer { Id = 2, Name = "Peter Andersson", Email = "peter.andersson@telia.com", Phone = "467215", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
                new Customer { Id = 3, Name = "Arvid Andersson", Email = "arvid.andersson@telia.com", Phone = "8751345", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Throne of Glass", Rating = "PG-13", Description = "Adaption of the greatest book", RuntimeMins = 160, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
                new Movie { Id = 2, Title = "Queen of Shadows", Rating = "PG-20", Description = "A girl assassin saves the city", RuntimeMins = 200, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
                new Movie { Id = 3, Title = "Fourth Wing", Rating = "PG-10", Description = "Riding dragons", RuntimeMins = 100, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() }
                );

            List<Screening> screenList = new List<Screening>();
            screenList.Add(new Screening { Id = 1, ScreenNumber = 5, Capacity = 40, StartsAt = DateTime.Today.ToUniversalTime(), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 2 });
            screenList.Add(new Screening { Id = 2, ScreenNumber = 3, Capacity = 100, StartsAt = DateTime.Today.ToUniversalTime(), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 3 });
            screenList.Add(new Screening { Id = 3, ScreenNumber = 1, Capacity = 20, StartsAt = DateTime.Today.ToUniversalTime(), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime(), MovieId = 1 });
            modelBuilder.Entity<Screening>().HasData(screenList);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

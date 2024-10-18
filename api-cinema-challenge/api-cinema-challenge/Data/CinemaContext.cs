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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .HasKey(t => t.Id);

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

            modelBuilder.Entity<Screening>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Screenings)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data

            modelBuilder.Entity<Customer>().HasData
                (
                    new Customer() { Id = 1, Name = "John Bravo", Email = "John@mail.no", Phone = "99887766", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Customer() { Id = 2, Name = "Thomas Fly", Email = "Fly@mail.no", Phone = "98765432",  CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Customer() { Id = 3, Name = "Ibby Secka", Email = "Ibb@live.no", Phone = "45094509", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );


            modelBuilder.Entity<Movie>().HasData
                (
                    new Movie() { Id = 1, Title = "Once Upon A Time In Hollywood", Rating = "9.3", Description = "Leo in Hollywood", RuntimeMins = 220, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Movie() { Id = 2, Title = "Iron Man", Rating = "7.3", Description = "Iron suit man kills enemies.", RuntimeMins = 180, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Movie() { Id = 3, Title = "Interstellar", Rating = "8", Description = "Man in space", RuntimeMins = 90, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );


            modelBuilder.Entity<Screening>().HasData
                (
                    new Screening() { Id = 1, MovieId = 1, ScreenNumber = 1, StartsAt = DateTime.UtcNow + TimeSpan.FromHours(4), Capacity = 50, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Screening() { Id = 2, MovieId = 1, ScreenNumber = 2, StartsAt = DateTime.UtcNow + TimeSpan.FromHours(5), Capacity = 30, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Screening() { Id = 3, MovieId = 2, ScreenNumber = 3, StartsAt = DateTime.UtcNow + TimeSpan.FromHours(5), Capacity = 50, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Screening() { Id = 4, MovieId = 3, ScreenNumber = 4, StartsAt = DateTime.UtcNow + TimeSpan.FromHours(7), Capacity = 25, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );

            modelBuilder.Entity<Ticket>().HasData
                (
                    new Ticket() { Id = 1, CustomerId = 1, ScreeningId = 1, NumSeats = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Ticket() { Id = 2, CustomerId = 2, ScreeningId = 3, NumSeats = 27, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                    new Ticket() { Id = 3, CustomerId = 3, ScreeningId = 2, NumSeats = 12, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                );
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}

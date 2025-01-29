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
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Movie>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Screen>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<ScreenMovie>()
                .HasKey(sm => sm.Id);

            modelBuilder.Entity<Ticket>()
                .HasKey(t => t.Id);


            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Tickets)
                .WithOne(t => t.Customer);

            modelBuilder.Entity<ScreenMovie>()
                .HasOne(sm => sm.Screen)
                .WithMany(s => s.ScreenMovies)
                .HasForeignKey(sm => sm.ScreenId);

            modelBuilder.Entity<ScreenMovie>()
                .HasOne(sm => sm.Movie)
                .WithMany(m => m.ScreenMovies)
                .HasForeignKey(sm => sm.MovieId);

            modelBuilder.Entity<Screen>()
                .HasMany(s => s.ScreenMovies)
                .WithOne(sm => sm.Screen);

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.ScreenMovies)
                .WithOne(sm => sm.Movie);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Customer)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.PersonId);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.ScreenMovie)
                .WithMany(sm => sm.Tickets);

            // Seed data
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "John Doe", Email = "John.Doe@gmail.com", Phone = "12345678", CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },
                new Customer { Id = 2, Name = "Jane Doe", Email = "Jane.Doe@gmail.com", Phone="90123456", CreatedAt=DateTime.Now.ToUniversalTime(), UpdatedAt=DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<Movie>().HasData(

                new Movie { Id = 1, Title = "Titanic", Rating = "pg-13", Description = "A good movie about boats", RuntimeMins = 120, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },

                new Movie { Id = 2, Title = "The Matrix", Rating = "pg-13", Description = "A good movie about pills", RuntimeMins = 132, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<Screen>().HasData(

                new Screen { Id = 1, ScreenNumber = 1, Capacity = 90, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },

                new Screen { Id = 2, ScreenNumber = 2, Capacity = 90, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<ScreenMovie>().HasData(

                new ScreenMovie { Id = 1, AvailableSeats = 90, ScreenId = 1, MovieId = 1, StartsAt = DateTime.Now.ToUniversalTime(), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },

                new ScreenMovie { Id = 2, AvailableSeats = 90, ScreenId = 2, MovieId = 2, StartsAt = DateTime.Now.ToUniversalTime(), CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });

            modelBuilder.Entity<Ticket>().HasData(

                new Ticket { Id = 1, PersonId = 1, ScreenMovieId = 1, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() },

                new Ticket { Id = 2, PersonId = 2, ScreenMovieId = 2, CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() });


        }
    }
}

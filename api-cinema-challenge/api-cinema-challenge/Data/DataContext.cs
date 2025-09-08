using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public sealed class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseNpgsql(_connectionString);
            optionsBuilder.UseInMemoryDatabase("Database");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1, Name = "John Doe", Email = "b@b.nl", Phone = "phonenumber", CreatedAt = DateTime.MinValue,
                UpdatedAt = DateTime.MinValue
            });

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1, CreatedAt = DateTime.MinValue, Description = "DESCRIPTION", Rating = "10/10",
                    RuntimeMins = 5, Title = "title", UpdatedAt = DateTime.MinValue
                }
            );

            modelBuilder.Entity<Screening>().HasData(new Screening
            {
                Id = 1, CreatedAt = DateTime.MinValue, UpdatedAt = DateTime.MinValue, Capacity = 5, MovieId = 1,
                ScreenNumber = 1, StartsAt = DateTime.MinValue,
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "johndoe",
                PasswordHash = "$2a$11$1Cp4pRvdnJ7YDRQmBW9qme1fBLmRI1OcZCK6RG0.CpiSZH1Fk5LsK",
            });
        }
    }
}
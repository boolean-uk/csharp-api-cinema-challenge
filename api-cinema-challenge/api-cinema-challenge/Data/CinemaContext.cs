using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using api_cinema_challenge.Models;
using System.Numerics;

namespace api_cinema_challenge.Data
{
    public class CinemaContext : DbContext
    {
        private string _connectionString;
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;
            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
               new Customer { Id = 1, Name = "Nigel" , Email = "nigel@gmail.com" , Phone = "44647282"},
               new Customer { Id = 2, Name = "Dave" , Email = "dave@gmail.com", Phone = "98417321"},
               new Customer { Id = 3, Name = "Julia" , Email = "julia@gmail.com", Phone = "47543219"}
            );

            modelBuilder.Entity<Movie>().HasData(
               new Movie { Id = 1, Title = "Titanic", Rating = "PG-13", Description = "Boats", RuntimeMins = 240 },
               new Movie { Id = 2, Title = "Conjuring", Rating = "PG-15", Description = "Scary", RuntimeMins = 90 },
               new Movie { Id = 3, Title = "Avatar", Rating = "PG-9", Description = "Blue people", RuntimeMins = 200 }
            );

            modelBuilder.Entity<Screening>().HasData(
               new Screening { Id = 1, ScreenNumber = 3, Capacity = 100, StartsAt = DateTime.SpecifyKind(DateTime.Parse("2024-11-15T16:30:00Z"), DateTimeKind.Utc), MovieId = 3 },
               new Screening { Id = 2, ScreenNumber = 2, Capacity = 250, StartsAt = DateTime.SpecifyKind(DateTime.Parse("2024-11-17T18:00:00Z"), DateTimeKind.Utc), MovieId = 2 },
               new Screening { Id = 3, ScreenNumber = 1, Capacity = 55, StartsAt = DateTime.SpecifyKind(DateTime.Parse("2024-11-14T15:00:00Z"), DateTimeKind.Utc), MovieId = 1 }
            );

            modelBuilder.Entity<Ticket>().HasData(
               new Ticket { Id = 1, NumSeats = 5, CustomerId = 1, ScreeningId = 1 },
               new Ticket { Id = 2, NumSeats = 2, CustomerId = 2, ScreeningId = 2 },
               new Ticket { Id = 3, NumSeats = 7, CustomerId = 3, ScreeningId = 3 }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}

using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace api_cinema_challenge.Data
{
    public static class ModelSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Lionel Messi",
                    Email = "messi@messi.messi",
                    Phone = "90121413",
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc)
                },
                new Customer
                {
                    Id = 2,
                    Name = "Cristiano Ronaldo",
                    Email = "ronaldo@ronaldo.ronaldo",
                    Phone = "90121414",
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc)
                },
                new Customer
                {
                    Id = 3,
                    Name = "Wayne Rooney",
                    Email = "rooney@rooney.rooney",
                    Phone = "90121415",
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Inception",
                    Rating = "PG-13",
                    Description = "A thief who steals corporate secrets through dream-sharing technology.",
                    RuntimeMins = 148,
                    CreatedAt = new DateTime(2010, 7, 16, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2010, 7, 16, 11, 1, 56, 633, DateTimeKind.Utc)
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Matrix",
                    Rating = "R",
                    Description = "A computer hacker learns about the true nature of his reality.",
                    RuntimeMins = 136,
                    CreatedAt = new DateTime(1999, 3, 31, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(1999, 3, 31, 11, 1, 56, 633, DateTimeKind.Utc)
                },
                new Movie
                {
                    Id = 3,
                    Title = "Interstellar",
                    Rating = "PG-13",
                    Description = "A team of explorers travel through a wormhole in space.",
                    RuntimeMins = 169,
                    CreatedAt = new DateTime(2014, 11, 7, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2014, 11, 7, 11, 1, 56, 633, DateTimeKind.Utc)
                }
            );

            modelBuilder.Entity<Screening>().HasData(
                new Screening
                {
                    Id = 1,
                    ScreenNumber = 5,
                    Capacity = 40,
                    StartsAt = new DateTime(2023, 3, 19, 11, 30, 0, DateTimeKind.Utc),
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    MovieId = 1
                },
                new Screening
                {
                    Id = 2,
                    ScreenNumber = 3,
                    Capacity = 60,
                    StartsAt = new DateTime(2023, 3, 20, 15, 0, 0, DateTimeKind.Utc),
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    MovieId = 2
                },
                new Screening
                {
                    Id = 3,
                    ScreenNumber = 7,
                    Capacity = 30,
                    StartsAt = new DateTime(2023, 3, 21, 18, 45, 0, DateTimeKind.Utc),
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    MovieId = 3
                }
            );

            // ticket seed data
            modelBuilder.Entity<Ticket>().HasData(
                new Ticket
                {
                    Id = 1,
                    NumSeats = 2,
                    CustomerId = 1,
                    ScreeningId = 1,
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc)
                },
                new Ticket
                {
                    Id = 2,
                    NumSeats = 4,
                    CustomerId = 2,
                    ScreeningId = 1,
                    CreatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc),
                    UpdatedAt = new DateTime(2023, 3, 14, 11, 1, 56, 633, DateTimeKind.Utc)
                }
            );
        }
    }
}
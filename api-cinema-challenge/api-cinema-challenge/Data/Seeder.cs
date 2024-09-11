using api_cinema_challenge.Models;
using System;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public static async void SeedCinemaApi(this WebApplication app)
        {
            using var db = new CinemaContext();

            if (!db.Customers.Any())
            {
                db.Customers.Add(new Customer
                {
                    Name = "Agron Metaj",
                    Phone = "0735871826",
                    Email = "agron.metaj@cinema.enjoyer.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });
                db.Customers.Add(new Customer
                {
                    Name = "Nigel Sibbert",
                    Phone = "0735619238",
                    Email = "nigel.sibbert@cinema.enjoyer.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });
                db.Customers.Add(new Customer
                {
                    Name = "Dave Ames",
                    Phone = "0735617291",
                    Email = "dave.ames@cinema.enjoyer.com",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                });
                await db.SaveChangesAsync();
            }
            if (!db.Movies.Any())
            {
                db.Movies.AddRange(
                    new Movie
                    {
                        Title = "Dodgeball",
                        Rating = "PG-13",
                        Description = "The greatest movie ever made",
                        RuntimeMins = 126,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Movie
                    {
                        Title = "Inception",
                        Rating = "PG-13",
                        Description = "A mind-bending thriller about dreams within dreams.",
                        RuntimeMins = 148,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Movie
                    {
                        Title = "The Matrix",
                        Rating = "R",
                        Description = "A computer hacker learns the world is a simulation.",
                        RuntimeMins = 136,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                await db.SaveChangesAsync();
            }

            if (!db.Screenings.Any())
            {
                db.Screenings.AddRange(
                    new Screening
                    {
                        MovieId = 1,
                        ScreenNumber = 5,
                        Capacity = 40,
                        StartsAt = DateTime.UtcNow.AddDays(2),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Screening
                    {
                        MovieId = 2,
                        ScreenNumber = 3,
                        Capacity = 50,
                        StartsAt = DateTime.UtcNow.AddDays(3),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Screening
                    {
                        MovieId = 3,
                        ScreenNumber = 1,
                        Capacity = 60,
                        StartsAt = DateTime.UtcNow.AddDays(4),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                await db.SaveChangesAsync();
            }

            if (!db.Tickets.Any())
            {
                db.Tickets.AddRange(
                    new Ticket
                    {
                        CustomerId = 2,
                        NumSeats = 1,
                        ScreeningId = 1,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Ticket
                    {
                        CustomerId = 3,
                        NumSeats = 2,
                        ScreeningId = 2,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Ticket
                    {
                        CustomerId = 1,
                        NumSeats = 3,
                        ScreeningId = 3,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    });
                await db.SaveChangesAsync();
            }

        }
        public static async Task PurgeCinemaDbTables(this WebApplication app)
        {
            using var db = new CinemaContext();

            if (db.Tickets.Any())
            {
                db.Tickets.RemoveRange(db.Tickets);
            }

            if (db.Screenings.Any())
            {
                db.Screenings.RemoveRange(db.Screenings);
            }

            if (db.Movies.Any())
            {
                db.Movies.RemoveRange(db.Movies);
            }

            if (db.Customers.Any())
            {
                db.Customers.RemoveRange(db.Customers);
            }

            await db.SaveChangesAsync();
        }

    }
}

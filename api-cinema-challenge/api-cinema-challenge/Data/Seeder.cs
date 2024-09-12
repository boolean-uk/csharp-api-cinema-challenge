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
                var screenings = new List<Screening>
                {
                    new Screening
                    {
                        MovieId = db.Movies.First(m => m.Title == "Dodgeball").Id,
                        ScreenNumber = 5,
                        Capacity = 40,
                        StartsAt = DateTime.UtcNow.AddDays(2),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Screening
                    {
                        MovieId = db.Movies.First(m => m.Title == "Inception").Id,
                        ScreenNumber = 3,
                        Capacity = 50,
                        StartsAt = DateTime.UtcNow.AddDays(3),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Screening
                    {
                        MovieId = db.Movies.First(m => m.Title == "The Matrix").Id,
                        ScreenNumber = 1,
                        Capacity = 60,
                        StartsAt = DateTime.UtcNow.AddDays(4),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                };
                db.Screenings.AddRange(screenings);
                await db.SaveChangesAsync();
            }
        

            if (!db.Tickets.Any())
            {
                var tickets = new List<Ticket>
                {
                    new Ticket
                    {
                        CustomerId = db.Customers.First(c => c.Name == "Nigel Sibbert").Id,
                        NumSeats = 1,
                        ScreeningId = db.Screenings.First(s => s.ScreenNumber == 5).Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Ticket
                    {
                        CustomerId = db.Customers.First(c => c.Name == "Dave Ames").Id,
                        NumSeats = 2,
                        ScreeningId = db.Screenings.First(s => s.ScreenNumber == 3).Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Ticket
                    {
                        CustomerId = db.Customers.First(c => c.Name == "Agron Metaj").Id,
                        NumSeats = 3,
                        ScreeningId = db.Screenings.First(s => s.ScreenNumber == 1).Id,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                };

                db.Tickets.AddRange(tickets);
                await db.SaveChangesAsync();
            }

}
        public static async void PurgeCinemaDbTables(this WebApplication app)
        {
            using var db = new CinemaContext();

            if (db.Tickets.Any())
            {
                db.Tickets.RemoveRange(db.Tickets);
                await db.SaveChangesAsync();
            }

            if (db.Screenings.Any())
            {
                db.Screenings.RemoveRange(db.Screenings);
                await db.SaveChangesAsync();
            }

            if (db.Movies.Any())
            {
                db.Movies.RemoveRange(db.Movies);
                await db.SaveChangesAsync();
            }

            if (db.Customers.Any())
            {
                db.Customers.RemoveRange(db.Customers);
                await db.SaveChangesAsync();
            }
        }

    }
}

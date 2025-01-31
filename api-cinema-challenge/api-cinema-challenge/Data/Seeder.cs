using System;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public static class Seeder
{
    public static async Task SeedCinemaData(this WebApplication app) 
    {
        using(var db = new CinemaContext())
        {
            if (!db.Movies.Any())
            {
                var movie1 = new Movie { Title = "The Matrix", RuntimeMins = 120, Rating = "PG-13", Description = "A computer hacker learns about the true nature of reality." };
                var movie2 = new Movie { Title = "The Matrix Reloaded", RuntimeMins = 138, Rating = "R", Description = "The second installment of the Matrix trilogy." };
                var movie3 = new Movie { Title = "The Matrix Revolutions", RuntimeMins = 129, Rating = "R", Description = "The final installment of the Matrix trilogy." };

                db.AddRange(movie1, movie2, movie3);
                await db.SaveChangesAsync(); // Ensure IDs are assigned

                // Refresh movie instances with assigned IDs
                var movies = db.Movies.ToList();
                movie1 = movies.First(m => m.Title == "The Matrix");
                movie2 = movies.First(m => m.Title == "The Matrix Reloaded");
                movie3 = movies.First(m => m.Title == "The Matrix Revolutions");

                Console.WriteLine("Movies seeded.");
            }

            if (!db.Screenings.Any())
            {
                var movie1 = db.Movies.First(m => m.Title == "The Matrix");
                var movie2 = db.Movies.First(m => m.Title == "The Matrix Reloaded");
                var movie3 = db.Movies.First(m => m.Title == "The Matrix Revolutions");

                db.Add(new Screening { MovieId = movie1.Id, StartsAt = DateTime.UtcNow.AddHours(1) });
                db.Add(new Screening { MovieId = movie1.Id, StartsAt = DateTime.UtcNow.AddHours(3) });
                db.Add(new Screening { MovieId = movie2.Id, StartsAt = DateTime.UtcNow.AddHours(2) });
                db.Add(new Screening { MovieId = movie2.Id, StartsAt = DateTime.UtcNow.AddHours(4) });
                db.Add(new Screening { MovieId = movie3.Id, StartsAt = DateTime.UtcNow.AddHours(5) });
                db.Add(new Screening { MovieId = movie3.Id, StartsAt = DateTime.UtcNow.AddHours(7) });
                await db.SaveChangesAsync();

                Console.WriteLine("Screenings seeded.");
            }

            if (!db.Customers.Any())
            {
                var customer1 = new Customer { Name = "Alice", Email = "alice@example.com", Phone = "1234567890" };
                var customer2 = new Customer { Name = "Bob", Email = "bob@example.com", Phone = "0987654321" };

                db.AddRange(customer1, customer2);
                await db.SaveChangesAsync();

                // Refresh customer instances with assigned IDs
                var customers = db.Customers.ToList();
                customer1 = customers.First(c => c.Name == "Alice");
                customer2 = customers.First(c => c.Name == "Bob");

                Console.WriteLine("Customers seeded.");

                if (!db.Tickets.Any())
                {
                    var movie1 = db.Movies.First(m => m.Title == "The Matrix");
                    var movie2 = db.Movies.First(m => m.Title == "The Matrix Reloaded");
                    var movie3 = db.Movies.First(m => m.Title == "The Matrix Revolutions");
                    
                    var screening1 = db.Screenings.First(s => s.MovieId == movie1.Id);
                    var screening2 = db.Screenings.First(s => s.MovieId == movie2.Id);
                    var screening3 = db.Screenings.First(s => s.MovieId == movie3.Id);

                    db.Add(new Ticket { NumSeats = 2, ScreeningId = screening1.Id, CustomerId = customer1.Id });
                    db.Add(new Ticket { NumSeats = 3, ScreeningId = screening2.Id, CustomerId = customer1.Id });
                    db.Add(new Ticket { NumSeats = 1, ScreeningId = screening3.Id, CustomerId = customer2.Id });
                    db.Add(new Ticket { NumSeats = 4, ScreeningId = screening3.Id, CustomerId = customer2.Id });
                    await db.SaveChangesAsync();

                    Console.WriteLine("Tickets seeded.");
                }   
            }
        }
    }

    public static async Task ResetCinemaData(this WebApplication app)
    {
        using (var db = new CinemaContext())
        {
            db.Tickets.RemoveRange(db.Tickets);
            db.Screenings.RemoveRange(db.Screenings);
            db.Movies.RemoveRange(db.Movies);
            db.Customers.RemoveRange(db.Customers);

            await db.SaveChangesAsync();
        }
    }

    public static async Task RecreateAndSeedDatabase(this WebApplication app)
    {
        using (var db = new CinemaContext())
        {
            await db.Database.EnsureDeletedAsync();
            await db.Database.EnsureCreatedAsync();
            await app.SeedCinemaData();
        }
    }
}

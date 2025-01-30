using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static Task SeedCinemaData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();

                if (!db.Movies.Any())
                {
                    db.Movies.AddRange(
                        new Movie { Title = "The Matrix", Rating = "R", Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", RuntimeMins = 136, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Movie { Title = "Inception", Rating = "PG-13", Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.", RuntimeMins = 148, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    );
                    await db.SaveChangesAsync();
                }

                if (!db.Customers.Any())
                {
                    db.Customers.AddRange(
                        new Customer { Name = "Chris Wolstenholme", Email = "chris@muse.mu", Phone = "+44729388192", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Customer { Name = "Jonny Greenwood", Email = "jonny@radiohead.com", Phone = "+44720488192", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    );
                    await db.SaveChangesAsync();
                }

                if (!db.Screenings.Any())
                {
                    db.Screenings.AddRange(
                        new Screening { MovieId = 1, ScreenNumber = 1, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(1), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Screening { MovieId = 2, ScreenNumber = 2, Capacity = 80, StartsAt = DateTime.UtcNow.AddDays(2), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    );
                    await db.SaveChangesAsync();
                }

                if (!db.Tickets.Any())
                {
                    var customerChris = db.Customers.First(c => c.Name == "Chris Wolstenholme");
                    var customerJonny = db.Customers.First(c => c.Name == "Jonny Greenwood");
                    var screeningMatrix = db.Screenings.First(s => s.MovieId == 1);
                    var screeningInception = db.Screenings.First(s => s.MovieId == 2);

                    db.Tickets.AddRange(
                        new Ticket { CustomerId = customerChris.Id, ScreeningId = screeningMatrix.Id, NumSeats = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                        new Ticket { CustomerId = customerJonny.Id, ScreeningId = screeningInception.Id, NumSeats = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
                    );
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

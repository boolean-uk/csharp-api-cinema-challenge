using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedData(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                if (!db.Movies.Any())
                {
                    db.Movies.Add(new Movie
                    {
                        Title = "Dodgeball",
                        Rating = "PG-13",
                        Description = "The greatest movie ever made.",
                        RuntimeMins = 126,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });

                    await db.SaveChangesAsync();
                }

                if (!db.Screenings.Any())
                {
                    db.Screenings.Add(new Screening
                    {
                        MovieId = 1,
                        ScreenNumber = 5,
                        Capacity = 40,
                        StartsAt = new DateTime(2025, 4, 20, 23, 0, 0),
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });

                    await db.SaveChangesAsync();
                }

                if (!db.Customers.Any())
                {
                    db.Customers.Add(new Customer
                    {
                        Name = "John",
                        Email = "Doe",
                        Phone = "+44729388192",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    });

                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

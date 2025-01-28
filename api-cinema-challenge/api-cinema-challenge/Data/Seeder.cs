using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinema(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();

                if (!db.Customers.Any())
                {
                    db.Add(new Customer { Name = "Ola Nordmann", Email = "ola@nordmann.no", Phone = "+4712345678", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    db.Add(new Customer { Name = "Alo Nnamdron", Email = "alo@nnamdron.on", Phone = "+4787654321", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }

                if (!db.Movies.Any())
                {
                    db.Add(new Movie { Title = "The Shawshank Redemption", Rating = 9.3M, Description = "*Imagine a very good description*", RuntimeMins = 144, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    db.Add(new Movie { Title = "The Godfather", Rating = 9.2M, Description = "*Imagine a very good description*", RuntimeMins = 175, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }

                if (!db.Screenings.Any())
                {
                    db.Add(new Screening { MovieId = 1, ScreenNumber = 5, Capacity = 40, StartsAt = new DateTime(2025, 2, 1, 18, 30, 0).ToUniversalTime(), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    db.Add(new Screening { MovieId = 2, ScreenNumber = 3, Capacity = 50, StartsAt = new DateTime(2025, 2, 2, 20, 0, 0).ToUniversalTime(), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }

                if (!db.Tickets.Any())
                {
                    db.Add(new Ticket { CustomerId = 1, ScreeningId = 1, NumSeats = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    db.Add(new Ticket { CustomerId = 2, ScreeningId = 2, NumSeats = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

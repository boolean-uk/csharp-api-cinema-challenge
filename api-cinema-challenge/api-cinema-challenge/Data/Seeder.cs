using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                if (!db.Customers.Any())
                {
                    db.Customers.Add(new Customer() { Name = "Erik", Email = "Erik@Erik.com", Phone = "0701449999", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }

                if (!db.Movies.Any())
                {
                    db.Movies.Add(new Movie() { Title = "One Piece", Description = "Pirates are scatering across the world looking for the one piece", Rating = "PG-13", RuntimeMins = 1000, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();

                }

                if (!db.Screenings.Any())
                {
                    db.Screenings.Add(new Screening() { MovieId = 1, ScreenNumber = 5, Capacity = 200, StartTime = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    var screening = await db.Screenings.FindAsync(1);
                    var movie = await db.Movies.FindAsync(1);
                    movie.Screenings.ToList().Add(screening);
                    db.Movies.Update(movie);
                    await db.SaveChangesAsync();
                }

                if (!db.Tickets.Any())
                {
                    db.Tickets.Add(new Ticket() { CustomerId = 1, ScreeningId = 1, NumSeats = 20, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }


            }
        }
    }
}


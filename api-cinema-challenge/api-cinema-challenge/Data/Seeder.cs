using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static Task SeedCinemaData(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();

            if (!db.Customers.Any())
            {
                db.Add(new Customer() { name = "Petter", email = "petter@email.no", phone = "22138640", });
                db.Add(new Customer() { name = "Harold", email = "harold@email.no", phone = "22225555", });
                await db.SaveChangesAsync();
            }
            if (!db.Movies.Any())
            {
                db.Add(new Movie() { title = "Scream", description = "Horror", runtimeMins = 100, rating = "PG-13" });
                db.Add(new Movie() { title = "Moana", description = "Anmation", runtimeMins = 93, rating = "PG-3" });
                await db.SaveChangesAsync();
            }
            if (!db.Screenings.Any())
            {
                db.Add(new Screening() { movieId = 1, capacity = 50, screenNumber = 4, startsAt = new DateTime(2025, 1, 28, 12, 0, 0) });
                db.Add(new Screening() { movieId = 2, capacity = 30, screenNumber = 5, startsAt = new DateTime(2025, 1, 28, 13, 0, 0) });
                await db.SaveChangesAsync();
            }
            if (!db.Tickets.Any())
            {
                db.Add(new Ticket() { customerId = 1, screeningId = 1, numSeats = 3 });
                db.Add(new Ticket() { customerId = 2, screeningId = 1, numSeats = 5 });
                await db.SaveChangesAsync();
            }
        }

    }
}

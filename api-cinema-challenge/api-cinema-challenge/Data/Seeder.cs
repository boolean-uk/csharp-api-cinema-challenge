using api_cinema_challenge.Models;
using api_cinema_challenge.Data;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                if (!db.Customers.Any())
                {
                    db.Add(new Customer() { Name = "Nigel", Email = "Nigel@nigel.com", Phone = "410 011 22", CreatedAt = DateTime.UtcNow});
                    db.Add(new Customer() { Name = "Dave", Email = "Dave@dave.com", Phone = "411 111 33", CreatedAt = DateTime.UtcNow });
                    db.Add(new Customer() { Name = "Kristoffer", Email = "Kristoffer@kristoffer.com", Phone = "433 000 44", CreatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Title = "Iron Man", Rating = "9",Description = "Superhero movie", RunTimeMins = 160, CreatedAt = DateTime.UtcNow });
                    db.Add(new Movie() { Title = "Spider Man", Rating = "8", Description = "Superhero movie", RunTimeMins = 160, CreatedAt = DateTime.UtcNow });
                    db.Add(new Movie() { Title = "Batman", Rating = "10", Description = "Superhero movie", RunTimeMins = 160, CreatedAt = DateTime.UtcNow });
                    await db.SaveChangesAsync();

                }


                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { MovieId = 1, ScreenNumber = 10, Capacity = 100, StartsAt = new DateTime(2025, 1, 30, 14,30,0, DateTimeKind.Utc) });
                    db.Add(new Screening() { MovieId = 2, ScreenNumber = 11, Capacity = 110, StartsAt = new DateTime(2025, 1, 30, 15, 30, 0, DateTimeKind.Utc) });
                    db.Add(new Screening() { MovieId = 3, ScreenNumber = 12, Capacity = 120, StartsAt = new DateTime(2025, 1, 30, 17, 30, 0, DateTimeKind.Utc) });



                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

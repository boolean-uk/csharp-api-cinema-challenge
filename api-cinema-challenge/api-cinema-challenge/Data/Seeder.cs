using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public static class Seeder
{
    public static async void SeedCinemaApi(this WebApplication app)
    {
        await using var db = new CinemaContext();
        var timeNow = DateTime.UtcNow;

        // Seed Customers
        if (!db.Customers.Any())
        {
            db.Customers.AddRange(new List<Customer>
            {
                new Customer { Name = "Ola Nordmann", Email = "ola.nordmann@example.com", PhoneNumber = "98123456", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Name = "Kari Nordmann", Email = "kari.nordmann@example.com", PhoneNumber = "45123456", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Name = "Petter Olsen", Email = "petter.olsen@example.com", PhoneNumber = "40123456", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Name = "Anne Hansen", Email = "anne.hansen@example.com", PhoneNumber = "98123457", CreatedAt = timeNow, UpdatedAt = timeNow },
                new Customer { Name = "Erik Johansen", Email = "erik.johansen@example.com", PhoneNumber = "45123457", CreatedAt = timeNow, UpdatedAt = timeNow }
            });
            await db.SaveChangesAsync();
        }

        // Seed Movies
        if (!db.Movies.Any())
        {
            db.Movies.AddRange(new List<Movie>
            {
                new Movie { Title = "Avatar", Rating = "PG-13", Description = "A marine on an alien planet.", DurationMinutes = 162, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Avengers: Endgame", Rating = "PG-13", Description = "The Avengers take a final stand.", DurationMinutes = 181, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Titanic", Rating = "PG-13", Description = "A love story on the doomed Titanic.", DurationMinutes = 195, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Star Wars: The Force Awakens", Rating = "PG-13", Description = "The next generation of Star Wars heroes.", DurationMinutes = 138, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Jurassic World", Rating = "PG-13", Description = "Dinosaurs return to a theme park.", DurationMinutes = 124, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "The Lion King", Rating = "PG", Description = "A live-action adaptation of the classic.", DurationMinutes = 118, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "The Dark Knight", Rating = "PG-13", Description = "Batman faces the Joker.", DurationMinutes = 152, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Frozen II", Rating = "PG", Description = "Elsa and Anna embark on a new journey.", DurationMinutes = 103, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "Harry Potter and the Deathly Hallows: Part 2", Rating = "PG-13", Description = "Harry faces Voldemort in the final battle.", DurationMinutes = 130, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Movie { Title = "The Lord of the Rings: The Return of the King", Rating = "PG-13", Description = "The final battle for Middle-Earth.", DurationMinutes = 201, CreatedAt = timeNow, UpdatedAt = timeNow }
            });
            await db.SaveChangesAsync();
        }

        // Seed Screenings
        if (!db.Screenings.Any())
        {
            var movie1 = db.Movies.First(m => m.Title == "Avatar");
            var movie2 = db.Movies.First(m => m.Title == "Avengers: Endgame");

            db.Screenings.AddRange(new List<Screening>
            {
                new Screening { ScreenNumber = 1, Capacity = 100, StartDate = new DateTime(2024, 9, 11, 10, 0, 0, DateTimeKind.Utc), MovieId = movie1.Id, CreatedAt = timeNow, UpdatedAt = timeNow },
                new Screening { ScreenNumber = 2, Capacity = 80, StartDate = new DateTime(2024, 9, 11, 12, 0, 0, DateTimeKind.Utc), MovieId = movie2.Id, CreatedAt = timeNow, UpdatedAt = timeNow }
            });
            await db.SaveChangesAsync();
        }
    }
}
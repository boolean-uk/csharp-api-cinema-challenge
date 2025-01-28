using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {

        public async static void SeedData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();

                if (!db.Customers.Any())
                {
                    db.Customers.AddRange(
                        new Customer
                        {
                            Name = "Nigel MovieWatcher",
                            Email = "nigel@movies.com",
                            Phone = "1234567890"
                        },
                        new Customer
                        {
                            Name = "Bobby PopcornEater",
                            Email = "bob@popcorn.com",
                            Phone = "0987654321"
                        },
                        new Customer
                        {
                            Name = "Sally SodaSipper",
                            Email = "sally@soda.com",
                            Phone = "1230984567"
                        },
                        new Customer
                        {
                            Name = "Suzy SnackLover",
                            Email = "suzy@snacks.com",
                            Phone = "0981237654"

                        });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Movies.AddRange(
                        new Movie { Title = "Bee movie", Rating = "PG", RuntimeMins = 95 , Description = "Moviee about bees"},
                        new Movie { Title = "The Incredibles", Rating = "PG", RuntimeMins = 115, Description = "This one is incredible" },
                        new Movie { Title = "The Incredibles 2", Rating = "PG", RuntimeMins = 125, Description = "This is incredible, but twice" },
                        new Movie { Title = "The Incredibles 3", Rating = "PG", RuntimeMins = 135, Description = "Threecredibles" },
                        new Movie { Title = "Alien", RuntimeMins = 120, Rating = "R", Description = "Bee movie but with alien instead of bee" },
                        new Movie { Title = "Aliens", RuntimeMins = 137, Rating = "R", Description = "Bee movie but with aliens instead of bees" }
                        );
                    await db.SaveChangesAsync();
                }
                if (!db.Screenings.Any())
                {
                    db.Screenings.AddRange(
                        new Screening { ScreenNumber = 1, MovieId = 1, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 12, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 2, MovieId = 1, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 14, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 3, MovieId = 1, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 16, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 4, MovieId = 1, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 18, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 5, MovieId = 1, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 20, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 1, MovieId = 2, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 12, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 2, MovieId = 2, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 14, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 3, MovieId = 2, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 16, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 4, MovieId = 2, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 18, 0, 0, DateTimeKind.Utc) },
                        new Screening { ScreenNumber = 5, MovieId = 2, Capacity = 100, StartsAt = new DateTime(2025, 2, 1, 20, 0, 0, DateTimeKind.Utc) });
                    await db.SaveChangesAsync();

                }
                if (!db.Tickets.Any())
                {
                    db.Tickets.AddRange(
                        new Ticket { ScreeningId = 1, CustomerId = 1, NumberOfSeats = 2 },
                        new Ticket { ScreeningId = 2, CustomerId = 2, NumberOfSeats = 3 },
                        new Ticket { ScreeningId = 3, CustomerId = 3, NumberOfSeats = 4 },
                        new Ticket { ScreeningId = 4, CustomerId = 4, NumberOfSeats = 5 },
                        new Ticket { ScreeningId = 5, CustomerId = 1, NumberOfSeats = 6 },
                        new Ticket { ScreeningId = 6, CustomerId = 2, NumberOfSeats = 7 },
                        new Ticket { ScreeningId = 7, CustomerId = 3, NumberOfSeats = 8 },
                        new Ticket { ScreeningId = 8, CustomerId = 4, NumberOfSeats = 9 },
                        new Ticket { ScreeningId = 9, CustomerId = 1, NumberOfSeats = 10 },
                        new Ticket { ScreeningId = 10, CustomerId = 2, NumberOfSeats = 11 });
                    await db.SaveChangesAsync();

                }
            }

        }
    }
}

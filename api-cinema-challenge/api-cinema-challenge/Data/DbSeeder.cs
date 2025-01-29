using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace api_cinema_challenge.Data
{
    public static class DbSeeder
    {
        public static async void SeedAsync(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using var db = scope.ServiceProvider.GetRequiredService<CinemaContext>();

                if (!db.Movie.Any())
                {
                    db.Movie.AddRange(
                        new Movie
                        {
                            Title = "Inception",
                            RuntimeMins = 139,
                            Rating = "PG-15",
                            Description = "Leonard Dag Condradsen drømmer seg bort"                           
                        },
                        new Movie
                        {
                            Title = "The Matrix",
                            RuntimeMins = 120,
                            Rating = "PG-13",
                            Description = "Ken-Ivar Rivdal unnslipper simulatoren"
                        },
                        new Movie
                        {
                            Title = "Interstellar",
                            RuntimeMins = 145,
                            Rating = "PG-12",
                            Description = "Mattis MæcCånnohei reiser i verdensrommet"
                        }
                    );
                }

                if (!db.Customer.Any())
                {
                    db.Customer.AddRange(
                        new Customer
                        {
                            Name = "John Doe",
                            Email = "john.doe@example.com",
                            PhoneNumber = "123456789",
                        },
                        new Customer
                        {
                            Name = "Jane Smith",
                            Email = "jane.smith@example.com",
                            PhoneNumber = "987654321",
                        }
                    );
                }


                await db.SaveChangesAsync();


                if (!db.Screening.Any())
                {
                    var inception = db.Movie.First(m => m.Title == "Inception");
                    var matrix = db.Movie.First(m => m.Title == "The Matrix");

                    db.Screening.AddRange(
                        new Screening
                        {
                            MovieId = inception.Id,
                            ScreenNumber = 1,
                            Capasity = 80,
                            StartsAt = DateTime.UtcNow.AddDays(1),
                        },
                        new Screening
                        {
                            MovieId = matrix.Id,
                            ScreenNumber = 2,
                            Capasity = 58,
                            StartsAt = DateTime.UtcNow.AddDays(2),
                        }
                    );
                }

                await db.SaveChangesAsync();


                if (!db.Ticket.Any())
                {
                    var screening1 = db.Screening.First(s => s.ScreenNumber == 1);
                    var customer1 = db.Customer.First(c => c.Name == "John Doe");

                    db.Ticket.AddRange(
                        new Ticket
                        {
                            CustomerId = customer1.Id,
                            ScreeningId = screening1.Id,
                            NumSeats = 2,
                        }
                    );
                }

                await db.SaveChangesAsync();
            }

        }
    }
}
             
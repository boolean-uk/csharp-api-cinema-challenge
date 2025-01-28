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
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        },
                        new Movie
                        {
                            Title = "The Matrix",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        },
                        new Movie
                        {
                            Title = "Interstellar",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
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
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        },
                        new Customer
                        {
                            Name = "Jane Smith",
                            Email = "jane.smith@example.com",
                            PhoneNumber = "987654321",
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
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
                            Movie_Id = inception.Id,
                            ScreenNumber = 1,
                            StartsAt = DateTime.UtcNow.AddDays(1),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        },
                        new Screening
                        {
                            Movie_Id = matrix.Id,
                            ScreenNumber = 2,
                            StartsAt = DateTime.UtcNow.AddDays(2),
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
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
                            Customer_id = customer1.Id,
                            Screening_id = screening1.Id,
                            NumSeats = 2,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow
                        }
                    );
                }

                await db.SaveChangesAsync();
            }

        }
    }
}
             
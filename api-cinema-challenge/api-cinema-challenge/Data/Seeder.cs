using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public static async void SeedDatabase(this WebApplication app)
        {
            using (CinemaContext db = new CinemaContext())
            {
                if (!db.Customers.Any())
                {
                    db.Customers.Add(new Customer()
                    {
                        Name = "Daniel",
                        Email = "Daniel@mail.com",
                        Phone = "1345678754"
                    });
                    db.Customers.Add(new Customer()
                    {
                        Name = "David",
                        Email = "David@mail.com",
                        Phone = "53468532"
                    });
                    db.Customers.Add(new Customer()
                    {
                        Name = "John",
                        Email = "John@mail.com",
                        Phone = "53468532"
                    });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Movies.Add(new Movie()
                    {
                        MovieName = "Oppenheimer"
                    });
                    db.Movies.Add(new Movie()
                    {
                        MovieName = "Barbie"
                    });
                    db.Movies.Add(new Movie()
                    {
                        MovieName = "Shrek"
                    });
                    await db.SaveChangesAsync();
                }
                if (!db.Screens.Any())
                {
                    db.Screens.Add(new Screen()
                    {
                        ScreenNumber = 1
                    });
                    db.Screens.Add(new Screen()
                    {
                        ScreenNumber = 2
                    });
                    db.Screens.Add(new Screen()
                    {
                        ScreenNumber = 3
                    });
                    await db.SaveChangesAsync();
                }
                if (!db.Screenings.Any())
                {
                    db.Screenings.Add(new Screening()
                    {
                        ScreenId = 1,
                        MovieId = 1,
                        ScreeningTime = DateTime.UtcNow.AddDays(1)

                    });
                    db.Screenings.Add(new Screening()
                    {
                        ScreenId = 2,
                        MovieId = 2,
                        ScreeningTime = DateTime.UtcNow.AddDays(2)

                    });
                    db.Screenings.Add(new Screening()
                    {
                        ScreenId = 3,
                        MovieId = 3,
                        ScreeningTime = DateTime.UtcNow.AddDays(3)

                    });
                    await db.SaveChangesAsync();
                }
                if (!db.Tickets.Any())
                {
                    db.Tickets.Add(new Ticket()
                    {
                        CustomerID = 2,
                        ScreeningID = 1
                    });
                    db.Tickets.Add(new Ticket()
                    {
                        CustomerID = 3,
                        ScreeningID = 2
                    });
                    db.Tickets.Add(new Ticket()
                    {
                        CustomerID = 4,
                        ScreeningID = 3
                    });
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

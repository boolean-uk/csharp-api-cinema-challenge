using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAsync(CinemaContext ctx)
        {
            if (!await ctx.Customers.AnyAsync())
            {
                ctx.Customers.AddRange(
                    new Customer { Name = "Ada Lovelace", Email = "ada@example.com", Phone = "+47 900 00 001" },
                    new Customer { Name = "Alan Turing", Email = "alan@example.com", Phone = "+47 900 00 002" }
                );
                await ctx.SaveChangesAsync();
            }

            if (!await ctx.Movies.AnyAsync())
            {
                ctx.Movies.AddRange(
                    new Movie { Title = "Oppenheimer", Rating = "15+", Description = "Biographical drama.", RuntimeMins = 180 },
                    new Movie { Title = "Barbie", Rating = "9+", Description = "Adventure comedy.", RuntimeMins = 114 }
                );
                await ctx.SaveChangesAsync();
            }

            if (!await ctx.Screenings.AnyAsync())
            {
                var now = DateTime.UtcNow;
                var movies = await ctx.Movies.AsNoTracking().ToListAsync();

                var s1 = new Screening
                {
                    MovieId = movies[0].Id,
                    ScreenNumber = 1,
                    Capacity = 120,
                    StartsAt = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0, DateTimeKind.Utc).AddDays(1)
                };
                var s2 = new Screening
                {
                    MovieId = movies[1].Id,
                    ScreenNumber = 2,
                    Capacity = 100,
                    StartsAt = new DateTime(now.Year, now.Month, now.Day, 20, 0, 0, DateTimeKind.Utc).AddDays(2)
                };

                ctx.Screenings.AddRange(s1, s2);
                await ctx.SaveChangesAsync();
            }

            if (!await ctx.Tickets.AnyAsync())
            {
                var customer = await ctx.Customers.FirstAsync();
                var screening = await ctx.Screenings.FirstAsync();

                ctx.Tickets.Add(new Ticket
                {
                    CustomerId = customer.Id,
                    ScreeningId = screening.Id,
                    SeatLabel = "B12"
                });
                await ctx.SaveChangesAsync();
            }
        }
    }
}

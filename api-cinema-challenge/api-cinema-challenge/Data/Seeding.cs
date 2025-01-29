using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeding
    {
        public async static void SeedDatabase(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                if(!db.Customers.Any())
                {
                    db.Add(new Customer() { Name = "Nigel", Phone = "40506070", Email = "nigel@boolean.co.uk", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Customer() { Name = "Dave", Phone = "60503020", Email = "dave@boolean.co.uk", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Customer() { Name = "Sandro", Phone = "10206090", Email = "sandro@espana.co.uk", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Customer() { Name = "Lisa", Phone = "40506070", Email = "lisa@email.com", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Title = "Scream", Rating = "PG-16", Description = "Big Masks equals big entertainment", RuntimeMinutes = 115, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Movie() { Title = "Kill Bill", Rating = "PG-16", Description = "Big Swords equals big entertainment", RuntimeMinutes = 94, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Movie() { Title = "Moana", Rating = "PG-7", Description = "Large Waves equals large entertainment", RuntimeMinutes = 98, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    await db.SaveChangesAsync();
                }
                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { ScreenNumber = 1, StartsAt = DateTime.SpecifyKind(new DateTime(2025, 1, 30, 19, 30, 0), DateTimeKind.Utc), Capacity = 60, MovieId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Screening() { ScreenNumber = 2, StartsAt = DateTime.SpecifyKind(new DateTime(2025, 1, 30, 19, 30, 0), DateTimeKind.Utc), Capacity = 50, MovieId = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Screening() { ScreenNumber = 3, StartsAt = DateTime.SpecifyKind(new DateTime(2025, 1, 30, 19, 30, 0), DateTimeKind.Utc), Capacity = 40, MovieId = 3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    db.Add(new Screening() { ScreenNumber = 1, StartsAt = DateTime.SpecifyKind(new DateTime(2025, 1, 31, 20, 30, 0), DateTimeKind.Utc), Capacity = 50, MovieId = 2, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now });
                    await db.SaveChangesAsync();
                }
                if (!db.Tickets.Any())
                {
                    db.Add(new Ticket() { NumSeats = 3, CustomerId = 1, ScreeningId = 2, });
                    db.Add(new Ticket() { NumSeats = 5, CustomerId = 2, ScreeningId = 1, });
                    db.Add(new Ticket() { NumSeats = 3, CustomerId = 3, ScreeningId = 3, });
                    db.Add(new Ticket() { NumSeats = 2, CustomerId = 4, ScreeningId = 4, });
                    db.Add(new Ticket() { NumSeats = 3, CustomerId = 2, ScreeningId = 3, });
                    db.Add(new Ticket() { NumSeats = 2, CustomerId = 2, ScreeningId = 4, });
                    await db.SaveChangesAsync();
                }


            }
        }
    }
}

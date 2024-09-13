using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                DateTime time = DateTime.UtcNow;
                if (!db.Customers.Any())
                {
                    db.Add(new Customer() { Name = "Nigel", Email = "nigel@email.com", Phone = "+4712345678", CreatedAt = time, UpdatedAt = time });
                    db.Add(new Customer() { Name = "Dave", Email = "dave@email.com", Phone = "+4787654321", CreatedAt = time, UpdatedAt = time });
                    db.Add(new Customer() { Name = "Toni", Email = "toni@email.com", Phone = "+4798765432", CreatedAt = time, UpdatedAt = time });
                    db.SaveChanges();
                }
                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Title = "The Shawshank Redemption", Rating = "R", Description = "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion.", RuntimeMins = 144, CreatedAt = time, UpdatedAt = time });
                    db.Add(new Movie() { Title = "The Godfather", Rating = "R", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", RuntimeMins = 175, CreatedAt = time, UpdatedAt = time });
                    db.Add(new Movie() { Title = "The Dark Knight", Rating = "PG-13", Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.", RuntimeMins = 152, CreatedAt = time, UpdatedAt = time });
                    await db.SaveChangesAsync();

                }
                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { MovieId = 1, ScreenId = 1, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(2), CreatedAt = time, UpdatedAt = time });
                    db.Add(new Screening() { MovieId = 2, ScreenId = 1, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(3), CreatedAt = time, UpdatedAt = time });
                    db.Add(new Screening() { MovieId = 2, ScreenId = 2, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(4), CreatedAt = time, UpdatedAt = time });
                    db.Add(new Screening() { MovieId = 3, ScreenId = 2, Capacity = 100, StartsAt = DateTime.UtcNow.AddDays(5), CreatedAt = time, UpdatedAt = time });
                    await db.SaveChangesAsync();
                }
                if (!db.Tickets.Any())
                {
                    db.Add(new Ticket() { CustomerId = 1, NumSeats = 1, ScreeningId = 1, CreatedAt = time, UpdatedAt = time });
                    db.Add(new Ticket() { CustomerId = 2, NumSeats = 5, ScreeningId = 2, CreatedAt = time, UpdatedAt = time });
                    db.Add(new Ticket() { CustomerId = 3, NumSeats = 2, ScreeningId = 4, CreatedAt = time, UpdatedAt = time });
                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

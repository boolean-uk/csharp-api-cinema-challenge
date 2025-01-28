using api_cinema_challenge.Models;


namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                if (!db.Customers.Any())
                {
                    db.Customers.AddRange(
                        new Customer
                        {
                            Name = "Nigel",
                            Email = "Nigel@boolean.com",
                            Phone = "+1234567890",
                            CreatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                        },
                        new Customer
                        {
                            Name = "Dave",
                            Email = "Dave@boolean.com",
                            Phone = "+1234567890",
                            CreatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                        },
                        new Customer
                        {
                            Name = "Martin",
                            Email = "Martin@experis.com",
                            Phone = "+1234567890",
                            CreatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                        }
                    );
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Movies.AddRange(
                        new Movie
                        {
                            Title = "Inception",
                            Rating = "PG-13",
                            Description = "A thief who steals corporate secrets through dream-sharing technology is tasked with planting an idea into the mind of a CEO.",
                            RuntimeMins = 148,
                            CreatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 0, 0, DateTimeKind.Utc)
                        }, new Movie
                        {
                            Title = "The Matrix",
                            Rating = "R",
                            Description = "A computer hacker learns the true nature of his reality and his role in the war against its controllers.",
                            RuntimeMins = 136,
                            CreatedAt = new DateTime(2025, 1, 1, 12, 5, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 5, 0, DateTimeKind.Utc)
                        }, new Movie
                        {
                            Title = "The Dark Knight",
                            Rating = "PG-13",
                            Description = "When the Joker emerges as Gotham's new criminal mastermind, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            RuntimeMins = 152,
                            CreatedAt = new DateTime(2025, 1, 1, 12, 10, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 10, 0, DateTimeKind.Utc)
                        }, new Movie
                        {
                            Title = "Interstellar",
                            Rating = "PG-13",
                            Description = "A team of explorers travels through a wormhole in space in an attempt to ensure humanity's survival.",
                            RuntimeMins = 169,
                            CreatedAt = new DateTime(2025, 1, 1, 12, 15, 0, DateTimeKind.Utc),
                            UpdatedAt = new DateTime(2025, 1, 1, 12, 15, 0, DateTimeKind.Utc)
                        }
                    );


                    await db.SaveChangesAsync();
                }
                //order data
                if (1 == 1)
                {

                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

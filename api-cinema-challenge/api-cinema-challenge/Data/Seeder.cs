namespace api_cinema_challenge.Data;

public static class Seeder
{
    public static async void SeedCinemaApi(this WebApplication app)
    {
        await using var db = new CinemaContext();
        /*if (!db.Customers.Any())
        {
            await db.SaveChangesAsync();
        }*/
    }
}
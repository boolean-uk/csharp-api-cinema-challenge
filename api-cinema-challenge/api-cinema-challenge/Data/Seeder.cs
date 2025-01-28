using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        public async static void SeedCinemaApi(this WebApplication app)
        {
            using (var db = new DataContext())
            {
                if (!db.Customers.Any())
                {
                    db.Add(new Customer() { Id = 1, Name = "Nigel" });
                    db.Add(new Customer() { Id = 2, Name = "Dave" });
                    db.Add(new Customer() { Id = 3, Name = "Kristoffer" });
                    await db.SaveChangesAsync();
                }
                if (!db.Movies.Any())
                {
                    db.Add(new Movie() { Id = 1, Name = "Cheese & Pineapple", Price = 190m });
                    db.Add(new Movie() { Id = 2, Name = "Vegan Cheese Tastic", Price = 200m });
                    db.Add(new Movie() { Id = 3, Name = "Nduja", Price = 210m });
                    await db.SaveChangesAsync();

                }


                if (!db.Screenings.Any())
                {
                    db.Add(new Screening() { Id = 1, CustomerId = 1, PizzaId = 1 });
                    db.Add(new Screening() { Id = 2, CustomerId = 2, PizzaId = 2 });
                    db.Add(new Screening() { Id = 3, CustomerId = 3, PizzaId = 3 });



                    await db.SaveChangesAsync();
                }
            }
        }
    }
}

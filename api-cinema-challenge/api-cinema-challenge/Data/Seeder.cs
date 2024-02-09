using api_cinema_challenge.Models;


namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
       public static List <Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer { Id = 1, CustomerName = "John Doe", EmailAdress = "john@example.com", PhoneNumber = "1234567890", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new Customer {  Id = 2,CustomerName = "Jane Smith", EmailAdress = "jane@example.com", PhoneNumber = "9876543210", CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            };
            return customers;
        }

        public static List<Screening> GetScreenings()
        {
            List<Screening> screenings = new List<Screening>()
            {
                 new Screening { ScreeningId = 1, ScreenNumber = 1, ScreenCapacity = 100, StartsAt = DateTime.UtcNow.AddHours(1), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, MovieId = 1 },
                    new Screening { ScreeningId = 2, ScreenNumber = 2, ScreenCapacity = 120, StartsAt = DateTime.UtcNow.AddHours(2), CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, MovieId = 2 }
            }; 
            return screenings;
        }

        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
            {
                 new Movie { MovieId = 1, Title = "Movie 1", Rating = "PG", Description = "Description of Movie 1", RuntimeMins = 120, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                 new Movie { MovieId = 2, Title = "Movie 2", Rating = "PG-13", Description = "Description of Movie 2", RuntimeMins = 150, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            };
            return movies;
        }


       

      

    }
}

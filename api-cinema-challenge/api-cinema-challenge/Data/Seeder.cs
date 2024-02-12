using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> customers = new List<Customer>();
        private List<Movie> movies = [];
        private List<Ticket> tickets = [];
        private List<Screening> screenings = [];

        private List<string> firstNames = new List<string> { "Ted", "Lily", "Robin", "Marshall", "Barney" };
        private List<string> lastNames = new List<string> { "Thorpe", "Dunpy", "Pritchett", "Delgado" };
        private List<string> phoneNumbers = new List<string> { "222 25 555", "888 22 999", "909 11 881" };
        private List<string> emails = new List<string> { "@hotmail.com", "@live.com", "@gmail.com", "@experis.com" };

        Random random = new Random();
        public Seeder()
        {

            for (int i = 1; i < 21; i++)
            {
                var firstName = firstNames[random.Next(firstNames.Count())];
                var lastName = lastNames[random.Next(lastNames.Count())];

                customers.Add(
                new Customer
                {
                    Id = i,
                    Name = firstName + " " + lastName,
                    Email = firstName + random.Next(99) + emails[random.Next(emails.Count())],
                    Phone = phoneNumbers[random.Next(phoneNumbers.Count())],
                    CreatedAt = DateTime.UtcNow,
                }
                );
            }

            movies = new List<Movie>
            {

                new Movie { Id = 1, Title = "The Shawshank Redemption", Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", IMDBRating = "9.3", RuntimeMin = 142, CreatedAt = DateTime.UtcNow },
                new Movie { Id = 2, Title = "The Godfather", Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", IMDBRating = "9.2", RuntimeMin = 175, CreatedAt = DateTime.UtcNow },
                new Movie { Id = 3, Title = "The Dark Knight", Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", IMDBRating = "9.0", RuntimeMin = 152, CreatedAt = DateTime.UtcNow },
                new Movie { Id = 4, Title = "Pulp Fiction", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", IMDBRating = "8.9", RuntimeMin = 154, CreatedAt = DateTime.UtcNow },
                new Movie { Id = 5, Title = "Inception", Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", IMDBRating = "8.8", RuntimeMin = 148, CreatedAt = DateTime.UtcNow }
            };

            screenings = new List<Screening>
            {
                new Screening { Id = 3, Capacity = 200, Number = 4, StartsAt = DateTime.UtcNow, CreatedAt = DateTime.UtcNow, MovieId = 2 }
            };

            tickets = new List<Ticket>
            {
                new Ticket { Id = 1, NumberOfSeats = 1, CustomerId = 3, ScreeningId = 3 },
                new Ticket { Id = 2, NumberOfSeats = 3, CustomerId = 4, ScreeningId = 3 }
            };
        }
        public List<Customer> Customers { get { return customers; } }
        public List<Movie> Movies { get { return movies; } }
        public List<Ticket> Tickets { get { return tickets; } }
        


    }
}

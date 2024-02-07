using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Models.TicketModels;
using Bogus;


namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        private Random _random = new Random();

        public Seeder()
        {
            

            // Seed customers
            string[] firstNames = { "John", "Jane", "David", "Sarah", "Michael", "Emily", "Matthew", "Jennifer", "Daniel", "Jessica" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson" };

            for (int i = 1; i <= 100; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = $"{firstNames[new Random().Next(firstNames.Length)]} {lastNames[new Random().Next(lastNames.Length)]}";
                customer.Phone = GenerateRandomPhone();
                customer.Email = GenerateRandomEmail(customer.Name);
                _customers.Add(customer);
            }

            // Seed movies
            string[] ratings = { "G", "PG", "PG-13", "R" };

            for (int i = 1; i <= 20; i++)
            {
                Movie movie = new Movie();
                movie.Id = i;
                movie.Title = GenerateRandomTitle();
                movie.Description = GenerateRandomDescription();
                movie.Rating = ratings[new Random().Next(ratings.Length)];
                movie.Runtime = $"{new Random().Next(60, 180)} minutes";
                _movies.Add(movie);
            }

            // Seed screenings
            for (int i = 1; i <= 60; i++)
            {
                Screening screening = new Screening();
                screening.Id = i;
                screening.StartsAt = DateTime.UtcNow.AddDays(_random.Next(1, 7)).AddHours(_random.Next(10, 20));
                screening.ScreenNumber = _random.Next(1, 5);
                screening.Capacity = 50; // Adjust capacity as needed

                // Assign a random movie to the screening
                int randomMovieId = _random.Next(1, _movies.Count + 1);
                screening.MovieId = randomMovieId;

                _screenings.Add(screening);
            }

            // Seed tickets
            for (int i = 1; i <= 200; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = i;
                ticket.NumSeats = new Random().Next(1, 5);

                // Assign a random screening to the ticket
                int randomScreeningId = new Random().Next(1, _screenings.Count + 1);
                ticket.ScreeningId = randomScreeningId;

                // Assign a random customer to the ticket
                int randomCustomerId = new Random().Next(1, _customers.Count + 1);
                ticket.CustomerId = randomCustomerId;

                _tickets.Add(ticket);
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }

        private string GenerateRandomTitle()
        {
            var titleFaker = new Faker("en");
            return titleFaker.Lorem.Sentence(wordCount: _random.Next(1, 4));
        }

        private string GenerateRandomDescription()
        {
            var descriptionFaker = new Faker("en");
            return descriptionFaker.Lorem.Paragraphs(_random.Next(1, 3));
        }

        private string GenerateRandomPhone()
        {
            var phoneFaker = new Faker("en");
            return phoneFaker.Phone.PhoneNumber();
        }

        private string GenerateRandomEmail(string name)
        {
            var emailFaker = new Faker("en");
            return emailFaker.Internet.Email(name);
        }
    }
}

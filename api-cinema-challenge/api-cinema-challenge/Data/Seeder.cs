using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Models.TicketModels;
using Bogus;


namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = [];
        private List<Movie> _movies = [];
        private List<Screening> _screenings = [];
        private List<Ticket> _tickets = [];

        private Random _random = new ();

        public Seeder()
        {
            // Seed customers
            string[] firstNames = ["John", "Jane", "David", "Sarah", "Michael", "Emily", "Matthew", "Jennifer", "Daniel", "Jessica"];
            string[] lastNames = ["Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson"];

            for (int i = 1; i <= 100; i++)
            {
                string name = $"{firstNames[new Random().Next(firstNames.Length)]} {lastNames[new Random().Next(lastNames.Length)]}";
                Customer customer = new()
                {
                    Id = i,
                    Name = name,
                    Phone = GenerateRandomPhone(),
                    Email = GenerateRandomEmail(name)
                };

                _customers.Add(customer);
            }

            // Seed movies
            string[] ratings = ["G", "PG", "PG-13", "R"];

            for (int i = 1; i <= 20; i++)
            {
                Movie movie = new ()
                {
                    Id = i,
                    Title = GenerateRandomTitle(),
                    Description = GenerateRandomDescription(),
                    Rating = ratings[new Random().Next(ratings.Length)],
                    Runtime = $"{new Random().Next(60, 180)} minutes"
                };

                _movies.Add(movie);
            }

            // Seed screenings
            for (int i = 1; i <= 60; i++)
            {
                int randomMovieId = _random.Next(1, _movies.Count + 1);
                Screening screening = new ()
                {
                    Id = i,
                    StartsAt = DateTime.UtcNow.AddDays(_random.Next(1, 7)).AddHours(_random.Next(10, 20)),
                    ScreenNumber = _random.Next(1, 5),
                    Capacity = 50,
                    MovieId = randomMovieId
                };

                _screenings.Add(screening);
            }

            // Seed tickets
            for (int i = 1; i <= 200; i++)
            {
                Ticket ticket = new ()
                {
                    Id = i,
                    NumSeats = new Random().Next(1, 5),
                    ScreeningId = new Random().Next(1, _screenings.Count + 1),
                    CustomerId = new Random().Next(1, _customers.Count + 1)
                };


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

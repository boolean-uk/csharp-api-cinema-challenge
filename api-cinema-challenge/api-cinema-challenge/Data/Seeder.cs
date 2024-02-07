using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<string> _firstNames = new List<string>()
        {
            "Bobby",
            "Georgy",
            "Krissy",
            "Dobby",
            "Robby",
            "Jensy",
            "Henricky",
            "Azizy",
            "Mahmouyd",
            "Chady"
        };

        private List<string> _lastNames = new List<string>()
        {
            "Bob",
            "George",
            "Kris",
            "Dob",
            "Rob",
            "Jens",
            "Henrick",
            "Aziz",
            "Mahmoud",
            "Chad"
        };

        private List<string> _firstWord = new List<string>()
        {
            "The",
            "Two",
            "A lot of",
            "One",
            "Hundred",
            "Thousand"
        };

        private List<string> _secondWord = new List<string>()
        {
            "Humongous",
            "Crazy",
            "Disurbing",
            "Orange",
            "Disgusting",
            "Crazy",
            "Foul",
            "Exciting"
        };

        private List<string> _thirdWord = new List<string>()
        {
            "Cats",
            "Dogs",
            "Humans",
            "Clowns",
            "Babies",
            "Mothers",
            "Fathers",
            "Rats"
        };

        private List<string> _ratings = new List<string>()
        {
            "PG",
            "PG-13",
            "R-Rated",
            "NC-17"
        };

        private List<string> _descriptions = new List<string>()
        {
            "This one is very scary",
            "This one is a funny one",
            "This one is not very good",
            "Very exciting movie",
            "Boring movie",
            "This is the best movie ever made"
        };

        private List<int> _runtimes = new List<int>()
        {
            90,
            100,
            110,
            120,
            130,
            140,
            154,
            214,
            95,
            103
        };

        private List<int> _capacities = new List<int>()
        {
            10,
            30,
            50,
            60,
            70,
            80,
            90,
            100
        };

        private List<Movie> _movies = new List<Movie>();
        private List<Customer> _customers = new List<Customer>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {
            Random movieRandom = new Random();
            Random customerRandom = new Random();
            Random screeningRandom = new Random();
            Random ticketRandom = new Random();

            for (int i = 1; i < 100; i++)
            {
                Movie movie = new Movie();
                movie.Id = i;
                string firstWord = _firstWord[movieRandom.Next(_firstWord.Count)];
                string secondWord = _secondWord[movieRandom.Next(_secondWord.Count)];
                string thirdWord = _thirdWord[movieRandom.Next(_thirdWord.Count)];
                movie.Title = firstWord + " " + secondWord + " " + thirdWord;
                movie.Rating = _ratings[movieRandom.Next(_ratings.Count)];
                movie.Description = _descriptions[movieRandom.Next(_descriptions.Count)];
                movie.Runtime = _runtimes[movieRandom.Next(_runtimes.Count)];
                _movies.Add(movie);
            }

            for (int i = 1; i < 100; i ++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                string firstName = _firstNames[customerRandom.Next(_firstNames.Count)];
                string lastName = _lastNames[customerRandom.Next(_lastNames.Count)];
                customer.Name = firstName + " " + lastName;
                customer.Email = firstName + lastName + "@email.com";
                customer.PhoneNumber = customerRandom.Next(10000000, 99999999).ToString();
                _customers.Add(customer);
            }

            for (int i = 1; i < 100; i++)
            {
                Screening screening = new Screening();
                screening.Id = i;
                screening.ScreenNumber = screeningRandom.Next(1, 10);
                screening.MovieId = screeningRandom.Next(1, 99);
                int capacity = _capacities[screeningRandom.Next(_capacities.Count)];
                screening.Capacity = capacity;
                screening.AvailableSeats = capacity;
                screening.StartsAt = DateTime.UtcNow.AddDays(screeningRandom.Next(1, 10));
                _screenings.Add(screening);
            }

            for (int i = 1; i < 100; i++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = i;
                ticket.CustomerId = ticketRandom.Next(1, 99);
                ticket.ScreeningId = ticketRandom.Next(1, 99);
                ticket.NumberOfSeats = ticketRandom.Next(1, 5);
                Screening screening = Screenings.First(s => s.Id == ticket.ScreeningId);
                if (screening.AvailableSeats - ticket.NumberOfSeats < 0)
                {
                    continue;
                }
                _tickets.Add(ticket);
                screening.AvailableSeats -= ticket.NumberOfSeats;
            }
        }
        public List<Movie> Movies { get => _movies; }
        public List<Customer> Customers { get => _customers; }
        public List<Screening> Screenings { get => _screenings; }
        public List<Ticket> Tickets { get => _tickets; }
    }
}

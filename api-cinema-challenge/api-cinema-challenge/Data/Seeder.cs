using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<string> _firstnames = new List<string>()
        {
            "Patrick",
            "Sandy",
            "Princess",
            "Spongebob",
            "Knuckles",
            "Donkey",
            "Luigi",
            "Sonic",
            "Mario",
            "Yoshi"
        };
        private List<string> _lastnames = new List<string>()
        {
            "Star",
            "Cheeks",
            "Peach",
            "Daisy",
            "the Echidna",
            "Kong",
            "Mario",
            "the Dinosaur",
            "the Hedgehog",
            "Squarepants"
        };
        private List<string> _movieFirst = new List<string>()
        {
            "",
            "Beauty & the ",
            "The ",
            "Elf on the ",
            "Crazy ",
            "Saving the ",
            "Lady & the ",
            "Dystopian "
        };

        private List<string> _movieSecond = new List<string>()
        {
            "Beast",
            "Boys",
            "Shelf",
            "Bees",
            "Trumpet",
            "Ice Age",
            "Frog"
        };

        private List<string> _movieRatings = new List<string>()
        {
            "PG-3",
            "PG-7",
            "PG-13",
            "PG-18"
        };

        private List<string> _movieDescriptions = new List<string>()
        {
            "A sad story filled with drama and anticipation",
            "The universal bestselling love story, now adapted into a movie",
            "A horrible chill goes down your spine, are you ready to watch the horror movie of the century?",
            "Hold on to your popcorn, cause this movie is filled with incredible action scenes that will leave you speechless",
            "Got a date around the corner? Grab your significant other and enjoy a sensational and emotional story unfold like never before",
            "There has been a murder in town, can they solve the mystery before it is too late?",
            "This movie will rock your socks with comedy beyond your wildest expectations!"
        };

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {
            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random screeningRandom = new Random();
            Random ticketRandom = new Random();

            for (int x = 1; x < 11; x++)
            {
                Customer customer = new Customer();
                customer.Id = x;
                customer.Name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                customer.Email = $"{customer.Name[0]}{customer.Name[customer.Name.Count() - 1]}@snailmail.com";
                customer.Phone = $"+46{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}{customerRandom.Next(10)}";
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = customer.CreatedAt;
                _customers.Add(customer);
            }

            for (int y = 1; y < 11; y++)
            {
                Movie movie = new Movie();
                movie.Id = y;
                movie.Title = $"{_movieFirst[movieRandom.Next(_movieFirst.Count)]}{_movieSecond[movieRandom.Next(_movieSecond.Count)]}";
                movie.Rating = $"{_movieRatings[movieRandom.Next(_movieRatings.Count)]}";
                movie.Description = $"{_movieDescriptions[movieRandom.Next(_movieDescriptions.Count)]}";
                movie.RuntimeMins = movieRandom.Next(60, 240); //1-4 hours
                movie.CreatedAt = DateTime.UtcNow;
                movie.UpdatedAt = movie.CreatedAt;
                _movies.Add(movie);
            }

            for (int z = 1; z < 21; z++)
            {
                Screening screening = new Screening();
                screening.Id = z;
                screening.ScreenNumber = screeningRandom.Next(1, 11); //1-10
                screening.Capacity = 30 + (screening.ScreenNumber * 2);
                screening.MovieId = _movies[screeningRandom.Next(_movies.Count)].Id;
                screening.StartsAt = DateTime.Now.AddDays(movieRandom.Next(0, 3)).AddHours(movieRandom.Next(0, 24)).AddMinutes(movieRandom.Next(0, 60));
                screening.CreatedAt = DateTime.UtcNow;
                screening.UpdatedAt = screening.CreatedAt;

                //Round the starting time to the nearest 15 min mark.
                long ticksPer15Mins = TimeSpan.FromMinutes(15).Ticks;
                long startTimeWithRoundedTicks = ((screening.StartsAt.Ticks + (ticksPer15Mins / 2)) / ticksPer15Mins) * ticksPer15Mins; //((DateTime + (15minTicks/2)) / 15minTicks) * 15minTicks
                screening.StartsAt = new DateTime(startTimeWithRoundedTicks).ToUniversalTime();

                _screenings.Add(screening);
            }

            for(int t = 1; t < 16; t++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = t;
                ticket.NumSeats = ticketRandom.Next(1, 6);
                ticket.CustomerId = _customers[ticketRandom.Next(_customers.Count)].Id;
                ticket.ScreeningId = _screenings[ticketRandom.Next(_screenings.Count)].Id;
                ticket.CreatedAt = DateTime.UtcNow;
                ticket.UpdatedAt = ticket.CreatedAt;
                _tickets.Add(ticket);
            }
        }

        public List<Customer> customers { get { return _customers; } }
        public List<Movie> movies { get { return _movies; } }
        public List<Screening> screenings { get { return _screenings; } }
        public List<Ticket> tickets { get { return _tickets; } }
    }
}

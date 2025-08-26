using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
   
    {
            private List<string> _firstnames = new List<string>()
        {
            "Audrey",
            "Donald",
            "Elvis",
            "Barack",
            "Oprah",
            "Jimi",
            "Mick",
            "Kate",
            "Charles",
            "Kate"
        };
            private List<string> _lastnames = new List<string>()
        {
            "Hepburn",
            "Trump",
            "Presley",
            "Obama",
            "Winfrey",
            "Hendrix",
            "Jagger",
            "Winslet",
            "Windsor",
            "Middleton"

        };
            private List<string> _domain = new List<string>()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };
            private List<string> _firstword = new List<string>()
        {
            "The",
            "Two",
            "Several",
            "Fifteen",
            "A bunch of",
            "An army of",
            "A herd of"


        };
            private List<string> _secondword = new List<string>()
        {
            "Orange",
            "Purple",
            "Large",
            "Microscopic",
            "Green",
            "Transparent",
            "Rose Smelling",
            "Bitter"
        };
            private List<string> _thirdword = new List<string>()
        {
            "Buildings",
            "Cars",
            "Planets",
            "Houses",
            "Flowers",
            "Leopards"
        };
        private List<string> _ratings = new List<string>()
        {
            "All",
            "years 6+",
            "years 11+",
            "years 16+",
            "years 18+"
        };
        private List<DateTime> _startAt = new List<DateTime>()
        {
            DateTime.Parse("2025-01-05 09:15:00").ToUniversalTime(),
            DateTime.Parse("2025-01-12 14:30:00").ToUniversalTime(),
            DateTime.Parse("2025-02-03T08:45:00").ToUniversalTime(),
            DateTime.Parse("2025-02-21T19:00:00").ToUniversalTime(),
            DateTime.Parse("2025-03-10T07:20:00").ToUniversalTime(),
            DateTime.Parse("2025-03-25T16:50:00").ToUniversalTime(),
            DateTime.Parse("2025-04-02T12:05:00").ToUniversalTime(),
            DateTime.Parse("2025-04-18T21:30:00").ToUniversalTime(),
            DateTime.Parse("2025-05-01T10:10:00").ToUniversalTime(),
            DateTime.Parse("2025-05-14T18:45:00").ToUniversalTime(),
            DateTime.Parse("2025-06-07T06:25:00").ToUniversalTime(),
            DateTime.Parse("2025-06-22T15:40:00").ToUniversalTime(),
            DateTime.Parse("2025-07-03T11:55:00").ToUniversalTime(),
            DateTime.Parse("2025-07-19T20:15:00").ToUniversalTime(),
            DateTime.Parse("2025-08-01T13:30:00").ToUniversalTime()
        };



        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {

            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random ticketRandom = new Random();
            Random screeningRandom = new Random();



            for (int x = 1; x < 50; x++)
            {
                Customer customer = new Customer();
                customer.Id = x;
                customer.Name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                customer.Email = $"{customer.Name}@{_domain[customerRandom.Next(_domain.Count)]}".ToLower();
                customer.Phone = ""+movieRandom.Next(10000000, 99999999);
                _customers.Add(customer);
            }


            for (int y = 1; y < 5; y++)
            {
                Movie movie = new Movie();
                movie.Id = y;
                movie.Title = $"{_firstword[movieRandom.Next(_firstword.Count)]} {_secondword[movieRandom.Next(_secondword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}";
                movie.Rating = _ratings[movieRandom.Next(_ratings.Count)];
                movie.Description = "Very funny";
                movie.RunTimeMins = movieRandom.Next(70,150);
                _movies.Add(movie);
            }

                for (int z = 1; z < 20; z++)
            {
                Screening screening = new Screening();
                screening.Id = z;
                screening.ScreenNumber = screeningRandom.Next(5);
                screening.Capacity = screeningRandom.Next(25, 100);
                screening.StartsAt = _startAt[screeningRandom.Next(_startAt.Count)];
                screening.MovieId = _movies[movieRandom.Next(_movies.Count)].Id;
                _screenings.Add(screening);
            }

            for (int a = 1; a < 200; a++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = a;
                ticket.ScreeningId = _screenings[screeningRandom.Next(_screenings.Count)].Id;
                ticket.CustomerId = _customers[screeningRandom.Next(_customers.Count)].Id;
                ticket.numSeats = ticketRandom.Next(1, 3);
                _tickets.Add(ticket);
            }


        }
        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Ticket> tickets { get { return _tickets; } }
        public List<Screening> Screenings { get { return _screenings; } }
        }
    }


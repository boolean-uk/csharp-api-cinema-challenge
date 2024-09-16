using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Screening;
using api_cinema_challenge.Models.Ticket;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;
using System.Globalization;

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
            "Absolute Masterpiece",
            "Highly Praised",
            "Mediocre",
            "Disappointing",
            "Bottom of the Barrel, Yuck!"

        };

        private List<int> _capacities = new List<int>()
        {
            20,
            40,
            50,
            100,
            75,
        };
        private List<int> _runtimes = new List<int>()
        {
            70,
            84,
            128,
            150,
            173,
        };

        List<string> _dates = new List<string>
        {
            "2024-09-12 13:45:00 UTC",
            "2024-09-12 14:00:00 UTC",
            "2024-09-12 14:15:00 UTC",
            "2024-09-12 14:30:00 UTC",
            "2024-09-12 14:45:00 UTC",
            "2024-09-12 15:00:00 UTC",
            "2024-09-12 15:15:00 UTC",
            "2024-09-12 15:30:00 UTC",
            "2024-09-12 15:45:00 UTC",
            "2024-09-12 16:00:00 UTC"
        };

        private List<Customer> _customers = new List<Customer>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Movie> _movies = new List<Movie>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {

            Random customerRandom = new Random();
            Random screenRandom = new Random();
            Random movieRandom = new Random();
            Random ticketRandom = new Random();

            for (int x = 1; x < 30; x++)
            {
                Customer customer = new Customer();
                customer.id = x;
                customer.name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                customer.email = customer.name.Replace(" ", ".") + "@email.com";
                customer.phone = "123 456 78 90";
                _customers.Add(customer);
            }

            for (int x = 1; x < 20; x++)
            {
                Screening screening = new Screening();
                screening.Id = x;
                screening.ScreenNumber = x;
                screening.Capacity = _capacities[screenRandom.Next(_capacities.Count)];
                string date = _dates[screenRandom.Next(_dates.Count)];
                string format = "yyyy-MM-dd HH:mm:ss 'UTC'";
                screening.StartsAt = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal);
                _screenings.Add(screening);
            }

            for (int x = 1; x < 6; x++)
            {
                Movie movie = new Movie();
                movie.Id = x;
                movie.Title = $"{_firstword[movieRandom.Next(_firstword.Count)]} {_secondword[movieRandom.Next(_secondword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}";
                movie.Description = "Movie about cool dudes shooting cool guns while saying cool one liners";
                movie.rating = _ratings[movieRandom.Next(_ratings.Count)];
                movie.runtimeMins = _runtimes[movieRandom.Next(_runtimes.Count)];
                _movies.Add(movie);
            }
            for (int x = 1; x < 120; x++)
            {
                Ticket ticket = new Ticket();
                ticket.Id = _movies[ticketRandom.Next(_movies.Count)].Id;

                //get max of movie
                //get all tickets that have matching id
                //get the ticket with the lowest seat num
                //assign that -1 to new ticket

                if (_tickets.Where(x => x.Id == ticket.Id).Count() == 0)
                {
                    ticket.numSeats = _screenings.FirstOrDefault(x => x.Id == ticket.Id).Capacity - 1;
                }
                else if (_tickets.Where(x => x.Id == ticket.Id).Count() != 0 && _tickets.Where(x => x.Id == ticket.Id).Min(x => x.numSeats) - 1 >= 0)
                {
                    ticket.numSeats = _tickets.Where(x => x.Id == ticket.Id).Min(x => x.numSeats) - 1;
                }

                //ensure no duplicate composite keys exist
                List<Ticket> dupesList = new List<Ticket>(_tickets);
                dupesList.Add(ticket);
                var dupes = dupesList.GroupBy(x => new {x.Id, x.numSeats}).Where(x => x.Skip(1).Any()).Any();

                if (!dupes)
                {
                    _tickets.Add(ticket);
                }
            }













        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Ticket> Tickets { get { return _tickets; } }

    }
}

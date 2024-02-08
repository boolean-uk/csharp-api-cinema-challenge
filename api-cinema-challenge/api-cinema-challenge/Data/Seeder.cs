using api_cinema_challenge.Models.DatabaseModels;
using System.Numerics;

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
            "gmail.com",
            "outlook.com",
            "hotmail.com",
            "asl.com",
            "yahoo.com",
            "msn.com",

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
            "G – General Audiences",
            "PG – Parental Guidance Suggested",
            "PPG-13 – Parents Strongly Cautioned",
            "R – Restricted",
            "NC-17 – Adults Only"
        };
        private List<string> _descriptions= new List<string>()
        {
            "Fantasy",
            "Adventure",
            "Western",
            "Historic",
            "Cyberpunk",
            "Pirate",
            "Dwarf",
            "Sci-Fi",
            "Space",
            "Comedy",
            "Romance"
        };

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();

        public Seeder() 
        {
            int amount = 20;

            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random screeningRandom = new Random();

            for(int x = 1; x < amount; x++)
            {
                Customer customer = new Customer();
                customer.Id = x;
                customer.Name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                customer.Email = $"{customer.Name}@{_domain[customerRandom.Next(_domain.Count)]}";
                customer.Phone = $"{customerRandom.Next(10000000, 99999999)}";
                customer.CreatedAt = new DateTime(customerRandom.Next(2000, 2024), customerRandom.Next(1, 12), customerRandom.Next(1, 28)).ToUniversalTime();
                customer.UpdateddAt = customer.CreatedAt;
                _customers.Add(customer);
            }
            for (int y = 1; y < amount; y++)
            {
                Movie movie = new Movie();
                movie.Id = y;
                movie.Title = $"{_firstword[movieRandom.Next(_firstword.Count)]} {_secondword[movieRandom.Next(_secondword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}";
                movie.Rating = $"{_ratings[movieRandom.Next(_ratings.Count)]}";
                movie.Description = $"{_descriptions[movieRandom.Next(_descriptions.Count)]} {_descriptions[movieRandom.Next(_descriptions.Count)]}";
                movie.Runtime = movieRandom.Next(60, 240);
                movie.CreatedAt = new DateTime(movieRandom.Next(2000, 2024), movieRandom.Next(1, 12), movieRandom.Next(1, 28)).ToUniversalTime();
                movie.UpdateddAt = movie.CreatedAt;
                _movies.Add(movie);
            }
            for (int z = 1; z < amount; z++)
            {
                Screening screening = new Screening();
                screening.Id = z;
                screening.MovieId = _movies[screeningRandom.Next(_movies.Count)].Id;
                screening.ScreenNumber = screeningRandom.Next(1,6);
                screening.Capacity = screening.ScreenNumber*10;
                screening.CreatedAt = new DateTime(screeningRandom.Next(2000, 2024), screeningRandom.Next(1, 12), screeningRandom.Next(1, 28)).ToUniversalTime();
                screening.StartsAt = screening.CreatedAt;
                screening.UpdateddAt = screening.CreatedAt;
                _screenings.Add(screening);
            }
        }
        public List<Customer> Customer { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }
    }
}

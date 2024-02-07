using System;
using System.Collections.Generic;
using api_cinema_challenge.Models;

namespace exercise.webapi.Data
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

        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();

        public Seeder()
        {
            Random customerRandom = new Random();
            Random movieRandom = new Random();
            Random screeningRandom = new Random();

            // Seed Customers
            for (int i = 1; i <= 250; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                customer.Email = $"{customer.Name.Replace(" ", ".")}@{_domain[customerRandom.Next(_domain.Count)]}".ToLower();
                customer.Phone = $"+{customerRandom.Next(100000000, 999999999)}";
                _customers.Add(customer);
            }

            // Seed Movies
            for (int j = 1; j <= 20; j++)
            {
                Movie movie = new Movie();
                movie.Id = j;
                movie.Title = $"{GenerateRandomString()}";
                movie.Rating = "PG";
                movie.Description = "Description of the movie.";
                movie.Runtime = movieRandom.Next(90, 180);
                _movies.Add(movie);
            }

            // Seed Screenings
            for (int k = 1; k <= 5; k++)
            {
                Screening screening = new Screening();
                screening.Id = k;
                screening.ScreanNumber = screeningRandom.Next(1, 10);
                screening.Capacity = screeningRandom.Next(50, 300);
                screening.MovieId = _movies[movieRandom.Next(_movies.Count)].Id;
                screening.StartsAt = DateTime.UtcNow.AddDays(screeningRandom.Next(1, 30));
                _screenings.Add(screening);
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }

        private string GenerateRandomString()
        {
            string[] firstWord = { "The", "Two", "Several", "Fifteen", "A bunch of", "An army of", "A herd of" };
            string[] secondWord = { "Orange", "Purple", "Large", "Microscopic", "Green", "Transparent", "Rose Smelling", "Bitter" };
            string[] thirdWord = { "Buildings", "Cars", "Planets", "Houses", "Flowers", "Leopards" };

            Random random = new Random();
            return $"{firstWord[random.Next(firstWord.Length)]} {secondWord[random.Next(secondWord.Length)]} {thirdWord[random.Next(thirdWord.Length)]}";
        }
    }
}

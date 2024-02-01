using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {

        private List<Movie> _movies = new List<Movie>();
        private List<Customer> _customers = new List<Customer>();
        private List<Screening> _screenings = new List<Screening>();


        private List<string> _movieTitles = new List<string>()
        {
            "2001 Space Odyssey",
            "Amelie",
            "One Flew Over The Cuckoo's Nest",
            "Alien - Prometheus",
            "Fantastic Mr. Fox",
            "Fight Club",
            "American Psycho",
            "Clockwork Orange",
            "Let The Right One In",
            "Interview With The Vampire",
            "Frozen",
            "Finding Nemo"
        };

        private List<string> _movieRatings = new List<string>()
        {
            "PG-13",
            "NC-17",
            "PG",
            "R",
            "G"
        };

        private List<string> _movieDescriptions = new List<string>()
        {
            "The greatest movie ever made.",
            "Watching this was the worst experience of my life!",
            "It was ok, critics are indifferent.",
            "This is a cult classic.",
            "Suitable for all ages."
        };

        private List<string> _names = new List<string>()
        {
            "Audrey Hill",
            "Donald Duck",
            "Elvis Presley",
            "Barack Obama",
            "Oprah Winfrey",
            "Jimi Hendrix",
            "Mick Smith",
            "Kate Johnson",
            "Charles Windsor",
            "Kate Middleton"
        };

        private List<string> _emails = new List<string>()
        {
            "audreyhill@gmail.com",
            "DonaldDuck@gmail.com",
            "ElvisPresley@gmail.com",
            "Barack.Obama@gmail.com",
            "OprahWinfrey@gmail.com",
            "JimiHendrix@gmail.com",
            "MickSmith@gmail.com",
            "Kate.Johnson@gmail.com",
            "Charles.Windsor@gmail.com",
            "Kate.Middleton@gmail.com"
        };

        private List<string> _numbers = new List<string>()
        {
            "(843) 200-0198",
            "(496) 262-1642",
            "(200) 933-1067",
            "(853) 847-7386",
            "(609) 360-3328",
            "(868) 557-0840",
            "(935) 686-0024",
            "(541) 550-5967",
            "(704) 587-4532",
            "(294) 896-8215",
            "(445) 850-8947",
            "(376) 294-9205"
        };

        public Seeder() 
        {

            Random movieRandom = new Random();
            Random customerRandom = new Random();
            Random screeningRandom = new Random();
            Random rnd = new Random();

            for (int x = 1; x < 5; x++)
            {
                Movie movie = new Movie();
                movie.Id = x;
                movie.Title = _movieTitles[x];
                movie.Rating = _movieRatings[rnd.Next(_movieRatings.Count)];
                movie.Description = _movieDescriptions[rnd.Next(_movieDescriptions.Count)];
                movie.RuntimeMins = rnd.Next(30, 180);
                movie.CreatedAt = DateTime.Now.ToUniversalTime();
                movie.UpdatedAt = DateTime.Now.ToUniversalTime();
                _movies.Add(movie);
            }

            for (int x = 1; x < 5; x++)
            {

                Customer c = new Customer();
                c.Id = x;
                c.Name = _names[x];
                c.Email = _emails[x];
                c.Phone = _numbers[x];
                c.CreatedAt = DateTime.Now.ToUniversalTime();
                c.UpdatedAt = DateTime.Now.ToUniversalTime();
                _customers.Add(c);
            }

            for (int x = 1; x < 5; x++)
            {

                Screening s = new Screening();
                s.Id = x;
                s.ScreenNumber = rnd.Next(1, 51);
                s.Capacity = rnd.Next(30, 61);
                s.MovieId = _movies[movieRandom.Next(_movies.Count)].Id;
                s.StartsAt = DateTime.Now.ToUniversalTime();
                s.CreatedAt = DateTime.Now.ToUniversalTime();
                s.UpdatedAt = DateTime.Now.ToUniversalTime();
                _screenings.Add(s);
            }

        }

        public List<Movie> Movies { get {  return _movies; } }

        public List<Customer> Customers { get { return _customers; } }


        public List<Screening> Screenings { get { return _screenings; } }

    }
}

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


        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>(); 
        private List<Screening> _screenings = new List<Screening>();


            public Seeder()
            {

                Random customerRandom = new Random();
                Random movieRandom = new Random();

                for (int y = 1; y < 11; y++)
                {
                    Customer cus = new Customer();
                    cus.Id = y;
                    cus.Name = $"{_firstnames[customerRandom.Next(_firstnames.Count)]} {_lastnames[customerRandom.Next(_lastnames.Count)]}";
                    cus.TimeCreated = DateTime.UtcNow;
                    cus.TimeUpdated = cus.TimeCreated;
                    cus.Email = $"{cus.Name}@{_domain[customerRandom.Next(_domain.Count)]}";
                    cus.Phone = $"{customerRandom.Next(10000000, 99999999)}";

                    _customers.Add(cus);
                }

                for (int x = 1; x < 11; x++)
                {
                    Movie mov = new Movie();
                    mov.Id = x;
                    mov.Title = $"{_firstword[movieRandom.Next(_firstword.Count)]} {_thirdword[movieRandom.Next(_thirdword.Count)]}";
                    mov.Description = $"A movie about {_secondword[movieRandom.Next(_secondword.Count)]}";
                    mov.Rating = $"{customerRandom.Next(0, 10)}/10";
                    mov.RuntimeMins = customerRandom.Next(40, 450);
                    mov.TimeCreated = DateTime.UtcNow;
                    mov.TimeUpdated = mov.TimeCreated;

                    _movies.Add(mov);
                }


            }
            public List<Customer> Customers{ get { return _customers; } }
            public List<Movie> Movies { get { return _movies; } }
            public List<Screening> Screenings { get { return _screenings; } }
        }
}


using api_cinema_challenge.Models;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Numerics;
using System.Security.Principal;
using System.Threading;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();

        private DateTime RandomizeDate()
        {
            Random random = new Random();

            DateTime startDate = new DateTime(2024, 10, 1); 
            DateTime endDate = new DateTime(2025, 5, 1);   

            TimeSpan range = endDate - startDate;
            int randomDays = random.Next(0, (int)range.TotalDays);

            DateTime randomDate = startDate.AddDays(randomDays);

            randomDate = randomDate.AddHours(random.Next(0, 24));
            randomDate = randomDate.AddMinutes(random.Next(0, 60));
            randomDate = randomDate.AddSeconds(random.Next(0, 60));

            return randomDate.ToUniversalTime();
        }

        private List<string> _firstNames = new List<string>()
        {
            "Felix",
            "Donald",
            "Elvis",
            "Barack",
            "Oprah",
            "Adam",
            "Mickey",
            "Kate",
            "Charles",
            "Arnold",
            "Ragnar",
            "Neo"
        };

        private List<string> _lastNames = new List<string>()
        {
            "Mathiasson",
            "Duck",
            "Presley",
            "Obama",
            "Winfrey",
            "Sandler",
            "Mouse",
            "Winslow",
            "Xavier",
            "Schwarzenegger",
            "Lothbrok",
            "Andersson"
        };

        private List<string> emails = new List<string>()
        {
            "john.wick@hollywoodmail.com",
            "r.stone@actionstar.net",
            "stallone.sylvester@moviefan.com",
            "v.diesel@stuntman.com",
            "arnold@cybermail.com",
            "j.bourne@spyfilms.org",
            "bruce.willis@explosions.net",
            "n.cage@thrillride.com",
            "l.neeson@hollywoodhero.com",
            "the.rock@adventurezone.net"

        };

        private List<string> _phoneNumbers = new List<string>()
        {
            "(555) 123-7890",
            "(555) 987-6543",
            "(555) 246-8102",
            "(555) 369-1470",
            "(555) 482-9357",
            "(555) 678-9123",
            "(555) 314-1592",
            "(555) 753-9514",
            "(555) 806-4213",
            "(555) 467-8921"
        };

        private List<string> _movieOptions = new List<string>()
        {
            "The Terminator",
            "Predator",
            "Commando",
            "Total Recall",
            "The Escape Plan",
            "Rambo: First Blood Part II",
            "Rocky IV",
            "Cobra",
            "Demolition Man",
            "Cliffhanger"
        };

        private List<string> _movieDescriptions = new List<string>()
        {
            "Cyborg assassin hunts future savior.",
            "Commandos hunted by alien warrior.",
            "Ex-soldier fights to rescue daughter.",
            "Man questions reality and identity.",
            "Prison break with unlikely alliance.",
            "Soldier returns to rescue POWs.",
            "Boxer fights Soviet powerhouse.",
            "Cop battles violent crime cult.",
            "Frozen cop versus unfrozen criminal.",
            "Rescuer fights criminals on mountains."

        };

        private List<int> _runTimes = new List<int>()
        {
            107,
            107,
            90 ,
            113,
            115,
            96 ,
            91 ,
            87 ,
            115,
            113
        };
 

        public Seeder()
        {
            Random customerRandom = new Random();
            for (int i = 1; i < 11; i++)
            {
                string name = 
                    _firstNames[customerRandom.Next(_firstNames.Count)] + " " +
                    _lastNames[customerRandom.Next(_lastNames.Count)];
                Customer customer = new Customer(name, emails[i - 1], _phoneNumbers[i - 1]);
                customer.Id = i;

                _customers.Add(customer);
            }

            for(int i = 1; i < 11; i++)
            {
                
                string rating = "R";
                if(_movieOptions[i - 1] == "Rocky IV")
                {
                    rating = "PG";
                }

                Movie movie = new Movie(_movieOptions[i - 1], rating, _movieDescriptions[i - 1], _runTimes[i - 1]);
                movie.Id = i;

                _movies.Add(movie);
            }

            Random random = new Random();
            for (int i = 1; i < 11; i++)
            {
                Screening screening = new Screening(i, i, random.Next(20, 60 + 1), RandomizeDate());
                screening.Id = i;

                _screenings.Add(screening);
            }
        }
        
        public List<Customer> Customers { get { return _customers; } } 
        public List<Movie> Movies { get { return _movies; } } 
        public List<Screening> Screenings { get { return _screenings; } } 

    }
}

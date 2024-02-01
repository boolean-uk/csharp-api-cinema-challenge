using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data {
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


        private List<string> _company = new List<string>()
        {
            "Penguin Random House",
            "HarperCollins",
            "Simon & Schuster",
            "Macmillan Publishers",
            "Hachette Livre",
            "Scholastic",
            "Pearson",
            "Wiley",
            "Bloomsbury",
            "Oxford University Press",
            "Cambridge University Press",
            "Elsevier",
            "Springer",
            "Taylor & Francis",
            "John Wiley & Sons",
            "MIT Press",
            "Houghton Mifflin Harcourt",
            "Pan Macmillan",
            "Harlequin",
            "Puffin Books"
        };

        private List<string> _movieRatings = new List<string>()
        {
            "G",
            "PG",
            "PG-13",
            "R",
            "NC-17"
        };

        private List<string> _moviesName = new List<string>()
        {
            @"Star Wars: Episode IV - A New Hope",
            @"The Shawshank Redemption",
            @"The Godfather",
            @"The Dark Knight",
            @"The Lord of the Rings: The Return of the King",
            @"12 Angry Men",
            @"Pulp Fiction",
            @"Schindler's List",
            @"The Good, the Bad and the Ugly",
            @"Fight Club",
            @"Forrest Gump",
            @"Interstellar",
            @"The Matrix",
            @"Inception",
            @"The Shining",
            @"Back to the Future",
            @"The Lion King",
            @"Spirited Away"
        };

        private List<string> MovieDescriptions = new List<string>()
        {
            "A young farm boy named Luke Skywalker joins a rebel alliance to fight against the evil Galactic Empire.",
            "A man is wrongly convicted of murder and sentenced to life in Shawshank State Penitentiary, where he befriends a fellow inmate and finds hope in the face of adversity.",
            "A powerful Mafia family's aging patriarch transfers control of his empire to his reluctant youngest son.",
            "A troubled young Batman confronts the Joker, a psychopathic criminal who plunges Gotham City into chaos.",
            "A hobbit named Frodo Baggins inherits the One Ring, an object of immense power that must be destroyed in the fires of Mount Doom in order to save Middle-earth from the Dark Lord Sauron.",
            "A jury of 12 men must decide the fate of a man accused of murder, but their own prejudices and preconceptions threaten to derail their deliberations.",
            "A hit man, his partner, and a group of gangsters square off in a series of brutal encounters.",
            "A businessman saved from the Holocaust becomes determined to rescue others during the war.",
            "Three gunslingers ride into a small town seeking a fortune in gold buried beneath it.",
            "A man's obsession with self-improvement takes a dark turn.",
            "A man with a low IQ but incredible talent for ping-pong becomes an unlikely hero.",
            "A former NASA pilot and a group of scientists travel through a wormhole in search of a new home for humanity.",
            "A computer hacker learns that reality is not what it seems when he joins a group of freedom fighters who use advanced technology to fight against a tyrannical regime.",
            "A thief learns that he has the ability to enter people's dreams, and he uses this ability to steal information from others.",
            "A family heads to an isolated hotel for the winter where they are isolated from the outside world and soon begin to experience strange and terrifying events.",
            "A teenager accidentally travels back in time to 1955 and must race against time to get back to his own era.",
            "A young lion prince is betrayed and exiled from his kingdom, but he must return to reclaim his birthright and overthrow the evil usurper who took his place.",
            "A young girl ventures into a magical world of spirits to rescue her parents."
        };


        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();
        private List<Ticket> _tickets = new List<Ticket>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random ticketRandom = new Random();
            Random movieRandom = new Random();
            Random screenRandom = new Random();



            for (int x = 1; x < 25; x++)
            {
                string n = _firstnames[authorRandom.Next(_firstnames.Count)] + _lastnames[authorRandom.Next(_lastnames.Count)];
                Customer Customer = new Customer() 
                {
                    Id = x,
                    Name = n,
                    Email = $"{n}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower(),
                    Phone = "21234",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                _customers.Add(Customer);
            }

            for (int x = 1; x < 30; x++)
            {
                Movie movies = new Movie
                {
                    Id = x,
                    Title = _moviesName[movieRandom.Next(_moviesName.Count)],
                    Rating = _movieRatings[movieRandom.Next(_movieRatings.Count)],
                    Description = MovieDescriptions[movieRandom.Next(MovieDescriptions.Count)],
                    RuntimeMins = "240",

                };
                _movies.Add(movies);
            }

            for (int x = 1; x < 25; x++)
            {
                Screening screening = new Screening
                {
                    Id = x,
                    ScreenNumber = screenRandom.Next(1,25),
                    Capacity = screenRandom.Next(20,125),
                    StartsAt = DateTime.UtcNow,
                    EndsAt = DateTime.UtcNow.AddHours(2),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = screenRandom.Next(1, _movies.Count)
                };
                _screenings.Add(screening);
            }

            for (int x = 1; x < 25; x++)
            {
                Ticket ticket = new Ticket
                {
                    Id = x,
                    NumSeats = ticketRandom.Next(1,5),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ScreeningId = screenRandom.Next(1, _screenings.Count),
                    CustomerId = screenRandom.Next(1, _customers.Count)
                };
                _tickets.Add(ticket);
            }

        }
        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Ticket> Tickets { get { return _tickets; } }
        public List<Screening> Screenings { get { return _screenings; } }
    }
    
}
using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.MovieModels;
using api_cinema_challenge.Models.ScreeningModels;
using Bogus;


namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Movie> _movies = new List<Movie>();
        private List<Screening> _screenings = new List<Screening>();

        public Seeder()
        {
            Random random = new Random();

            // Seed customers
            string[] firstNames = { "John", "Jane", "David", "Sarah", "Michael", "Emily", "Matthew", "Jennifer", "Daniel", "Jessica" };
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Rodriguez", "Wilson" };

            for (int i = 1; i <= 100; i++)
            {
                Customer customer = new Customer();
                customer.Id = i;
                customer.Name = $"{firstNames[new Random().Next(firstNames.Length)]} {lastNames[new Random().Next(lastNames.Length)]}";
                customer.Phone = GenerateRandomPhone();
                customer.Email = GenerateRandomEmail(customer.Name);
                _customers.Add(customer);
            }

            // Seed movies
            string[] ratings = { "G", "PG", "PG-13", "R" };

            for (int i = 1; i <= 20; i++)
            {
                Movie movie = new Movie();
                movie.Id = i;
                movie.Title = GenerateRandomTitle();
                movie.Description = GenerateRandomDescription();
                movie.Rating = ratings[new Random().Next(ratings.Length)];
                movie.Runtime = $"{new Random().Next(60, 180)} minutes";
                _movies.Add(movie);
            }

            // Seed screenings
            for (int i = 1; i <= 60; i++)
            {
                Screening screening = new Screening();
                screening.Id = i;
                screening.StartsAt = DateTime.UtcNow.AddDays(random.Next(1, 7)).AddHours(random.Next(10, 20));
                screening.ScreenNumber = random.Next(1, 5);
                screening.Capacity = 50; // Adjust capacity as needed

                // Assign a random movie to the screening
                int randomMovieId = random.Next(1, _movies.Count + 1);
                screening.MovieId = randomMovieId;

                _screenings.Add(screening);
            }
        }

        public List<Customer> Customers { get { return _customers; } }
        public List<Movie> Movies { get { return _movies; } }
        public List<Screening> Screenings { get { return _screenings; } }

        private string GenerateRandomTitle()
        {
            var titleFaker = new Faker("nb_NO");
            return titleFaker.Lorem.Sentence(wordCount: 3);
        }

        private string GenerateRandomDescription()
        {
            var descriptionFaker = new Faker("nb_NO");
            return descriptionFaker.Lorem.Paragraphs(2);
        }

        private string GenerateRandomPhone()
        {
            var phoneFaker = new Faker("nb_NO");
            return phoneFaker.Phone.PhoneNumber();
        }

        private string GenerateRandomEmail(string name)
        {
            var emailFaker = new Faker("nb_NO");
            return emailFaker.Internet.Email(name);
        }
    }
}

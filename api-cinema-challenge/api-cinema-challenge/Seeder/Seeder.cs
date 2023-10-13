using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Bogus;
using Newtonsoft.Json.Linq;

namespace api_cinema_challenge.Seeder
{
    // using https://developer.themoviedb.org/reference/changes-movie-list and bogus
    public class Seeder
    {
        private const string TmdbApiKey = "THISisNOtMyKey";
        private const string TmdbApiBaseUrl = "https://api.themoviedb.org/3xxxxxx";
        private readonly CinemaContext _context;

        public Seeder(CinemaContext context)
        {
            _context = context;
        }

        public async Task SeedAll()
        {
            await SeedMovies();
            SeedCustomers();
            SeedScreenings();
            SeedTickets();
        }

        public async Task SeedMovies(int numberOfMovies = 100)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync($"{TmdbApiBaseUrl}/movie/popular?api_key={TmdbApiKey}&language=en-US&page=1");
            var jsonResponse = JObject.Parse(response);
            var movies = jsonResponse["results"].Take(numberOfMovies);

            foreach (var movie in movies)
            {
                var movieId = movie["id"].ToString();
                var movieDetailsResponse = await httpClient.GetStringAsync($"{TmdbApiBaseUrl}/movie/{movieId}?api_key={TmdbApiKey}&language=en-US");
                var movieDetails = JObject.Parse(movieDetailsResponse);

                var newMovie = new Movie
                {
                    Title = movieDetails["title"].ToString(),
                    Rating = movieDetails["vote_average"].ToString(),
                    Description = movieDetails["overview"].ToString(),
                    RuntimeMins = movieDetails["runtime"].ToObject<int>()
                };

                _context.Movies.Add(newMovie);
            }

            await _context.SaveChangesAsync();
        }

        public void SeedCustomers(int numberOfCustomers = 50)
        {
            var testCustomers = new Faker<Customer>()
         .RuleFor(c => c.Name, f => f.Name.FullName())
         .RuleFor(c => c.Email, f => f.Internet.Email())
         .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber())
         .Generate(numberOfCustomers);

            _context.Customers.AddRange(testCustomers);
            _context.SaveChanges();
        }

        public void SeedScreenings(int numberOfScreenings = 200)
        {
            var movies = _context.Movies.ToList();
            var testScreenings = new Faker<Screening>()
                .RuleFor(s => s.MovieId, f => f.PickRandom(movies).Id)
                .RuleFor(s => s.StartsAt, f => f.Date.Between(DateTime.Now, DateTime.Now.AddDays(30)).ToUniversalTime())
                .RuleFor(s => s.ScreenNumber, f => f.Random.Int(1, 20))
                .RuleFor(s => s.Capacity, f => f.Random.Int(1, 300))

                .Generate(numberOfScreenings);

            _context.Screenings.AddRange(testScreenings);
            _context.SaveChanges();
        }

        public void SeedTickets(int numberOfTickets = 500)
        {
            var customers = _context.Customers.ToList();
            var screenings = _context.Screenings.ToList();
            var testTickets = new Faker<Ticket>()
                .RuleFor(t => t.CustomerId, f => f.PickRandom(customers).Id)
                .RuleFor(t => t.ScreeningId, f => f.PickRandom(screenings).Id)
                .RuleFor(t => t.NumSeats, f => f.Random.Int(1, 5))
                .Generate(numberOfTickets);

            _context.Tickets.AddRange(testTickets);
            _context.SaveChanges();
        }
    }
}
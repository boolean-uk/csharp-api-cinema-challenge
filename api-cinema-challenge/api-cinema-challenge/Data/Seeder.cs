using api_cinema_challenge.DataContext;
using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        private static readonly List<string> MovieTitles = new List<string>()
        {
            "Movie 1",
            "Movie 2",
            "Movie 3",
            "Movie 4",
            "Movie 5",
            "Movie 6",
            "Movie 7",
            "Movie 8",
            "Movie 9",
            "Movie 10",
            "Movie 11"
        };

        private static readonly List<string> MovieDescriptions = new List<string>()
        {
            "Description 1",
            "Description 2",
            "Description 3",
            "Description 4",
            "Description 5",
            "Description 6",
            "Description 7",
            "Description 8",
            "Description 9",
            "Description 10",
            "Description 11"
        };

        private static readonly List<int> MovieRuntimes = new List<int>()
        {
            90,
            110,
            130,
            150,
            170
        };

        private static readonly List<double> MovieRatings = new List<double>()
        {
            5.0,
            5.1,
            5.5,
            5.7,
            7.0,
            7.5,
            7.7,
            9.0,
            9.5,
            9.7,
            10.0
        };

        private static readonly List<string> CustomerNames = new List<string>()
        {
            "Customer 1",
            "Customer 2",
            "Customer 3",
            "Customer 4",
            "Customer 5",
            "Customer 6",
            "Customer 7",
            "Customer 8",
            "Customer 9",
            "Customer 10",
            "Customer 11"
        };

        private static readonly List<string> CustomerEmails = new List<string>()
        {
            "customer1@example.com",
            "customer2@example.com",
            "customer3@example.com",
            "customer4@example.com",
            "customer5@example.com",
            "customer6@example.com",
            "customer7@example.com",
            "customer8@example.com",
            "customer9@example.com",
            "customer10@example.com",
            "customer11@example.com"
        };

        private static readonly List<string> CustomerPhones = new List<string>()
        {
            "555-111-1111",
            "555-111-3333",
            "555-111-5555",
            "555-111-7777",
            "555-555-1111",
            "555-555-3333",
            "555-555-5555",
            "555-555-7777",
            "555-777-1111",
            "555-777-5555",
            "555-777-7777"
        };

        private static readonly Random Random = new Random();

        public static void Seed(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                var movies = new List<Movie>();
                var screenings = new List<Screening>();
                var customers = new List<Customer>();
                var tickets = new List<Ticket>();

                if (!db.Movies.Any())
                {
                    for (int x = 1; x <= MovieTitles.Count; x++)
                    {
                        Movie movie = new Movie();
                        movie.Id = x;
                        movie.Title = MovieTitles[Random.Next(MovieTitles.Count)];
                        movie.Rating = MovieRatings[Random.Next(MovieRatings.Count)];
                        movie.Description = MovieDescriptions[Random.Next(MovieDescriptions.Count)];
                        movie.RuntimeMins = MovieRuntimes[Random.Next(MovieRuntimes.Count)];
                        movie.CreatedAt = DateTime.UtcNow;
                        movie.UpdatedAt = DateTime.UtcNow;

                        movies.Add(movie);
                    }
                    db.Movies.AddRange(movies);
                }

                if (!db.Customers.Any())
                {
                    for (int x = 1; x <= CustomerNames.Count; x++)
                    {
                        Customer customer = new Customer();
                        customer.Id = x;
                        customer.Name = CustomerNames[Random.Next(CustomerNames.Count)];
                        customer.Email = CustomerEmails[Random.Next(CustomerEmails.Count)];
                        customer.Phone = CustomerPhones[Random.Next(CustomerPhones.Count)];
                        customer.CreatedAt = DateTime.UtcNow;
                        customer.UpdatedAt = DateTime.UtcNow;

                        customers.Add(customer);
                    }
                    db.Customers.AddRange(customers);
                }

                if (!db.Screenings.Any())
                {
                    int screeningId = 1; 

                    foreach (var movie in movies)
                    {
                        for (int x = 1; x <= Random.Next(5, 10); x++)
                        {
                            Screening screening = new Screening();
                            screening.Id = screeningId++;
                            screening.MovieId = movie.Id;
                            screening.ScreenNumber = Random.Next(1, 17);
                            screening.Capacity = Random.Next(50, 300);
                            screening.StartsAt = DateTime.UtcNow.AddHours(1);
                            screening.CreatedAt = DateTime.UtcNow;
                            screening.UpdatedAt = DateTime.UtcNow;

                            screenings.Add(screening);
                        }
                    }
                    db.Screenings.AddRange(screenings);
                }

                if (!db.Tickets.Any())
                {
                    foreach (var screening in screenings)
                    {
                        foreach (var customer in customers)
                        {
                            Ticket ticket = new Ticket();
                            ticket.NumSeats = Random.Next(1, 5);
                            ticket.ScreeningId = screening.Id;
                            ticket.CustomerId = customer.Id;
                            ticket.CreatedAt = DateTime.UtcNow;
                            ticket.UpdatedAt = DateTime.UtcNow;

                            tickets.Add(ticket);
                        }
                    }
                    db.Tickets.AddRange(tickets);
                }
                db.SaveChanges();
            }
        }
    }
}
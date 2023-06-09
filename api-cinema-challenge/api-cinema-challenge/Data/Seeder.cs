using api_cinema_challenge.Context;
using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Data
{
    public static class Seeder
    {
        private static List<String> Name = new List<String>()
        {
        "Herleifr",
        "Arnfinn",
        "Steinar",
        "Gunnr",
        "Ingeborg",
        "Eysteinn",
        "Bo",
        "Ragnhild",
        "Brynja",
        "Oda"
        };

        private static List<string> Email = new List<String>()
        {
        "herleifr@yahoo.com",
        "arnfinn@mail.nl",
        "steinar@gmail.com",
        "gunnr@mail.ru",
        "ingeborg@ya.ru",
        "eysteinn@yahoo.com",
        "bo@mail.nl",
        "ragnhild@gmail.com",
        "brynja@mail.ru",
        "oda@ya.ru"
        };

        private static List<String> Phone = new List<String>()
        {
        "+358 50 04380905",
        "+376 690 342 948",
        "+54 9 2954 47-2284",
        "+61 493 339 369",
        "+43 651 10694386",
        "+375 29 948-24-66",
        "+32 489 50 29 38",
        "+238 597 89 91",
        "+1 343-910-1548",
        "+53 5 6987619"
        };

        private static List<String> Title = new List<String>()
        {
            "Pulp Fiction",
            "The Lion King",
            "The Big Lebowski",
            "Jurassic Park",
            "Fight Club"
        };

        private static List<String> Rating = new List<String>()
        {
        "92%",
        "93%",
        "79%",
        "91%",
        "79%"
        };

        private static List<String> Description = new List<String>()
        {
        "One of the most influential films of the 1990s",
        "Emotionally stirring, richly drawn, and beautifully animated",
        "Shaggy dog story won't satisfy everybody",
        "spectacle of special effects and life-like animatronics",
        "Solid acting, amazing direction, and elaborate production"
        };

        private static List<int> RunTime = new List<int>()
        {
        139,
        76,
        94,
        156,
        131
        };

        private static List<int> ScreenNumber = new List<int>()
        {
            1,
            2,
            3
        };

        private static List<int> Capacity = new List<int>()
        {
            56,
            87,
            123
        };

        public static void Seed(this WebApplication app)
        {
            using (var db = new CinemaContext())
            {
                Random customerRandom = new Random();
                Random movieRandom = new Random();
                Random screeningRandom = new Random();
                Random ticketRandom = new Random();

                var customers = new List<Customers>();
                var movies = new List<Movies>();
                var screenings = new List<Screenings>();
                var tickets = new List<Tickets>();

                if (!db.Movies.Any())
                {
                    for (int x = 1; x < 20; x++)
                    {
                        Movies movie = new Movies();
                        movie.Id = x;
                        movie.Title = Title[movieRandom.Next(Title.Count)];
                        movie.Description = Description[movieRandom.Next(Description.Count)];
                        movie.Rating = Rating[movieRandom.Next(Rating.Count)];
                        movie.CreatedAt = DateTime.UtcNow;
                        movie.UpdatedAt = DateTime.UtcNow;
                        movie.RunTime = RunTime[movieRandom.Next(RunTime.Count)];
                        movies.Add(movie);
                    }
                    db.Movies.AddRange(movies);
                }

                if (!db.Screenings.Any())
                {
                    for (int x = 1; x < 20; x++)
                    {
                        Screenings screening = new Screenings();
                        screening.Id = x;
                        screening.ScreenNumber = ScreenNumber[screeningRandom.Next(ScreenNumber.Count)];
                        screening.Capacity = Capacity[screeningRandom.Next(Capacity.Count)];
                        screening.StartedAt = DateTime.UtcNow;
                        screening.CreatedAt = DateTime.UtcNow;
                        screening.UpdatedAt = DateTime.UtcNow;
                        screening.MoviesId = movies[movieRandom.Next(movies.Count)].Id;
                        screenings.Add(screening);
                    }
                    db.Screenings.AddRange(screenings);
                }


                if(!db.Tickets.Any()) 
                { 
                    for (int x =1; x <20;  x++)
                    {
                        Tickets ticket = new Tickets();
                        ticket.Id = x;
                        var screening = screenings[screeningRandom.Next(screenings.Count)];
                        ticket.numSeats = ticketRandom.Next(1, screening.Capacity + 1);
                        ticket.ScreenId = screening.Id;
                        tickets.Add(ticket);
                    }
                    db.Tickets.AddRange(tickets);
                }
                if (!db.Customers.Any())
                {
                    for (int x = 1; x < 100; x++)
                    {
                        Customers customer = new Customers();
                        customer.Id = x;
                        customer.Name = Name[customerRandom.Next(Name.Count)];
                        customer.Email = Email[customerRandom.Next(Email.Count)];
                        customer.Phone = Phone[customerRandom.Next(Phone.Count)];
                        customer.CreatedAt = DateTime.UtcNow;
                        customer.UpdatedAt = DateTime.UtcNow;
                        customers.Add(customer);
                    }
                    db.Customers.AddRange(customers);
                }

                db.SaveChanges();
            }
        }
    }
}

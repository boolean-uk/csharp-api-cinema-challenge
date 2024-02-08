using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Models.Domain.Junctions;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

namespace api_cinema_challenge.Data
{
    public static class CinemaDataSeed
    {
        private static List<string> auditoriumNameBeginnings = new List<string>()
        {
            "World",
            "Giga",
            "King",
            "Ultra HD 3D",
            "The",
            "Magic",
            "The Oracle",
            "The King",
            "Galactic",
            "The Prince",
            "The Velvet",
            "The Nebula",
            "The Grand",
            "Futuristic 3D Max",
            "Ultimate",
            "Ultra Max",
            "Royal Imperial",
            "Starlight Deluxe",
            "Celestial Cinema"
        };
        private static List<string> auditoriumNameEndings = new List<string>()
        {
            "Hall",
            "Sphere",
            "Max",
            "Enclave",
            "Horizon",
            "Loft",
            "Portal",
            "Ultra Screen",
            "Chamber",
            "Arena",
            "Vault",
            "Nexus",
            "Pavillion",
            "Hall of Fantasy",
            "Hall of Dreams"
        };
        private static List<string> movieTitleBeginnings = new List<string>()
        {
            "The",
            "Dark",
            "True",
            "Gran",
            "American",
            "Last",
            "Remember the",
            "The Count of",
            "Winter's",
            "War of the",
            "Fight",
            "12",
            "The Big",
            "Pulp",
            "The Sixth",
            "The Legend of the",
            "The Great",
            "War",
            "Mystic",
            "Almost",
            "No",
            "Scandalous",
            "Legendary",
            "October",
            "The Book of",
            "Law Abiding",
            "Return of the",
            "A New",
            "The Phantom"
        };
        private static List<string> movieTitleMainParts = new List<string>()
        {
            "Turismo",
            "Apes",
            "Skyscraper",
            "Horse",
            "Sense",
            "Grit",
            "Blow",
            "River",
            "Famous",
            "Hollywood Star",
            "Signs",
            "Country",
            "Odyssey",
            "Sky",
            "Dodgeball",
            "Knights",
            "Lincoln",
            "Departed",
            "Empire",
            "Menace",
            "Winter",
            "Summer",
            "Revolover",
            "House",
            "Pi",
            "Blood",
            "Day",
            "Lawless",
            "Flight",
            "Mummie",
            "Cannibals",
            "Monkeys",
            "Island"
        };
        private static List<string> movieTitleEndings = new List<string>()
        {
            "for Old Men",
            ", Where Art Thou?",
            "Hunting",
            "on Fire",
            "May Come",
            "of Men",
            "of Violence",
            "Z",
            "2",
            "3",
            "4",
            "II",
            "III",
            "of Monte Cristo",
            "of Life",
            "of the Worlds",
            "Club",
            "of the Dead",
            "Strikes Back",
            "Show",
            "Code",
            "Effect",
            "Part II",
            "Next Door",
            "vs Evil"
        };
        private static List<string> movieDescriptions = new List<string>()
        {
            "An epic adventure like you've never seen.",
            "The hero has nowhere to turn, it is a matter of life and death.",
            "A secret curse plagues the land, and only one hero can save the day.",
            "Will the world be saved, or will everyone perish?",
            "A high school drama unfolds.",
            "A murder mystery that can only be solved by a single human.",
            "The greatest movie ever made.",
            "Prepare for something like you have ever seen.",
            "Explosions, cars, skyscrapers.",
            "Love, intrigue, romance."
        };
        private static List<string> firstnames = new List<string>()
        {
            "Brandon",
            "Leia",
            "Clark",
            "Bruce",
            "Tony",
            "Thor",
            "Steve",
            "Diana",
            "Kevin",
            "Scott",
            "Jessica",
            "Barry",
            "Barry",
            "Logan",
            "Lara",
            "Christopher",
            "George",
            "Elinor",
            "Thomas",
            "Tim",
            "Ellie",
            "Rowan",
            "Steven",
            "Jennifer",
            "Alex",
            "Clover",
            "Sam"
        };
        private static List<string> surnames = new List<string>()
        {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Garcia",
            "Miller",
            "Davis",
            "Martinez",
            "Lopez",
            "Gonzalez",
            "Wilson",
            "Anderson",
            "Thomas",
            "Taylor",
            "Moore",
            "Jackson",
            "Martin",
            "Lee",
            "Perez",
            "Thompson",
            "White",
            "Harris",
            "Lucas",
            "Spielberg",
        };
        private static int seed = 777;
        private static Random random = new Random(seed);
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            int numMovies = 50;
            int numCustomers = 200;
            int numScreenings = 30;
            int numAuditoriums = 8;
            int numTickets = 500;
            List<Auditorium> auditoriums = Enumerable.Range(1, numAuditoriums).Select(id => GenerateRandomAuditorium(id)).ToList();
            List<Movie> movies = Enumerable.Range(1, numMovies).Select(id => GenerateRandomMovie(id)).ToList();
            List<Customer> customers = Enumerable.Range(1, numCustomers).Select(id => GenerateRandomCustomer(id)).ToList();
            List<Screening> screenings = Enumerable.Range(1, numScreenings).Select(id => GenerateRandomScreening(id, movies)).ToList();
            List<Ticket> tickets = Enumerable.Range(1, numTickets).Select(id => GenerateRandomTicket(id, customers, screenings)).ToList();
            List<Seat> seats = GenerateRandomSeats(auditoriums);
            List<TicketSeat> ticketSeats = GenerateRandomTicketSeats(screenings, auditoriums, seats, tickets);
            modelBuilder.Entity<Auditorium>().HasData(auditoriums);
            modelBuilder.Entity<Movie>().HasData(movies);
            modelBuilder.Entity<Customer>().HasData(customers);
            modelBuilder.Entity<Screening>().HasData(screenings);
            modelBuilder.Entity<Ticket>().HasData(tickets);
            modelBuilder.Entity<Seat>().HasData(seats);
            modelBuilder.Entity<TicketSeat>().HasData(ticketSeats);
        }

        private static Auditorium GenerateRandomAuditorium(int id)
        {
            Auditorium auditorium = new Auditorium();
            auditorium.Id = id;
            auditorium.Name = $"{PickRandomString(auditoriumNameBeginnings)} {PickRandomString(auditoriumNameEndings)}";
            return auditorium;
        }

        private static List<Seat> GenerateRandomSeats(List<Auditorium> auditoriumList)
        {
            List<Seat> seats = new List<Seat>();
            int nextId = 1;
            foreach (Auditorium auditorium in auditoriumList)
            {
                int numRows = random.Next(1, 15);
                int numSeatsPerRow = RoundInt(random.Next(5, 20));
                int maxWeight = RoundInt(random.Next(40,350));
                for (int r = 1; r < numRows + 1; r++)
                {
                    for (int s = 1; s < numSeatsPerRow + 1; s++)
                    {
                        seats.Add(new Seat(){Id=nextId++, AuditoriumId=auditorium.Id, RowNumber=r, SeatNumber=s, MaxWeight=maxWeight});
                    }
                }
            }
            return seats;
        }

        private static Customer GenerateRandomCustomer(int id)
        {
            Customer customer = new Customer();
            customer.Id = id;
            string firstname = PickRandomString(firstnames);
            string surname = PickRandomString(surnames);
            customer.Name = $"{firstname} {surname}";
            customer.Email = $"{firstname.ToLower()}{surname.ToLower()}{random.Next(1, 99)}@mail.com";
            customer.Phone = random.Next(300000000, 999999999).ToString();
            customer.Age = random.Next(18, 100);
            customer.Weight = random.Next(50, 140);
            return customer;
        }

        private static Movie GenerateRandomMovie(int id)
        {
            Movie movie = new Movie();
            movie.Id = id;
            movie.Title = GenerateRandomMovieTitle();
            movie.Description = PickRandomString(movieDescriptions);
            movie.Rating = GetRandomMovieRating();
            movie.RuntimeMins = random.Next(60, 250);
            return movie;
        }

        private static Screening GenerateRandomScreening(int id, List<Movie> movieList)
        {
            Screening screening = new Screening();
            screening.Id = id;
            screening.MovieId = movieList[random.Next(movieList.Count)].Id;
            screening.StartsAt = GenerateRandomDate();
            return screening;
        }

        private static Ticket GenerateRandomTicket(int id, List<Customer> customerList, List<Screening> screeningList)
        {
            Ticket ticket = new Ticket();
            ticket.Id = id;
            ticket.CustomerId = customerList[random.Next(screeningList.Count)].Id;
            return ticket;
        }

        private static List<TicketSeat> GenerateRandomTicketSeats(List<Screening> screeningList, List<Auditorium> auditoriumList, List<Seat> seatList, List<Ticket> ticketList)
        {
            List<TicketSeat> ticketSeats = new List<TicketSeat>();
            foreach (Screening screening in screeningList)
            {
                Auditorium auditorium = auditoriumList[random.Next(auditoriumList.Count)];
                List<Seat> screeningSeats = seatList.Where(s => s.AuditoriumId == auditorium.Id).ToList();
                foreach (Seat seat in screeningSeats) ticketSeats.Add(new TicketSeat() { ScreeningId = screening.Id, SeatId = seat.Id });
            }
            foreach (Ticket ticket in ticketList)
            {
                Screening screening = screeningList[random.Next(screeningList.Count)];
                List<TicketSeat> availableSeats = ticketSeats.Where(ts => ts.ScreeningId == screening.Id && ts.TicketId == 0).ToList();
                int numSeatsIncludedInTicket = int.Min(random.Next(1, 7), availableSeats.Count);
                for (int i = 0; i < numSeatsIncludedInTicket; i++)
                {
                    availableSeats[i].TicketId = ticket.Id;
                }
            }
            return ticketSeats;
        }

        private static string PickRandomString(List<string> stringList)
        {
            return stringList[random.Next(stringList.Count)];
        }

        private static int RoundInt(int number)
        {
            return (int)(Math.Round(number / 5.0) * 5);
        }

        private static string GenerateRandomMovieTitle()
        {
            bool hasPrefix = random.Next(1,2) == 1;
            bool hasSuffix = random.Next(1,3) == 1;
            string title = PickRandomString(movieTitleMainParts);
            if (hasPrefix) title = $"{PickRandomString(movieTitleBeginnings)} {title}";
            if (hasSuffix) title = $"{title} {PickRandomString(movieTitleEndings)}";
            return title;
        }

        private static DateTime GenerateRandomDate()
        {
            DateTime minDate = new DateTime(2024, 1, 1);
            DateTime maxDate = new DateTime(2026, 12, 31);
            TimeSpan timeSpan = maxDate - minDate;
            int totalDays = timeSpan.Days;
            int randomDaysToAdd = random.Next(totalDays + 1);
            DateTime randomDate = minDate.AddDays(randomDaysToAdd).AddHours(random.Next(13, 23)).AddMinutes(RoundInt(random.Next(0,55)));
            return DateTime.SpecifyKind(randomDate, DateTimeKind.Utc);
        }

        private static MovieRating GetRandomMovieRating()
        {
            MovieRating[] movieRatings = (MovieRating[])Enum.GetValues(typeof(MovieRating));
            return movieRatings[random.Next(movieRatings.Length)];
        }
    }
}

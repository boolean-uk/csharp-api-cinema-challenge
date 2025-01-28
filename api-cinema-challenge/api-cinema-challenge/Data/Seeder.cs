using System;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data
{
    public class Seeder
    {
        private List<Movie> _movies = [
            new Movie { Id = 1, Title = "Inception", 
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                ReleaseDate = DateTime.Parse("2010-07-16").ToUniversalTime(),
                Rating = "PG-13",
                Runtime = 148,
            },
            new Movie { Id = 2, Title = "The Dark Knight",
                Description = "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness.",
                ReleaseDate = DateTime.Parse("2008-07-18").ToUniversalTime(),
                Rating = "PG-13",
                Runtime = 152,
            },
            new Movie { Id = 3, Title = "The Lord of the Rings: The Return of the King",
                Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                ReleaseDate = DateTime.Parse("2003-12-17").ToUniversalTime(),
                Rating = "PG-13",
                Runtime = 3 * 60 + 21,
            }
        ];
        private List<Customer> _customers = [
            new Customer {Id = 1, FirstName = "Todd", LastName = "Todd", Email = "todd@gmail.com", Phone = "11111111"},
            new Customer {Id = 2, FirstName = "Todder", LastName = "Todder", Email = "todder@gmail.com", Phone = "11111112"},
            new Customer {Id = 3, FirstName = "Dott", LastName = "Dott", Email = "dott@gmail.com", Phone = "22222222"},
        ];
        private List<Screen> _screens = [
            new Screen { Id = 1, Capacity = 100, Name = "Prinsen 1"},
            new Screen { Id = 2, Capacity = 200, Name = "Prinsen 2"},
            new Screen { Id = 3, Capacity = 20, Name = "Kongesalen"}
        ];
        private List<Seat> _seats = [];
        private List<Screening> _screenings = [
            new Screening { Id = 1, MovieId = 1, ScreenId = 1, StartingAt = DateTime.UtcNow, EndingAt = DateTime.UtcNow.AddMinutes(148) },
            new Screening { Id = 2, MovieId = 2, ScreenId = 3, StartingAt = DateTime.UtcNow, EndingAt = DateTime.UtcNow.AddMinutes(152) },
            new Screening { Id = 3, MovieId = 1, ScreenId = 2, StartingAt = DateTime.UtcNow, EndingAt = DateTime.UtcNow.AddMinutes(178) },
            new Screening { Id = 4, MovieId = 3, ScreenId = 3, StartingAt = DateTime.UtcNow.AddMinutes(170), EndingAt = DateTime.UtcNow.AddMinutes(3 * 60 + 21 + 170) },
        ];

        private List<Ticket> _tickets = [
            new Ticket {Id = 1, CustomerId = 1, ScreeningId = 1, ScreenId = 1, SeatId = 1},
            new Ticket {Id = 2, CustomerId = 2, ScreeningId = 2, ScreenId = 3, SeatId = 10},
            new Ticket {Id = 3, CustomerId = 2, ScreeningId = 2, ScreenId = 3, SeatId = 11},
            new Ticket {Id = 4, CustomerId = 2, ScreeningId = 2, ScreenId = 3, SeatId = 12},
            new Ticket {Id = 5, CustomerId = 2, ScreeningId = 2, ScreenId = 3, SeatId = 13},
            new Ticket {Id = 6, CustomerId = 3, ScreeningId = 4, ScreenId = 3, SeatId = 2},
            new Ticket {Id = 7, CustomerId = 1, ScreeningId = 4, ScreenId = 3, SeatId = 12},
            new Ticket {Id = 8, CustomerId = 2, ScreeningId = 4, ScreenId = 3, SeatId = 17},
            new Ticket {Id = 9, CustomerId = 2, ScreeningId = 4, ScreenId = 3, SeatId = 18},
        ];

        public Seeder()
        {
            Array values = Enum.GetValues<SeatType>();
            Random seatRandom = new Random();
            foreach (var screen in _screens)
            {
                int seatId = 1;
                for (int i = 0; i < screen.Capacity; i++)
                {
                    _seats.Add(new Seat { Id = seatId++, ScreenId = screen.Id, SeatType = (SeatType)values.GetValue(seatRandom.Next(values.Length))! });
                }
            }
        }

        public List<Movie> Movies { get { return _movies; } }
        public List<Screen> Screens { get { return _screens; } }
        public List<Customer> Customers { get { return _customers; } }
        public List<Seat> Seats { get { return _seats; } }
        public List<Screening> Screenings { get { return _screenings; } }
        public List<Ticket> Tickets { get { return _tickets; } }

    }
}

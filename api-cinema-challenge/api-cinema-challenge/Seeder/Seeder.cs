using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace api_cinema_challenge.Seeder
{
    public class Seeders
    {

        // Randoming date: 
        // Thought it will be fun....
        private static string randomDate(char option, DateTime? startdate = null, int addtion = 0)
        {
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();

            if (option == 'n' && startdate.HasValue)
            {
                startDate = startdate.Value;
                endDate = new DateTime(2024, 2, 28);

            }

            else if (option == 'u')
            {
                startDate = new DateTime(2022, 1, 1);
                endDate = new DateTime(2023, 1, 1);

            }

            else if (option == 'c')
            {
                // Define the range for random DateTime generation
                startDate = new DateTime(2018, 1, 1);
                endDate = new DateTime(2020, 1, 1);

            }

            else if (option == 'm')
            {
                startDate = new DateTime(2000, 1, 1);
                endDate = new DateTime(2018, 1, 1);
            }

            else if (option == 's')
            {
                startDate = new DateTime(2024, 2, 15);
                endDate = new DateTime(2024, 2, 28);

            }
            else if (option == 'a')
            {
                startDate = new DateTime(2024, 1, 15);
                endDate = new DateTime(2024, 1, 30);

            }

            startDate = startDate.AddMinutes(addtion);
            if (startDate > endDate)
            {
                endDate = endDate.AddMinutes(addtion);
            }

            // Generate a random TimeSpan within the range
            TimeSpan timeSpan = endDate - startDate;

            // Generate a random number of ticks within the range
            long randomTicks = (long)(timeSpan.Ticks * new Random().NextDouble());

            // Create a new DateTime by adding the random number of ticks to the start date
            DateTime randomDateTime = startDate.AddTicks(randomTicks);
            return randomDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
        }


        public List<Custommer> custommers = new List<Custommer>() {
            new Custommer{Id = 1, Name = "Kanthee K", Email = "QWER@hotmail.com", Phone = "111111", CreatedAt = DateTime.Parse(randomDate('c')), UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Custommer{Id = 2, Name = "Mohans M", Email = "1234A@hotmail.com", Phone = "22222", CreatedAt = DateTime.Parse(randomDate('c')), UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Custommer{Id = 3,Name = "Sqlq Q", Email = "QDollkee@hotmail.com", Phone = "33333", CreatedAt = DateTime.Parse(randomDate('c')), UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Custommer{Id = 4,Name = "Xcewwww", Email = "XCXXx@hotmail.com", Phone = "44444", CreatedAt = DateTime.Parse(randomDate('c')), UpdatedAt = DateTime.Parse(randomDate('u')) },
        };


        public List<Movie> movies = new List<Movie>() {
            new Movie{Id = 1, Title = "IRONMNAA",Rating = "10",Description = "NOOOO", CreatedAt =  DateTime.Parse(randomDate('m')), Runtime = 160, UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Movie{Id = 2, Title = "BARbie" ,Rating = "2",Description = "OOOOHH NOOOOO", CreatedAt =  DateTime.Parse(randomDate('m')), Runtime = 90, UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Movie{Id = 3, Title = "Avatar",Rating = "5",Description = "OOHH OOHH NOOO", CreatedAt =  DateTime.Parse(randomDate('m')), Runtime = 66, UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Movie{Id = 4, Title = "Fight Club",Description = "OOOOHH YES",Rating = "9", CreatedAt =  DateTime.Parse(randomDate('m')), Runtime = 15, UpdatedAt = DateTime.Parse(randomDate('u')) },
            new Movie{Id = 5, Title = "God Father",Rating = "16",Description = "YEEEES", CreatedAt =  DateTime.Parse(randomDate('m')), Runtime = 200, UpdatedAt = DateTime.Parse(randomDate('u')) }

        };



        public List<Screening> screenings = new List<Screening>();
        
        public List<Ticket> tickets = new List<Ticket>();



        public Seeders()
        {
            Screening screen = new Screening()
            {
                Id = 1,
                Capacity = 50,
                StartAt = DateTime.Parse(randomDate('s')),
                ScreenNumber = new Random().Next(1, 10),
                MovieId = new Random().Next(1, 6),
                UpdatedAt = DateTime.Parse(randomDate('a')),
                CreatedAt = DateTime.Parse(randomDate('u')),

            };

            screenings.Add(screen);

            for (int x = 1; x < 20; x++)
            {
                    DateTime _datetime = new DateTime();
                    Screening _screening = new Screening();
                    _screening.Id = x+1;
                    _screening.Capacity = 50;
                    _screening.ScreenNumber = new Random().Next(1, 10);
                    _screening.MovieId = new Random().Next(1, 6);
                    int _runTime = movies.FirstOrDefault(m => m.Id == _screening.MovieId).Runtime;
                    _datetime = DateTime.Parse(randomDate('n', screenings[x - 1].StartAt, _runTime));
                    _screening.StartAt = _datetime;
                    _screening.UpdatedAt = DateTime.Parse(randomDate('a'));
                    _screening.CreatedAt = DateTime.Parse(randomDate('u'));
                    screenings.Add(_screening);

               

            }
            Ticket ticket = new Ticket()
            {
                Id = 1,
                SeatNumber = new Random().Next(0, 51),
                CustommerId = new Random().Next(1, 5),
                ScreeningId = new Random().Next(1, 20),
                CreatedAt = DateTime.Parse(randomDate('u')),
                //UpdatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"))
                UpdatedAt = DateTime.Parse(randomDate('a'))
        };


            tickets.Add(ticket);


            for (int y = 1; y < 20; y++) { 

                Ticket _ticket = new Ticket();
                _ticket.Id = y;
                _ticket.SeatNumber = new Random().Next(0, 51);
                _ticket.CustommerId = new Random().Next(1, 5);
                _ticket.ScreeningId = new Random().Next(1, 20);
                _ticket.CreatedAt = DateTime.Parse(randomDate('u'));
                _ticket.UpdatedAt = DateTime.Parse(randomDate('a'));
                
                //Check if same #seat when same Screening
                do
                {
                    _ticket.SeatNumber = new Random().Next(0, 51);
                } while (tickets.Any(t => t.ScreeningId == _ticket.ScreeningId && t.SeatNumber == _ticket.SeatNumber));

                tickets.Add(_ticket);
            };
            


        }
    }
}

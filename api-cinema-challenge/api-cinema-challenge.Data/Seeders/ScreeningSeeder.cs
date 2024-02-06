using api_cinema_challenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Data.Seeders
{
    public static class ScreeningSeeder
    {
        private static Random _random = new();

        private static DateTime GenerateRandomDate()
        {
            return DateTime.Today.AddDays(_random.Next(2, 8));
        }

        public static List<Screening> Generate(int amount, int maxMovieId)
        {
            List<Screening> screenings = [];
            for (int i = 1; i <= amount; i++)
            {
                Screening screening = new()
                {
                    Id = i,
                    Capacity = _random.Next(30, 60),
                    MovieId = _random.Next(1, maxMovieId),
                    StartsAt = GenerateRandomDate(),
                };
                screenings.Add(screening);
            }
            return screenings;
        }
    }
}

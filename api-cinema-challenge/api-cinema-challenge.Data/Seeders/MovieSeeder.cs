using api_cinema_challenge.Application.Enums;
using api_cinema_challenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Data.Seeders
{
    internal class MovieSeeder
    {
        private static Random _random = new();

        private static List<string> _adjectives = [
            "Fast", "Slow", "Purple", "Amazing", "Seethrough", "Mad", "Round"
        ];

        private static List<string> _subjectives = [
            "Leopard", "Swan", "Computer", "Phone", "Piper", "Policeman"
        ];

        public static List<Movie> Generate(int amount)
        {
            List<Movie> movies = [];
            for(int i = 0; i <= amount; i++)
            {
                var adjective = _adjectives[_random.Next(0, _adjectives.Count)];
                var subjective = _subjectives[_random.Next(0, _subjectives.Count)];
                Movie movie = new()
                {
                    Id = i+1,
                    Rating = (RatingsEnum)_random.Next(0, Enum.GetNames(typeof(RatingsEnum)).Length),
                    Title = $"The {adjective} {subjective}",
                    Description = $"A movie about a {subjective} that is quite {adjective}",
                    RuntimeMins = _random.Next(40, 260),
                };
                movies.Add(movie);
            }
            return movies;
        }
    }
}

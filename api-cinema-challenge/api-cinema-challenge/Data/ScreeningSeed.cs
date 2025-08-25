//Brought to you by ChatGPT
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Data;

public static class ScreeningSeed
{
    public static List<Screening> Get()
    {
        // Source movies
        var movies = MovieSeed.Get();

        // Config (tweak as needed)
        var baseStartUtc = DateTime.UtcNow;
        const int days = 2;                     // how many days to seed
        const int showsPerDayPerScreen = 4;     // shows on each screen per day
        const int cleaningBufferMins = 20;      // gap between shows, per screen
        int[] capacities = { 80, 120, 180, 120, 60 }; // screen 1..5 capacities

        var screenings = new List<Screening>(days * capacities.Length * showsPerDayPerScreen);

        var id = 1;
        var movieIndex = 0;

        for (var d = 0; d < days; d++)
        {
            var dayStart = baseStartUtc.AddDays(d);

            for (var s = 0; s < capacities.Length; s++)
            {
                var screenNumber = s + 1;
                var slotStart = dayStart;

                for (var show = 0; show < showsPerDayPerScreen; show++)
                {
                    var movie = movies[movieIndex % movies.Count];

                    screenings.Add(new Screening
                    {
                        Id = id++,
                        MovieId = movie.Id,
                        ScreenNumber = screenNumber,
                        Capacity = capacities[s],
                        StartsAt = slotStart
                    });

                    // Advance start time for this screen by the movie length + cleaning buffer
                    slotStart = slotStart.AddMinutes(movie.RuntimeMins + cleaningBufferMins);
                    movieIndex++;
                }
            }
        }

        return screenings;
    }
}
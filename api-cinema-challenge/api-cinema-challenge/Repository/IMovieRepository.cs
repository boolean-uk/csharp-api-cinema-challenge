using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {
        public Task<IEnumerable<Movie>> GetMovies();
        public Task<Movie?> GetMovieByID(int id);
        public Task<Movie> UpdateMovie(Movie movie, string? title, string? rating, string? description, int? runtimeMins);
        public Task<Movie> CreateMovie(string title, string rating, string description, int runtimeMins, List<ScreeningPayload>? screenings);
        public Task<Movie> DeleteMovie(Movie movie);

        public Task<ICollection<Screening>> GetScreenings(int movieID);
        public Task<Screening> CreateScreening(int movieID, int screenNumber, int capacity, DateTime startsAt);
    }
}

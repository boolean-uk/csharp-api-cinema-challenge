using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovieRepository
    {

        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> GetMovieById(int id);
        Task<Movie> CreateMovie(Movie movie);
        Task<Movie> UpdateMovie(int movieId, Movie movie);
        Task<Movie> DeleteMovie(int movieId);


        Task<IEnumerable<Screening>> GetScreeningsByMovieId(int movieId);
        Task<Screening> CreateScreenings(Screening screening);






    }
}

using api_cinema_challenge.DTOs.Custommer;
using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository
    {
        // Custommer
        Task<Custommer> AddCustommer(InCustommerDTO newCustommer);
        Task<Custommer> DeleteCustommer(int id);
        Task<IEnumerable<Custommer>> GetCustommers();
        Task<Custommer> UpdateCustommer(int id, InCustommerDTO newCustommer);

        // Movie
        Task<Movie> AddMovie(InMovieDTO newMovie);
        Task<Movie> DeleteMovie(int id);
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie> UpdateMovie(int id, InMovieDTO2 newMovie);

        // Screening
        Task<IEnumerable<Screening>> GetScreeningMovies(int id);
        Task<Screening> AddScreening(int id, InScreeningDTO newScreening);
    }
}

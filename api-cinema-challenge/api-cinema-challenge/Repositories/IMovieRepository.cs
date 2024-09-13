using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;

namespace api_cinema_challenge.Repositories
{
    public interface IMovieRepository
    {
        Task<ICollection<Movie>> GetMovies();
        Task<Movie> CreateMovie(CreateMovieDto movieDto);
        Task<Movie> UpdateMovie(int id, CreateMovieDto movieDto);
        Task<Movie> DeleteMovie(int id);

    }
}

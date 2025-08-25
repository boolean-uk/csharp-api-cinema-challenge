using api_cinema_challenge.DTOs;

namespace api_cinema_challenge.Repository;

public interface IMovieRepository
{
    public Task<IEnumerable<MovieGetDto>> GetMovies();
    public Task<MoviePostDto> PostMovie(MoviePostDto mpd);
    public Task<MovieUpdateDto> UpdateMovie(int id, MovieUpdateDto mud);
    public Task<MovieGetDto> DeleteMovie(int id);
    public Task<ScreeningGetDto> CreateScreening(int movieId, ScreeningPostDto spd);
    public Task<IEnumerable<ScreeningGetDto>> GetScreenings(int movieid);
}
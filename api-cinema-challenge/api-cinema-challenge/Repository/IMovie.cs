using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IMovie
    {

        // MOVIES
        Task<IEnumerable<Movie>> GetMovies();
        Task<Movie?> GetMovie(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Movie?> CreateMovie(string title, string rating, string description, int runtimemins);
        Task<Movie?> DeleteMovie(int movieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);
        Task<Movie?> UpdateMovie(int movieId, string title, string rating, string description, int runtimemins, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations);

        public void SaveChanges();
    }
}

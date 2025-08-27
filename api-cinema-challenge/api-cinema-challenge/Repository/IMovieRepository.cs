public interface IMovieRepository
{
    Task<IEnumerable<Movie>> GetAllAsync();
    Task<Movie?> GetByIdAsync(int id);
    Task<Movie> CreateAsync(Movie customer);
    Task<Movie?> UpdateAsync(int id, Movie customer);
    Task<bool> DeleteAsync(int id);
}

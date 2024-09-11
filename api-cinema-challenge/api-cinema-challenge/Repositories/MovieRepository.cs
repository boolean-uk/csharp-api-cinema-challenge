using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public Task<Movie> AddMovie(string title, string rating, string description, int runtimeMins)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetMovie()
        {
            throw new NotImplementedException();
        }

        public Task<Movie> UppdateMovie(int id, string? title, string? rating, string? description, int? runtimeMins)
        {
            throw new NotImplementedException();
        }
    }
}

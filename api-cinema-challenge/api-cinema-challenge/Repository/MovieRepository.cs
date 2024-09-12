using api_cinema_challenge.Models.Movie;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public Payload<MovieDTO> CreateMovie(string title, string rating, string description, int runtime) { throw new NotImplementedException(); }
        public Payload<List<MovieDTO>> GetMovies() { throw new NotImplementedException(); }
        public Payload<MovieDTO> UpdateMovie(int id, string title, string rating, string description, int runtime) { throw new NotImplementedException(); }
        public Payload<MovieDTO> DeleteMovie(int id) { throw new NotImplementedException(); }
    }
}

using api_cinema_challenge.Models.Movie;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public Payload<MovieDTO> CreateMovie() { throw new NotImplementedException(); }
        public Payload<List<MovieDTO>> GetMovies() { throw new NotImplementedException(); }
        public Payload<MovieDTO> UpdateMovies() { throw new NotImplementedException(); }
        public Payload<MovieDTO> DeleteMovie() { throw new NotImplementedException(); }
    }
}

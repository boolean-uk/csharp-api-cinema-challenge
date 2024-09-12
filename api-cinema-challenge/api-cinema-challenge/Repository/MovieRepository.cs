using api_cinema_challenge.Models.Movie;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public partial class Repository : IRepository
    {
        public MovieDTO CreateMovie(string title, string rating, string description, int runtime)
        {
            Movie movie = null;
            _db.Movies.Add(movie = new Movie() { Id = _db.Movies.Max(x => x.Id), Title = title, rating = rating, Description = description, runtimeMins = runtime });
            _db.SaveChanges();
            return movie.MapToDTO();
        }

        public List<MovieDTO> GetMovies()
        {
            return _db.Movies.ToList().MapListToDTO();
        }
        public MovieDTO UpdateMovie(int id, string title, string rating, string description, int runtime)
        {
            if (_db.Movies.FirstOrDefault(x => x.Id == id) != null)
            {
                var movie = new Movie() { Id = id, Title = title, rating = rating, Description = description, runtimeMins = runtime };
                _db.Movies.Attach(movie);
                _db.Movies.Where(x => x.Id == id).ExecuteUpdate(z => z.SetProperty(c => c.Title, title).SetProperty(c => c.rating, rating).SetProperty(c => c.Description, description).SetProperty(c => c.runtimeMins, runtime));
                return movie.MapToDTO();
            }
            return null;
        }
        public MovieDTO DeleteMovie(int id)
        {
            Movie movie = null;
            _db.Movies.Remove(movie = _db.Movies.FirstOrDefault(x => x.Id == id));
            _db.SaveChanges();
            return movie.MapToDTO();
        }
    }
}

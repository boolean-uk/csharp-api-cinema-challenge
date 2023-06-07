using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public bool AddMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteMovie(int id)
        {
            using (var db = new CinemaContext())
            {
                db.Remove(db.Movies.Find(id));
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public Movie GetMovie(int id)
        {
            Movie result;
            using (var db = new CinemaContext())
            {
                result = db.Movies.Find(id);
                db.SaveChanges();
                return result;
            }
            return result;
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.Movies.ToList();
            }
            return null;
        }

        public bool UpdateMovie(Movie movie)
        {
            using (var db = new CinemaContext())
            {
                db.Update(movie);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

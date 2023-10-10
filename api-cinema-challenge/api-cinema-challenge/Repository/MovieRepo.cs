using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using System.Runtime.Intrinsics.Arm;

namespace api_cinema_challenge.Repository
{
    public class MovieRepo : IMovieRepo
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
                var target = db.Movies.FirstOrDefault(x => x.Id == id);
                if(target != null)
                {
                    db.Movies.Remove(target);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public IEnumerable<Movie> GetAllMovies()
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
                var target = db.Movies.FirstOrDefault(x => x.Id == movie.Id);
                if (target != null)
                {
                    db.Movies.Attach(target);
                    target.title = movie.title;
                    target.rating = movie.rating;
                    target.description = movie.description;
                    target.runtimeMins = movie.runtimeMins;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}

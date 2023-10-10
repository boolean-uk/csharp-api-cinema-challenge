using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Movie CreateMovie(MoviePost m)
        {
            using (var db = new CinemaContext())
            {
                DateTime date = DateTime.UtcNow;
                Movie movie = new Movie()
                {
                    title = m.title,
                    rating = m.rating,
                    description = m.description,
                    runtimeMins = m.runtimeMins,
                    createdAt = date,
                    updatedAt = date
                };

                db.Movies.Add(movie);
                db.SaveChanges();
                return movie;
            }
            return null;
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var db = new CinemaContext())
            {
                return db.Movies.ToList();
            }
            return null;
        }
    }
}

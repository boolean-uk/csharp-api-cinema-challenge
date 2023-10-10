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

        public Movie UpdateMovie(int id, MoviePut movieFields)
        {
            using (var db = new CinemaContext())
            {
                Movie movie = db.Movies.SingleOrDefault(m => m.id == id);
                // TODO: handle case where movie is null

                bool updatedFields = false;

                db.Movies.Attach(movie);
                // update all non-null fields
                if (!string.IsNullOrEmpty(movieFields.title))
                {
                    updatedFields = true;
                    movie.title = movieFields.title;
                }
                if (!string.IsNullOrEmpty(movieFields.rating))
                {
                    updatedFields = true;
                    movie.rating = movieFields.rating;
                }
                if (!string.IsNullOrEmpty(movieFields.description))
                {
                    updatedFields = true;
                    movie.description = movieFields.description;
                }
                if (movieFields.runtimeMins != 0)
                {
                    updatedFields = true;
                    movie.runtimeMins = movieFields.runtimeMins;
                }
                if (updatedFields)
                {
                    movie.updatedAt = DateTime.UtcNow;
                    db.SaveChanges();
                }
                return movie;
            }
            return null;
        }
    }
}

using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

                // if screenings field exists, create screenings as well
                if (m.screenings != null && m.screenings.Any())
                {
                    foreach (ScreeningPost s in m.screenings)
                    {
                        Screening screening = new Screening()
                        {
                            screenNumber = s.screenNumber,
                            capacity = s.capacity,
                            startsAt = s.startsAt,
                            createdAt = date,
                            updatedAt = date,
                            movieId = movie.id,
                            movie = movie
                        };
                        db.Screenings.Add(screening);
                        db.SaveChanges();
                    }
                }
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

        public Movie DeleteMovie(int id)
        {
            using(var db = new CinemaContext())
            {
                Movie movie = db.Movies.SingleOrDefault(m => m.id == id);
                // TODO: handle case where movie is null

                // if screenings exist, delete screenings first
                List<Screening> screenings = db.Screenings.ToList().FindAll(s => s.movieId == id);

                screenings.ForEach(s => db.Screenings.Remove(s));
                db.SaveChanges();

                db.Remove(movie);
                db.SaveChanges();
                return movie;
            }
            return null;
        }
    }
}

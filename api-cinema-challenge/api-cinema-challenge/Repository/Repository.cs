using api_cinema_challenge.Data;
using api_cinema_challenge.DTOs.Custommer;
using api_cinema_challenge.DTOs.Movie;
using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _databaseContext;
        public Repository(CinemaContext db)
        {
            _databaseContext = db;
        }


        public async Task<IEnumerable<Custommer>> GetCustommers()
        {
            return await _databaseContext.Custommers.Include(t => t.Tickets).ToListAsync();
        }
        public async Task<Custommer> AddCustommer(InCustommerDTO newCustommer)
        {
            if (_databaseContext.Custommers.Any(c => c.Email == newCustommer.Email || c.Phone == newCustommer.Phone))
            {
                throw new Exception("This custommer already exist!");
            }

            Custommer custommer = new Custommer()
            {
                Name = newCustommer.Name,
                CreatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")),
                Email = newCustommer.Email,
                Phone = newCustommer.Phone
            };

            await _databaseContext.Custommers.AddAsync(custommer);
            await _databaseContext.SaveChangesAsync();
            return custommer;


        }

        public async Task<Custommer> UpdateCustommer(int id, InCustommerDTO newCustommer)
        {
            Custommer custommer = _databaseContext.Custommers.FirstOrDefault(c => c.Id == id);

            if (custommer == null)
            {
                throw new Exception("Not found");
            }

            else
            {
                custommer.Name = newCustommer.Name ?? custommer.Name;   // if newCustommer not null -> set else return custommer.Name
                custommer.Email = newCustommer.Email ?? custommer.Email;
                custommer.Phone = newCustommer.Phone ?? custommer.Phone;
                custommer.UpdatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"));
                await _databaseContext.SaveChangesAsync();
                return custommer;
            };
        }

        public async Task<Custommer> DeleteCustommer(int id)
        {
            Custommer custommer = _databaseContext.Custommers.FirstOrDefault(c => c.Id == id);
            if (custommer == null)
            {
                throw new Exception("Not found");
            }
            else
            {
                _databaseContext.Custommers.Remove(custommer);
                await _databaseContext.SaveChangesAsync();
                return custommer;
            };

        }

        public async Task<Movie> AddMovie(InMovieDTO newMovie)
        {
            if (_databaseContext.Movies.Any(m => m.Title == newMovie.Title))
            {
                throw new Exception("This already exist!");
            }
            else
            {
                Movie movie = new Movie()
                {
                    Title = newMovie.Title,
                    Rating = newMovie.Rating,
                    Description = newMovie.Description,
                    Runtime = newMovie.Runtime,
                    CreatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz")),

                };
                await _databaseContext.Movies.AddAsync(movie);
                await _databaseContext.SaveChangesAsync();

                if (newMovie.Screenings != null)
                {
                    // Find screening 
                    foreach (var item in newMovie.Screenings)
                    {
                        int screenNumber = _databaseContext.Screenings.FirstOrDefault(s => s.ScreenNumber == item.ScreenNumber).ScreenNumber;      //LOL, WHY?
                        // Add movie to that screen number
                        Screening newScreening = new Screening()
                        {
                            ScreenNumber = screenNumber,
                            Capacity = item.Capacity,
                            StartAt = item.StartAt,
                            MovieId = movie.Id,
                            CreatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"))
                        };

                        await _databaseContext.Screenings.AddAsync(newScreening);

                    };

                    await _databaseContext.SaveChangesAsync();
                }


                return movie;

            }
        }



        public async Task<Movie> DeleteMovie(int id)
        {

            Movie movie = _databaseContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                throw new Exception("Not found");
            }
            else
            {   // remove from movies
                _databaseContext.Movies.Remove(movie);
                // Remove screening with that movieID
                _databaseContext.Screenings.RemoveRange(_databaseContext.Screenings.Where(s => s.MovieId == movie.Id));

                await _databaseContext.SaveChangesAsync();
                return movie;
            };

        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _databaseContext.Movies.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(int id, InMovieDTO2 newMovie)
        {
            Movie movie = _databaseContext.Movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                throw new Exception("Not found");
            }

            else
            {
                movie.Title = newMovie.Title ?? movie.Title;
                movie.Description = newMovie.Description ?? movie.Description;
                movie.Runtime = newMovie.Runtime != null ? newMovie.Runtime : movie.Runtime;
                movie.Rating = newMovie.Rating ?? movie.Rating;
                movie.Description = newMovie.Description ?? movie.Description;
                movie.UpdatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"));

                await _databaseContext.SaveChangesAsync();
                return movie;
            };

        }


        // SCREENING:
        public async Task<IEnumerable<Screening>> GetScreeningMovies(int id)
        {
            List<Screening> screenings = await _databaseContext.Screenings.Where(s => s.MovieId == id).ToListAsync();

            if (screenings == null) throw new Exception("Not found");

            return screenings;
        }


        public async Task<Screening> AddScreening(int id, InScreeningDTO newScreening)
        {
            int movieID =  _databaseContext.Movies.FirstOrDefault(m => m.Id == id).Id;

            if (movieID == 0) {
                throw new Exception("Not found");
            }

           /* else if (_databaseContext.Screenings.Any(s => s.ScreenNumber != newScreening.ScreenNumber))
            {
                throw new BadHttpRequestException("Same sacreen");
            }*/

            else
            {                                                                                                                           // Add movie to that screen number
                Screening screening = new Screening()
                {
                    ScreenNumber = newScreening.ScreenNumber,
                    Capacity = newScreening.Capacity,
                    StartAt = newScreening.StartAt,
                    MovieId = movieID,
                    UpdatedAt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz"))

            };

                await _databaseContext.Screenings.AddAsync(screening);
                await _databaseContext.SaveChangesAsync();
                return screening;
            };

          
        }
            
        
    }
}

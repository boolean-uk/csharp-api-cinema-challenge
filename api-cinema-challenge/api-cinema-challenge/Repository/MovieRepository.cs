using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private DataContext _db;

        public MovieRepository(DataContext db)

        {
            _db = db;

        }

        public async Task<Movie> GetMovieById(int movieId)
        {

            var movie = await _db.Movies.FirstOrDefaultAsync(x => x.Id == movieId);
            return movie;
        }




    }


}

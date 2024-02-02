using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IMovie
    {
        private CinemaContext _db;

        public MovieRepository(CinemaContext db)
        {
            _db = db;
        }

        /// MOVIES
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.Include(a => a.Screenings).ToListAsync();
        }

        public async Task<Movie?> GetMovie(int MovieId, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {
            switch (preloadPolicy)
            {
                case PreloadPolicy.PreloadRelations:
                    return await _db.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);
                case PreloadPolicy.DoNotPreloadRelations:
                    return await _db.Movies.FirstOrDefaultAsync(s => s.Id == MovieId);
                default:
                    return null;
            }
        }

        public async Task<Movie?> DeleteMovie(int MovieId, PreloadPolicy preloadPolicy = PreloadPolicy.PreloadRelations)
        {
            var mv = await _db.Movies.Include(a => a.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);


            if (mv == null) {
                return null;
            }

            List<Screening> scr = _db.Screenings.Where(x => x.MovieId == mv.Id).ToList();

            foreach (Screening sc in scr)
            {
                _db.Screenings.Remove(sc);
            }

            _db.Movies.Remove(mv);

            return mv;
                
        }

        public async Task<Movie?> CreateMovie(string title, string rating, string description, int runtimemins)
        {
            if (title == "" || rating == "" || description == "" ||  runtimemins <= 0) return null;

            var movie = new Movie { 
                Title = title, 
                Rating = rating,
                Description = description, 
                RuntimeMins = runtimemins,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime() };

            await _db.Movies.AddAsync(movie);
            
            return movie;
        }

        public async Task<Movie?> UpdateMovie(int MovieId, string title, string rating, string description, int runtimemins, PreloadPolicy preloadPolicy = PreloadPolicy.DoNotPreloadRelations)
        {

            var mv = await _db.Movies.Include(x => x.Screenings).FirstOrDefaultAsync(s => s.Id == MovieId);

            if (mv == null)
            {
                return null;
            }

            if (title !=  null) { mv.Title = title; }

            if (rating != null) {  mv.Rating = rating; }
            
            if (description != null ) {  mv.Description = description; }

            if (runtimemins >= 0) { mv.RuntimeMins = runtimemins; }
            
            mv.UpdatedAt = DateTime.Now.ToUniversalTime();

            return mv;

        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}

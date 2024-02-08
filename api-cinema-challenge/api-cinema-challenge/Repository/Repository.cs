using api_cinema_challenge.Data;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Movie>> GetMovies()
        {
            return await _db.Movies.OrderBy(m=>m.Id).ToListAsync();
        }
        public async Task<Movie> CreateMovie(MovieInputDTO m)
        {
            Movie movie = new Movie
            {
                Id = _db.Movies.Max(x => x.Id)+1,
                CreatedAt = DateTime.Now.ToUniversalTime(),
                UpdatedAt = DateTime.Now.ToUniversalTime(),
                Title = m.Title,
                Description = m.Description,
                Rating = m.Rating,
                Runtime = m.Runtime,
            };
            _db.Movies.Add(movie);
            _db.SaveChanges();
            return movie;
        }

        public async Task<Movie> UpdateMovie(MovieInputDTO input, int id)
        {
            Movie Org = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (Org == null) { return null; }
            Org.UpdatedAt = DateTime.Now.ToUniversalTime();

            if (!string.IsNullOrEmpty(input.Title)) Org.Title = input.Title;
            if (!string.IsNullOrEmpty(input.Description)) Org.Description = input.Description;
            if (!string.IsNullOrEmpty(input.Rating)) Org.Rating = input.Rating;
            if (input.Runtime > 0) Org.Runtime = input.Runtime;
            await _db.SaveChangesAsync();
            return Org;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie Org = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);
            if (Org == null) { return null; }
            _db.Movies.Remove(Org);
            _db.SaveChanges();
            return Org;
        }
    }
}

using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        private CinemaContext _db {  get; set; }
        public MovieRepository(CinemaContext db) {
            this._db = db;
        }
        public async Task<Movie> Create(Movie entity)
        {
            
            await _db.Movies.AddAsync(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var entity = await _db.Movies.ToListAsync();
            return entity;
        }

        public async Task<Movie> Update(int id, Movie movie)
        {
            var entity = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);
            

            entity.RuntimeMins = movie.RuntimeMins;
            entity.Rating = movie.Rating;
            entity.Title = movie.Title;
            entity.Description = movie.Description;

            await _db.SaveChangesAsync();
            return entity;

        }

        async Task<Movie> IRepository<Movie>.Delete(int id)
        {
            var entity = await _db.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(entity != null)
            {
                _db.Remove(entity);
                await _db.SaveChangesAsync();
            }
            return entity;
            
        }
    }
}

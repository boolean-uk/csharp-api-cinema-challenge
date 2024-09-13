using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class MovieRepository(CinemaContext db) : IRepository<Movie>
    {
        public async Task<Movie> Add(Movie entity)
        {
            await db.Movies.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<Movie> Delete(int id)
        {
            var movie = await db.Movies.FirstOrDefaultAsync(c => c.Id == id);
            db.Movies.Remove(movie);
            await db.SaveChangesAsync();
            return movie;
        }
    

        public async Task<List<Movie>> GetAll()
        {
            return await db.Movies.ToListAsync();   
        }

        public async Task<Movie> GetById(int id)
        {
            return await db.Movies.SingleOrDefaultAsync(m => m.Id == id);
        }


        public async Task<Movie> Update(Movie entity)
        {
            var movie = await db.Movies.SingleOrDefaultAsync(c => c.Id == entity.Id);
            movie.Title = entity.Title;
            movie.Rating = entity.Rating;
            movie.Description = entity.Description; 
            movie.DurationMinutes = entity.DurationMinutes;
            movie.UpdatedAt = DateTime.UtcNow;
           
            await db.SaveChangesAsync();

            return movie;
        }

        public async Task<List<Movie>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }


    }
}

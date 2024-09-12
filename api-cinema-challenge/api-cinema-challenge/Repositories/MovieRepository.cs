using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Xml.Linq;

namespace api_cinema_challenge.Repositories
{
    internal partial class Repository : IRepository
    {
        public async Task<Movie> AddMovie(string title, string rating, string description, int runtimeMins)
        {
            var movie = new Movie() { Id = _db.Movies.Count()+1, Title = title, Rating = rating, Description = description, RuntimeMins = runtimeMins, Created = DateTime.Now, Updated = DateTime.Now };
            await _db.Movies.AddAsync(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(c => c.Id == id);
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetMovie()
        {
            return await _db.Movies.ToListAsync();
        }

        public async Task<Movie> UppdateMovie(int id, string? title, string? rating, string? description, int? runtimeMins)
        {
            var movie = await _db.Movies.FirstOrDefaultAsync(c => c.Id == id);
            if (title is not null) { movie.Title = title; movie.Updated = DateTime.Now; }
            if (rating is not null) { movie.Rating = rating; movie.Updated = DateTime.Now; }
            if (description is not null) { movie.Description = description; movie.Updated = DateTime.Now; }
            if (runtimeMins is not null && runtimeMins > 1) { movie.RuntimeMins = (int)runtimeMins; movie.Updated = DateTime.Now; }

            await _db.SaveChangesAsync();
            return movie;
        }
    }
}

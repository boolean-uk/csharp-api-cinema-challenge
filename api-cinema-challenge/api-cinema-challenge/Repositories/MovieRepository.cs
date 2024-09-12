using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories;

public class MovieRepository(CinemaContext db) : IRepository<Movie>
{
    public async Task<List<Movie>> GetAll()
    {
        return await db.Movies.ToListAsync();
    }

    public Task<Movie> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> Add(Movie entity)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> Update(Movie entity)
    {
        throw new NotImplementedException();
    }

    public Task<Movie> Delete(Movie entity)
    {
        throw new NotImplementedException();
    }
}
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;


public class MovieRepository : IMovieRepository
{
    private readonly CinemaContext _context;

    public MovieRepository(CinemaContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _context.Movies.ToListAsync();
    }

    public async Task<Movie?> GetByIdAsync(int id)
    {
        return await _context.Movies.FindAsync(id);
    }

    public async Task<Movie> CreateAsync(Movie movie)
    {
        _context.Movies.Add(movie);
        await _context.SaveChangesAsync();
        return movie;
    }

    public async Task<Movie?> UpdateAsync(int id, Movie movie)
    {
        var existingCustomer = await _context.Movies.FindAsync(id);
        if (existingCustomer == null) return null;

        existingCustomer.Title = movie.Title;
        existingCustomer.Rating = movie.Rating;
        existingCustomer.RuntimeMins = movie.RuntimeMins;
        existingCustomer.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return existingCustomer;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var customer = await _context.Customers.FindAsync(id);
        if (customer == null) return false;

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();
        return true;
    }
}

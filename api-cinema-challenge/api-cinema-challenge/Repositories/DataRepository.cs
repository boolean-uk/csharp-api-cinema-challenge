using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {
        private readonly CinemaContext _context;
        private readonly DbSet<T> _dbSet;

        public DataRepository(CinemaContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Customer))
            {
                return (IEnumerable<T>)await _context.Customers
                                                     .ToListAsync();
            }
            else if (typeof(T) == typeof(Movie))
            {
                return (IEnumerable<T>)await _context.Movies
                                                     .ToListAsync();
            }
            else if (typeof(T) == typeof(Screening))
            {
                return (IEnumerable<T>)await _context.Screenings
                                                     .ToListAsync();
            }
            else if (typeof(T) == typeof(Ticket))
            {
                return (IEnumerable<T>)await _context.Tickets
                                                     .ToListAsync();
            }
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            if (typeof(T) == typeof(Customer))
            {
                return await _context.Customers
                                     .FirstOrDefaultAsync(e => e.Id == id) as T;
            }
            else if (typeof(T) == typeof(Movie))
            {
                return await _context.Movies
                                     .FirstOrDefaultAsync(e => e.Id == id) as T;
            }
            else if (typeof(T) == typeof(Screening))
            {
                return await _context.Screenings
                                     .FirstOrDefaultAsync(e => e.Id == id) as T;
            }
            else if (typeof(T) == typeof(Ticket))
            {
                return await _context.Tickets
                                     .FirstOrDefaultAsync(e => e.Id == id) as T;
            }
            return await _dbSet.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
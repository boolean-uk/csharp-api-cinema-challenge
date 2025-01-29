using System.Linq.Expressions;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null!;

        public Repository(CinemaContext db) 
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity)
        {
            _table.Remove(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

        public async Task<IEnumerable<T>> GetAll(int? id, int? secondId)
        {
            if (typeof(T) == typeof(Screening) && id != null)
            {
                var screenings = _table as DbSet<Screening>;
                return await screenings.Where(s => s.MovieId == id).ToListAsync() as IEnumerable<T>;
            }
            else if(typeof(T) == typeof(Ticket) && id != null && secondId != null)
            {
                var tickets = _table as DbSet<Ticket>;
                return await tickets.Where(t => t.CustomerId == id && t.ScreeningId == secondId)
                    .ToListAsync() as IEnumerable<T>;
            }

            return await _table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _table.FindAsync(id);
        }

        public Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public async void Save()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return entity;
        }

    }
}

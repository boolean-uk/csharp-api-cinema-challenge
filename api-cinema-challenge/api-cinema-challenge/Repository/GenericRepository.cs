
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null!;
        public GenericRepository(CinemaContext context)
        {
            _db = context;
            _table = _db.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            var response = await _table.ToListAsync();
            return response;
        }

        public async Task<T> GetById(int id)
        {
            var response = await _table.FindAsync(id);
            return response;
        }

        public async Task<IEnumerable<T>> GetWithIncludes(Func<IQueryable<T>, IQueryable<T>> includeQuery)
        {
            IQueryable<T> query = includeQuery(_table);
            return await query.ToListAsync();
        }
        public async Task<T> GetByIdWithIncludes(Func<IQueryable<T>, T> includeQuery)
        {
            var entity = includeQuery(_table);
            return entity;
        }
        public async Task<T> Create(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _table.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Delete(T entity)
        {
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

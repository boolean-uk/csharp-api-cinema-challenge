using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _entities;

        public Repository(CinemaContext db)
        {
            _db = db;
            _entities = db.Set<T>();
        }

        public async Task<T> Create(T entity)
        {
            _entities.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _entities.Where(predicate).ToListAsync();
        }

        public async Task<T?> Delete(int id)
        {
            var entity = await Get(id);
            if (entity == null)
                return null;

            var entityCopy = _db.Entry(entity).CurrentValues.Clone().ToObject() as T;

            _entities.Remove(entity);
            await _db.SaveChangesAsync();

            return entityCopy;
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T?> Get(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<T?> Update(T entity)
        {
            _entities.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

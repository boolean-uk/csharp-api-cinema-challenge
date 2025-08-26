using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _database;
        private DbSet<T> _table = null!;

        public Repository(CinemaContext cinemaContext)
        {
            _database = cinemaContext;
            _table = _database.Set<T>();
        }

        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _database.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = await _table.FindAsync(id);
            _table.Remove(entity);
            await _database.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            T entity = await _table.FindAsync(id);
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _database.Entry(entity).State = EntityState.Modified;
            await _database.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetWithIncludes(Func<IQueryable<T>, IQueryable<T>> includeQuery)
        {
            IQueryable<T> query = includeQuery(_table);
            return await query.ToListAsync();
        }


    }
}

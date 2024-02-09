using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db; 
        private DbSet<T> _dbSet;

        public Repository(CinemaContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public async Task<T?> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T?> Delete(int id)
        {
            T? entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

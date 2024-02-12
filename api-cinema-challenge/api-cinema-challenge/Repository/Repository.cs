using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table;
        public Repository(CinemaContext context)
        {
            _db = context;
            _table = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<T> Create(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _table.FindAsync(id);
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

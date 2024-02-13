using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace workshop.wwwapi.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected CinemaContext _db;
        protected DbSet<T> _table = null;
        public Repository(CinemaContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public async Task<T> Delete(int id)
        {
            T entity = await _table.FindAsync(id);
            _table.Remove(entity);

            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetByID(object id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);

            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(object entityToUpdateId, T entity)
        {
            T existingEntity = await _table.FindAsync(entityToUpdateId);
            if (existingEntity == null)
                return null;
            
            _db.Entry(existingEntity).CurrentValues.SetValues(entity);
            await _db.SaveChangesAsync();

            return existingEntity;
        }
    }
}
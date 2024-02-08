using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T: class
    {
        private DbContext _db;
        private DbSet<T> _table;
        public Repository(DbContext db) 
        {
            _db = db;
            _table = _db.Set<T>();
        }
        public async Task<T> Create(T entity)
        {
            //entity.Id = _table.Max(x => x.Id) + 1;
            //entity.CreatedAt = DateTime.UtcNow;
            //entity.UpdatedAt = DateTime.UtcNow;

            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            
            return entity;

        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetById(object id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            //entity.UpdatedAt = DateTime.UtcNow;
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

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

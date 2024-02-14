using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Repo
{
    public class Repo<T> : IRepo<T> where T : BaseEntity
    {
        private CinemaContext _db;
        private DbSet<T> _table;
        public Repo(CinemaContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> Get(object id)
        {
            return _table.Find(id);
        }

        public async Task<T> Create(T entity)
        {
            entity.createdAt = DateTime.UtcNow;
            entity.updatedAt = DateTime.UtcNow;

            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            entity.updatedAt = DateTime.UtcNow;
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(object id)
        {
            var entity = await _table.FindAsync(id);
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        
    }
}

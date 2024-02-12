using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CinemaContext _db;
        private DbSet<T> _table = null;

        public Repository(CinemaContext db) 
        {
            this._db = db;
            this._table = _db.Set<T>();
        }       
        
        public async Task<T> GetById(int id) 
        {           
            T entity = await this._table.FindAsync(id);            
            return entity;                        
        }

        public async Task<T> Add(T entity) 
        {
            await this._table.AddAsync(entity);
            await this._db.SaveChangesAsync();            
            return entity;
        }

        public async Task<IEnumerable<T>> AddRange(IEnumerable<T> entities) 
        {
            await this._table.AddRangeAsync(entities);
            await this._db.SaveChangesAsync();
            return entities;
        }

        public async Task<List<T>> Get() 
        {
            return await this._table.ToListAsync();
        }
        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(T entity) 
        {
            this._table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> DeleteRange(IEnumerable<T> entities) 
        {
            this._table.RemoveRange(entities);
            await this._db.SaveChangesAsync();
            return entities;
        }
    }
}

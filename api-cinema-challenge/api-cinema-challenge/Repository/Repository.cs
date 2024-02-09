using Microsoft.EntityFrameworkCore;
using api_cinema_challenge.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using System.Collections;
using api_cinema_challenge.Models;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;


namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table;
        public Repository(CinemaContext db)
        {
            _db = db;
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
        public async Task<T> GetByCompositeId(int screeningId, int customerId)
        {
            return await _table.FindAsync(screeningId, customerId);

        }

        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            _db.SaveChanges();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();

            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = await _table.FindAsync(id);
            _table.Remove(entity);
            _db.SaveChanges();
            return entity;
        }

    }
}
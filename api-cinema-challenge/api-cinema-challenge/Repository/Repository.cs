using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime.Serialization;


namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _context;
        private DbSet<T> _table = null;

        public Repository(CinemaContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }
        public async Task<T> GetOne(int id)
        {
            return await _table.FindAsync(id);
        }
        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _table.Update(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(object id)
        {
            T entity = await _table.FindAsync(id);
            _table.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

    }
}

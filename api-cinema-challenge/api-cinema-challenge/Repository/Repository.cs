using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null!;
        public Repository(CinemaContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(object id)
        {
            T entity = await _table.FindAsync(id);
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetById(int id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _table;
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return await query.ToListAsync();
        }

        public async Task<T> GetByIdWithIncludes(int id, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _table;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
        }

        public async Task<IEnumerable<T>> GetWithCustomIncludes(Func<IQueryable<T>, IQueryable<T>> includeQuery)
        {
            IQueryable<T> query = includeQuery(_table);
            return await query.ToListAsync();
        }
        public async Task<T> GetByIdWithCustomIncludes(int id, Func<IQueryable<T>, IQueryable<T>> includeQuery)
        {
            IQueryable<T> query = includeQuery(_table);
            return await query.FirstOrDefaultAsync(e => EF.Property<int>(e, "Id") == id);
        }
    }
}

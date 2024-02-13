using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null;

        public Repository(CinemaContext dataContext)
        {
            _db = dataContext;
            _table = _db.Set<T>();
        }

        public async Task<T> Delete(int id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;

        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> Create(T entity)
        {
            foreach (var property in typeof(T).GetProperties())
            {
                if (property.PropertyType.IsClass && property.GetGetMethod() != null)
                {
                    _db.Entry(entity).Reference(property.Name).Load();
                }
            }
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Create(T entity, params Expression<Func<T, object>>[] includes)
        {
            foreach (var include in includes)
            {
                _db.Entry(entity).State = EntityState.Modified;
                _db.Entry(entity).Reference(include).Load();
            }

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
            T entity = _table.Find(id);
            _table.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetById(object id)
        {
            return await _table.FindAsync(id);
        }
    }
}
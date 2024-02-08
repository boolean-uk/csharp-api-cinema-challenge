using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null;

        public Repository(CinemaContext cinemaContext)
        {
            _db = cinemaContext;
            _table = _db.Set<T>();
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await _table.ToListAsync();
        }
        public async Task<T> Create(T entity)
        {
            await _table.AddAsync(entity);
            Save();
            return entity;
        }
        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
            Save();
            return entity;
        }

        public async void Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}

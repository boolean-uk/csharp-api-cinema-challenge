
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _db;
        private DbSet<T> _table = null;
        public Repository(CinemaContext dbContext) {
            _db = dbContext;
            _table = _db.Set<T>();
        }

        public async Task<T> DeleteById(int id)
        {
            T entity = _table.Find(id);
            _table.Remove(entity);
            _db.SaveChanges();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return _table.Find(id);
        }

        public async Task<T> Insert(T entity)
        {
            await _table.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public void Save()
        {
            _db.SaveChangesAsync();
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<Screening>> GetScreeningsByMovieId(int id)
        {
            var screenings = await _db.Screenings.Where(s => s.MovieId == id).ToListAsync();
            return screenings;
        }
    }
}

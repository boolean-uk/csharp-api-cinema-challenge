using System.Linq.Expressions;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

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

        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll(int? id)
        {
            if (typeof(T) == typeof(Screening) && id != null)
            {
                var screenings = _table as DbSet<Screening>;
                return await screenings.Where(s => s.Movie_Id == id).ToListAsync() as IEnumerable<T>;
            }
            return await _table.ToListAsync();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

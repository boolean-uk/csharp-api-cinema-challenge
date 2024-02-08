using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T: BaseEntity
    {
        private DbContext _db;
        public Repository(DbContext db) 
        {
            _db = db;
        }
        public async Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

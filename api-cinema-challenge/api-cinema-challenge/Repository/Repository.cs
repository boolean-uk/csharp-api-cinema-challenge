using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private CinemaContext _database;
        private DbSet<T> _dbSet;

        public Repository(CinemaContext database)
        {
            _database = database;
            _dbSet = _database.Set<T>();
        }
        public async Task Create(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> ReadAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

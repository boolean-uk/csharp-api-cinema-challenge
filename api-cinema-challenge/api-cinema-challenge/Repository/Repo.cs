using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class Repo<T> : IRepository<T> where T : DbEntity
    {
        protected readonly CinemaContext _db;
        public Repo(CinemaContext db)
        {
            _db = db;
        }

        public async Task<T> Create(T newobj)
        {
            T added = _db.Add(newobj).Entity;
            await _db.SaveChangesAsync();
            return added;
        }

        public async Task<T> Delete(int id)
        {
            T delObj = await this.GetById(id);
            _db.Remove(delObj);
            await _db.SaveChangesAsync();
            return delObj;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public async Task<T> Update(T upObj, int id)
        {
            T upd = await this.GetById(id);
            _db.Update(upd);
            upd = upObj;
            await _db.SaveChangesAsync();
            return upd;
        }

        public async Task<IEnumerable<T>> GetAllWithIncludes(Expression<Func<T, object>> func)
        {
            return await _db.Set<T>().Include(func).ToListAsync();
        }

        public async Task<T> GetByIdWithIncludes(Expression<Func<T, object>> func, int id) 
        {
            return await _db.Set<T>().Include(func).Where(t => t.Id == id).FirstOrDefaultAsync();
        }
    }
}


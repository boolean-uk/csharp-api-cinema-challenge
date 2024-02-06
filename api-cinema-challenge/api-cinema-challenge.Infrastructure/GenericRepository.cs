using api_cinema_challenge.Application.Models;
using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Infrastructure
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly CinemaContext _context;
        public GenericRepository(CinemaContext cinemaContext)
        {
            _context = cinemaContext;
        }

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteById(int id)
        {
            T entity = await GetById(id);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            T entity = await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id)
                ?? throw new ArgumentException($"No {nameof(T).ToLower()} with id '{id}'");
            return entity;
        }

        public async Task<T> UpdateById(T entity, int id)
        {
            T dbEntity = await GetById(id);
            dbEntity = entity;
            _context.Update(dbEntity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

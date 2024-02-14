using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Repository.Generic
{
    public class JunctionRepository<T> : IJunctionRepository<T> where T : class
    {
        private DatabaseContext db;
        private DbSet<T> table = null;

        public JunctionRepository(DatabaseContext databaseContext)
        {
            db = databaseContext;
            table = db.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<IEnumerable<T>> Insert(IEnumerable<T> entities)
        {
            await table.AddRangeAsync(entities);
            await db.SaveChangesAsync();
            return entities;
        }

        public async Task<T> Update(T entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return entity;
        }
    }
}

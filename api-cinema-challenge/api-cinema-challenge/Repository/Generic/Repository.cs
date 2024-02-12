using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace api_cinema_challenge.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private DatabaseContext db;
        private DbSet<T> table = null;

        public Repository(DatabaseContext databaseContext)
        {
            db = databaseContext;
            table = db.Set<T>();
        }

        public async Task<T?> DeleteById(object id)
        {
            T? entity = await table.FindAsync(id);
            if (entity == null) return null;
            table.Remove(entity);
            await db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<T?> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public async Task<T> Insert(T entity)
        {
            await table.AddAsync(entity);
            await db.SaveChangesAsync();
            return entity;
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

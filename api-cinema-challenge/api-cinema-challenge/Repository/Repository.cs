using api_cinema_challenge.Data;
using Microsoft.EntityFrameworkCore;


namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private CinemaContext _databaseContext;
        private DbSet<T> _table = null!;

        public Repository(CinemaContext db)
        {
            _databaseContext = db;
            _table = db.Set<T>();
        }

        public async Task<IEnumerable<T>> GetEntries(params Func<IQueryable<T>, IQueryable<T>>[] includes)
        {
            IQueryable<T> q = _table.AsQueryable();

            foreach (var inc in includes)
                q = inc.Invoke(q);

            return await q.ToArrayAsync();
        }

        public async Task<T?> GetEntry(Func<IQueryable<T>, IQueryable<T>> id, params Func<IQueryable<T>, IQueryable<T>>[] expressions)
        {
            IQueryable<T> q = _table.AsQueryable();

            q = id.Invoke(q);
            foreach (var ex in expressions)
            {
                q = ex.Invoke(q);
            }

            return await q.FirstOrDefaultAsync();
        }
        public async Task<T?> CreateEntry(T entry)
        {
            var a = await _table.AddAsync(entry);
            await _databaseContext.SaveChangesAsync();
            return entry;
        }
        public async Task<T?> UpdateEntry(Func<IQueryable<T>, IQueryable<T>> id, T entry)
        {
            IQueryable<T> q = _table.AsQueryable();
            q = id.Invoke(q);
            var foundEntry = await q.FirstOrDefaultAsync();

            if (foundEntry == null) return null;
            _table.Remove(foundEntry);
            await _table.AddAsync(entry);            

            await _databaseContext.SaveChangesAsync();
            return await  id.Invoke(q).FirstAsync();
        }
        public async Task<T?> DeleteEntry(Func<IQueryable<T>, IQueryable<T>> id)
        {
            IQueryable<T> q = _table.AsQueryable();
            q = id.Invoke(q);
            var foundEntry = await q.FirstOrDefaultAsync();

            if (foundEntry == null) return null;
            _table.Remove(foundEntry);
           await _databaseContext.SaveChangesAsync();
            return foundEntry;
        }



    }
}

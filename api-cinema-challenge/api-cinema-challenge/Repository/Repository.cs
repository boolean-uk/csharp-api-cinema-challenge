namespace api_cinema_challenge.Repository
{
    using api_cinema_challenge.Data;
 
    using Microsoft.EntityFrameworkCore;
    using System.Collections;
    using System.Reflection;

    namespace exercise.pizzashopapi.Repository
    {
        public class Repository<T> : IRepository<T> where T : class
        {

            private readonly CinemaContext _context;
            private readonly DbSet<T> _dbSet;

            public Repository(CinemaContext context)
            {
                _context = context;
                _dbSet = context.Set<T>(); ;
            }

            public async Task<IEnumerable<T>> getAllWithIncludes()
            {
                IQueryable<T> query = _dbSet.AsQueryable();

                foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if ((typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string)) ||
                        (property.PropertyType.IsClass && property.PropertyType != typeof(string)))
                    {
                        query = query.Include(property.Name);
                    }
                }

                return await query.ToListAsync();
            }


            public async Task<T> getByIdWithIncludes(int id)
            {
                IQueryable<T> query = _dbSet.AsQueryable();

                foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if ((typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string)) ||
                        (property.PropertyType.IsClass && property.PropertyType != typeof(string)))
                    {
                        query = query.Include(property.Name);
                    }
                }

                var entity = await query.FirstOrDefaultAsync(e => EF.Property<object>(e, "Id").Equals(id));

                return entity;
            }
            public async Task<T> Add(T entity)
            {

                _dbSet.Add(entity);
                _context.SaveChanges();
                return entity;
            }

            public async Task<T> Delete(int id)
            {
                var entity = _dbSet.Find(id);
                if (entity == null)
                {
                    return null;
                }
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return entity;
            }



            public async Task<IEnumerable<T>> getAll()
            {
                return await _dbSet.ToListAsync();
            }

            public async Task<T> getbyId(int id)
            {
                if (id == null)
                {
                    return null;
                }

                return await _dbSet.FindAsync(id);
            }

            public async Task<T> Update(T entity)
            {
                if (entity == null)
                {
                    return null;
                }

                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return entity;
            }

            public async Task<IEnumerable<T>> GetByForeignKey(string foreignKeyName, object foreignKeyValue)
            {
                IQueryable<T> query = _dbSet.AsQueryable();

                foreach (var property in typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    if ((typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string)) ||
                        (property.PropertyType.IsClass && property.PropertyType != typeof(string)))
                    {
                        query = query.Include(property.Name);
                    }
                }

                query = query.Where(e => EF.Property<object>(e, foreignKeyName).Equals(foreignKeyValue));

                return await query.ToListAsync();
            }
        }
    }

}

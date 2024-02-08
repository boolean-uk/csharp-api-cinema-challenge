
using api_cinema_challenge.Data;
using api_cinema_challenge.Models.PureModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DataContext _db;
        private DbSet<T> _table_T = null;

        public Repository(DataContext db)
        {
            _db = db;
            _table_T = _db.Set<T>();
        }

        /// <inheritdoc/>
        public async Task<T?> Get(int id)
        {
            return await _table_T.FindAsync(id);
        }

        /// <inheritdoc/>
        public async Task<T?> GetIncluding(int id, string keyName, params Expression<Func<T, object>>[] includes) 
        {
            IQueryable<T> query = _table_T;

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.FirstOrDefaultAsync(entity => EF.Property<int>(entity, keyName) == id);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _table_T.AsNoTracking().ToListAsync();
        }

        /// <inheritdoc/>
        /// <remarks> Currently does not implement choice/input params</remarks>
        public async Task<IEnumerable<T>> GetAllIncluding()
        {
            IQueryable<T> query = _table_T.AsNoTracking();

            if (typeof(T) == typeof(Movie))
            {
                query = query
                    .Include(m => (m as Movie).Screenings)
                        .ThenInclude(s => (s as Screening).Tickets);
            }
            else if (typeof(T) == typeof(Screening))
            {
                query = query
                    .Include(s => (s as Screening).Tickets)
                    .Include(s => (s as Screening).Movie);
            }
            else if (typeof(T) == typeof(Customer)) 
            {
                query = query
                    .Include(c => (c as Customer).Tickets)
                        .ThenInclude(t => (t as Ticket).Screening)
                            .ThenInclude(s => s.Movie)
                    .Include(c => (c as Customer).Tickets)
                        .ThenInclude(t => (t as Ticket).Screening);
            }
            else if (typeof(T) == typeof(Ticket))
            {
                query = query
                    .Include(t => (t as Ticket).Screening)
                        .ThenInclude(s => s.Movie);
            } 
            else if(typeof(T) == typeof(Display)) 
            {
                query = query
                    .Include(d => (d as Display).Screenings)
                        .IgnoreAutoIncludes();
            }

            return await query.ToListAsync();
        }

        /// <summary>
        /// Method thats allows for chaining of a .ThenInclude onto a IQueryable<T> object. Potentially useful for future .ThenInclude methods
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"> The IQueryable object before inclusion of the ThenInclude </param>
        /// <param name="navigationPropertyPath"> ThenInclude lambda expression to be added</param>
        /// <returns> The result IQueryable object </returns>
        private static IQueryable<T> ThenInclude<T>(IQueryable<T> source, Expression<Func<T, object>> navigationPropertyPath)
        {
            var thenIncludeMethodInfo = typeof(EntityFrameworkQueryableExtensions)
                .GetMethods()
                .FirstOrDefault(m => m.Name == "ThenInclude" && m.GetParameters().Length == 2);

            if (thenIncludeMethodInfo != null)
            {
                var genericThenInclude = thenIncludeMethodInfo.MakeGenericMethod(typeof(T), navigationPropertyPath.ReturnType);
                return (IQueryable<T>)genericThenInclude.Invoke(null, new object[] { source, navigationPropertyPath });
            }

            return source;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<T>> GetAllIncluding(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _table_T.AsNoTracking();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<T> Insert(T entity)
        {
            var addedEntity = _table_T.Add(entity);
            await _db.SaveChangesAsync();
            return addedEntity.Entity;
        }

        /// <inheritdoc/>
        public async Task<T> Update(int id, T entity)
        {
            var dbEntity = await _table_T.FindAsync(id);
            // Update values of the dbEntity
            _db.Entry(dbEntity).CurrentValues.SetValues(entity);
            await _db.SaveChangesAsync(); // Save changes
            return dbEntity;
        }

        /// <inheritdoc/>
        public async Task<T> Delete(int id)
        {
            T? entityToDelete = await _table_T.FindAsync(id);
            _table_T.Remove(entityToDelete);
            await _db.SaveChangesAsync();
            return entityToDelete;
        }

        /// <inheritdoc/>
        public async Task<T> Delete(T entity)
        {
            _table_T.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

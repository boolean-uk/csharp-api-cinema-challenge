using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> GetAll();

        /// <summary>
        /// Pass through tuples of function expressions that allow for the use of the generic repository while still using .Include and .ThenInclude 
        /// </summary>
        /// <param name="includes">Tuple of expressions, first value is the include that defines .Include, second value defines the .ThenInclude properties.
        /// Example of Include(Roles) and ThenInclude(Permissions) -> (u => u.Roles, r => r.Permissions),
        /// Example of Include(Property) but no ThenInclude (u => u.Property, null)
        /// </param>
        /// <returns>IEnumerable of entities</returns>
        Task<IEnumerable<T>> GetAllIncluding((Expression<Func<T, object>> include, Expression<Func<object, object>> thenInclude)[] includes);

        Task<T?> Get(int id);

        Task<T> Insert(T entity);

        Task<T> Update(int id, T entity);

        Task<T> Delete(int id);

        Task<T> Delete(T entity);

    }
}

using System.Linq.Expressions;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> Get();
        Task<T?> Get(int id);
        Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
        Task<T> Create(T entity);
        Task<T?> Update(T entity);
        Task<T?> Delete(int id);
    }
}

using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> filter);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T?> Delete(object id);
        Task<T?> GetById(int id);
        Task<T?> GetById(int id1, int id2, Func<IQueryable<T>, IQueryable<T>> includeQuery);
        Task<T?> GetById(int id, Func<IQueryable<T>, IQueryable<T>> includeQuery);
        Task<IEnumerable<T>> GetWithIncludes(Func<IQueryable<T>, IQueryable<T>> includeQuery);
    }
}

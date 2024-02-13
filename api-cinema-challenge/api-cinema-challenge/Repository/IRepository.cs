using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<T> Create(T entity);
        Task<T> Create(T entity, params Expression<Func<T, object>>[] includes);
        Task<IEnumerable<T>> Get();
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<T> GetById(object id);
    }
}
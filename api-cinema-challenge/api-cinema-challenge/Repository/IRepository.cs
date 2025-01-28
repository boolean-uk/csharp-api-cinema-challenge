using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(object id);
        Task Save();
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes);
    }
}

using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> GetOne(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(object id);
    }
}

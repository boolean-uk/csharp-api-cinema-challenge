using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll(int? id);
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(object id);
        Task Save();
        Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes);
    }
}

using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll(int? id, int? scondId);
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        void Save();
        Task<IEnumerable<T>> GetWithIncludes(params Expression<Func<T, object>>[] includes);
    }
}

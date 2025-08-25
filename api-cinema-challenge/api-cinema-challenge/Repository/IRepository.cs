using api_cinema_challenge.Models;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);

        Task<T> Create(T newObj);

        Task<T> Delete(int id);

        Task<T> Update(T upObj, int id);

        Task<IEnumerable<T>> GetAllWithIncludes(Expression<Func<T, object>> func);

        Task<T> GetByIdWithIncludes(Expression<Func<T, object>> func, int id);
    }
}

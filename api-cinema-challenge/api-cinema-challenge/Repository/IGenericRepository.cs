using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace api_cinema_challenge.Repository
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetWithIncludes(Func<IQueryable<T>, IQueryable<T>> includes);
        Task<T> GetByIdWithIncludes(Func<IQueryable<T>, T> includeQuery);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}

using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<T> Create(T entity);
        Task<T> GetById(object id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}

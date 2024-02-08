using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Insert(T entity);
        Task<Payload<IEnumerable<T>>> GetAll();
        Task<T> Update(T entity);
        Task<T> DeleteById(int id);
        Task<T> GetById(int id);
        void Save();
    }
}

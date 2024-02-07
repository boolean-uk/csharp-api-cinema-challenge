using api_cinema_challenge.Application.Models;

namespace api_cinema_challenge.Infrastructure
{
    public interface IRepository<T> where T : IEntity
    {
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
        Task<T> UpdateById(T entity, int id);
        Task<T> DeleteById(int id);
        Task<T> Add(T entity);
    }
}

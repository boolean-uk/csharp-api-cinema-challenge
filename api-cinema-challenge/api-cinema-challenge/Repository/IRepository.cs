using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> 
    {
        Task<T> CreateEntity(T entity);
        Task<T> DeleteEntity(int id);
        Task<List<T>> GetAllEntities();
        Task<T> UpdateEntity(T entity, int searchId);
    }
}

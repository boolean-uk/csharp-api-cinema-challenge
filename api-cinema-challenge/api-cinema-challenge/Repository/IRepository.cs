namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<T?> Get(int id);
        Task<ICollection<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T?> Delete(int id);
    }
}

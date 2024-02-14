namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetById(object id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        Task<T?> DeleteById(object id);
    }
}

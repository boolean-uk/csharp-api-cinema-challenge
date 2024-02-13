namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<T> Create(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<T> GetById(object id);
    }
}
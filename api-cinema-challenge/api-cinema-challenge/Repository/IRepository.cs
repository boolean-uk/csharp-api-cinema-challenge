namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}

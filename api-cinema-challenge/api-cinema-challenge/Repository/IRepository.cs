namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<IEnumerable<T>> AddRange(IEnumerable<T> entities);
        Task<List<T>> Get();
        Task<T> GetById(int id);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
        Task<IEnumerable<T>> DeleteRange(IEnumerable<T> entities);
    }
}

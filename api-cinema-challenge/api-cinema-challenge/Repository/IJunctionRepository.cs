namespace api_cinema_challenge.Repository
{
    public interface IJunctionRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Insert(IEnumerable<T> entities);
        Task<T> Update(T entity);
    }
}

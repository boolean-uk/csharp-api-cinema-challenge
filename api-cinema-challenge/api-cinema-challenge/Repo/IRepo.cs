namespace api_cinema_challenge.Repo
{
    public interface IRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(object id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(object id);
        
    }
}

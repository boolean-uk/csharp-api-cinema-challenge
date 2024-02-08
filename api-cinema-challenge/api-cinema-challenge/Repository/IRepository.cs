namespace api_cinema_challenge.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        void Save();

    }
}

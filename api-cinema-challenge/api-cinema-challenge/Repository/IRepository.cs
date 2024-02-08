namespace api_cinema_challenge.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(object id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        void Save();
    }
}

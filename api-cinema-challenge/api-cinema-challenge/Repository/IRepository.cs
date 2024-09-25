namespace api_cinema_challenge.Repository
{ 
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Create(T entity);
        public Task<T> Delete(int id);
        public Task<T> Update(int id, T entity);

    }
}

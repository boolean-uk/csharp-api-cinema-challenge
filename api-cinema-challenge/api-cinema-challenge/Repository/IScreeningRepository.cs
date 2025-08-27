public interface IScreeningRepository
{
    Task<IEnumerable<Screening>> GetAllAsync();
    Task<Screening> CreateAsync(Screening screening);
}

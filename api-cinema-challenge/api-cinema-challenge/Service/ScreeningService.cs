using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Service
{
    public class ScreeningService
    {
        public IScreening repository;
        public ScreeningService(CinemaContext db, IScreening repository)
        {
            this.repository = repository;
        }

        public Task<Screening> Create(ScreeningPayload payload, int movieId)
        {

            Screening screening = new Screening()
            {
                Capacity = payload.Capacity,
                StartsAt = payload.StartsAt,
                ScreenNumber = payload.ScreenNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Movieid = movieId
            };
            return repository.Create(screening);
        }

        public Task<IEnumerable<Screening>> GetAll(int movieId)
        {
            return repository.GetAll(movieId);
        }
    }
}

using api_cinema_challenge.Models;

namespace api_cinema_challenge.Repository;
    public interface IScreeningRepository
    {
        public Task<IEnumerable<Screening>> GetAllScreenings();

        public Task<Screening?> GetScreeningById(int id);
        public Task<Screening?> CreateScreening(int movie_id, int screen_number, int capacity, DateTime startsAt);

    }
using api_cinema_challange.Models;

namespace api_cinema_challange.Repository;
    public interface IScreeningRepository
    {
        public Task<IEnumerable<Screening>> GetAllScreenings();

    public Task<Screening?> CreateScreening(int movie_id, int screen_number, int capacity, DateTime startsAt);

    }
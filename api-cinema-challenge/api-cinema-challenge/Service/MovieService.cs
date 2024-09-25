using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Service
{
    public class MovieService
    {
        public IRepository<Movie> repository;
        public ScreeningService screeningService;

        public MovieService(CinemaContext db, IRepository<Movie> repository, ScreeningService screeningService)
        {
            this.repository = repository;
            this.screeningService = screeningService;
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
            return repository.GetAll();
        }

        public async Task<Movie> Create(MoviePayload payload)
        {
            Movie movie = new Movie()
            {
                Title = payload.Title,
                RuntimeMins = payload.runtimeMins,
                Description = payload.Description,
                Rating = payload.Rating,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            Movie movie1 = await repository.Create(movie);

            if (payload.Screenings != null)
            {
                foreach (ScreeningPayload sp in payload.Screenings)
                {
                    ScreeningPayload screening = new ScreeningPayload()
                    {
                        Capacity = sp.Capacity,
                        StartsAt = sp.StartsAt,
                        ScreenNumber = sp.ScreenNumber
                    };
                    await screeningService.Create(screening, movie1.Id);
                }
            }
                    
            return movie1;
        }

        public async Task<Movie> Update(MoviePayload payload, int id)
        {
            Movie movie = new Movie()
            {
                Title = payload.Title,
                RuntimeMins = payload.runtimeMins,
                Description = payload.Description,
                Rating = payload.Rating,
                UpdatedAt = DateTime.UtcNow
            };

            return await repository.Update(id, movie);

        }

        public async Task<Movie> Delete(int id)
        {
            return await repository.Delete(id);
        }


    }
}

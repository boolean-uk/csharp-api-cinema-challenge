using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Utilities;

namespace api_cinema_challenge.Endpoints
{
    public class Services
    {
        public static async Task<ScreeningOutputDTO> CreateScreening(
        IRepository<Screening> screeningRepository,
        IRepository<Auditorium> auditoriumRepository,
        IJunctionRepository<ScreeningSeat> screeeningSeatRepository,
        int movieId,
        ScreeningInputDTO input)
        {
            Auditorium? auditorium = await auditoriumRepository.GetById(input.ScreenNumber);
            ScreeningCreator screeningCreator = new ScreeningCreator(movieId, auditorium, input.Capacity, input.StartsAt);
            Screening screeningResult = await screeningRepository.Insert(screeningCreator.GetScreening());
            IEnumerable<ScreeningSeat> screeningSeatsResult = await screeeningSeatRepository.Insert(screeningCreator.GetScreeningSeats(screeningResult.Id));
            return new ScreeningOutputDTO(screeningResult, auditorium.Id, screeningSeatsResult.Count());
        }
    }
}

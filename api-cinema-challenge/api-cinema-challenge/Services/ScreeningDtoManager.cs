using api_cinema_challenge.Models.ScreeningModels;

namespace api_cinema_challenge.Services
{
    public static class ScreeningDtoManager
    {
        public static Screening Convert(InputScreening inputScreening)
        {
            return new Screening
            {
                StartsAt = inputScreening.StartsAt,
                ScreenNumber = inputScreening.ScreenNumber,
                Capacity = inputScreening.Capacity,
            };
        }

        public static OutputScreening Convert(Screening screening)
        {
            return new OutputScreening
            {
                Id = screening.Id,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt,
                StartsAt = screening.StartsAt,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
            };
        }

        public static IEnumerable<OutputScreening> Convert(IEnumerable<Screening> screenings)
        {
            return screenings.Select(Convert);
        }
    }
}

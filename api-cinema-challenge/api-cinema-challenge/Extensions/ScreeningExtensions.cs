using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.ViewModels;

namespace api_cinema_challenge.Extensions
{
    public static class ScreeningExtensions
    {
        public static ScreeningDTO ToScreeningDTO(this Screening screening) 
        {
            return new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt,
            };
        }

        public static Screening ToScreening(this ScreeningPostModel screeningPost, int movieId)
        {
            return new Screening
            {
                MovieId = movieId,
                ScreenNumber = screeningPost.ScreenNumber,
                Capacity = screeningPost.Capacity,
                StartsAt = DateTime.Parse(screeningPost.StartsAt).ToUniversalTime(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}

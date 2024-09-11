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

        public static Screening ToScreening(this ScreeningPostModel screeningPost)
        {
            return new Screening
            {
                MovieId = screeningPost.MovieId,
                ScreenNumber = screeningPost.ScreenNumber,
                Capacity = screeningPost.Capacity,
                StartsAt = screeningPost.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}

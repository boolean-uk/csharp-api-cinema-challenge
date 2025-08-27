using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public static class ScreeningFactory
    {
        public static ScreeningGet NewScreeningGet(Screening item)
        {
            if (item == null) return null;

            return new ScreeningGet()
            {
                Id = item.Id,
                ScreenNumber = item.ScreenNumber,
                Capacity = item.Capacity,
                StartsAt = item.StartsAt,
                CreatedAt = item.CreatedAt,
                UpdatedAt = item.UpdatedAt,
            };
        }

        public static Screening NewScreening(int movieId, ScreeningPost item)
        {
            if (item == null) return null;
            return new Screening()
            {
                MovieId = movieId,
                ScreenNumber = item.ScreenNumber,
                Capacity = item.Capacity,
                StartsAt = item.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
        }
    }
}

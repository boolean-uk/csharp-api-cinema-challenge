namespace api_cinema_challenge.Models.Screening
{
    public static class ScreeningMapper
    {
        public static ScreeningDTO MapToDTO(this Screening screening)
        {
            return new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                createdAt = screening.createdAt,
                updatedAt = screening.updatedAt,
            };
        }

        public static List<ScreeningDTO> MapToDTO(this List<Screening> screenings)
        {
            return screenings.Select(screening => new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                createdAt = screening.createdAt,
                updatedAt = screening.updatedAt,
            }).ToList();


        }
    }
}

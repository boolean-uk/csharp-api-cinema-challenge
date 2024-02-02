namespace api_cinema_challenge.Models.DTOS
{
    public record ScreeningToMovieDTO
    {
        public int Id { get; set; }

        public int ScreenId { get; set; }

        public int RemaningCapacity { get; set; }

        public float Price { get; init; }

        public string StartsAt { get; set; }

        public string CreatedAt { get; set; }

        public string updatedAt { get; set; }

        public ScreeningToMovieDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenId = screening.ScreenId;
            RemaningCapacity = screening.RemaningCapacity;
            Price = screening.Price;

            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            StartsAt = screening.StartsAt.ToString(datePattern);
            CreatedAt = screening.CreatedAt.ToString(datePattern);
            updatedAt = screening.UpdatedAt.ToString(datePattern);
        }

    }
}
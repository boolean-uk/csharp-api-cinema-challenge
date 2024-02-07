namespace api_cinema_challenge.Models.DTOS
{
    public record ScreeningDTO
    {
        public int Id { get; set; }

        public int ScreenId { get; set; }

        public int MovieId { get; set; }

        public int RemaningCapacity { get; set; }

        public float Price { get; init; }

        public string StartsAt { get; set; }

        public string CreatedAt { get; set; }

        public string updatedAt { get; set; }

        public ScreeningDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenId = screening.ScreenId;
            MovieId = screening.MovieId;
            RemaningCapacity = screening.RemaningCapacity;
            Price = screening.Price;

            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            StartsAt = screening.StartsAt.ToString(datePattern);
            CreatedAt = screening.CreatedAt.ToString(datePattern);
            updatedAt = screening.UpdatedAt.ToString(datePattern);
        }

    }
}
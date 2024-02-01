namespace api_cinema_challenge.Models.DTOS
{
    public record ScreeningDTO
    {
        public int Id { get; set; }

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public string StartsAt { get; set; }

        public string CreatedAt { get; init; }

        public string updatedAt { get; set; }

        public ScreeningDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            StartsAt = screening.StartsAt.ToString(datePattern);
            CreatedAt = screening.CreatedAt.ToString(datePattern);
            updatedAt = screening.UpdatedAt.ToString(datePattern);
        }

    }
}
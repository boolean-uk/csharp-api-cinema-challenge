namespace api_cinema_challenge.Models.DTO.ScreeningDTOs
{
    public class CreateScreeningDTO
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}

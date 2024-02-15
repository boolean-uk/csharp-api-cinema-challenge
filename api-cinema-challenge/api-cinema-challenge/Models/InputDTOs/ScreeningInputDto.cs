namespace api_cinema_challenge.Models.InputDTOs
{
    public class ScreeningInputDto
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}

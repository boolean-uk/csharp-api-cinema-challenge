namespace api_cinema_challenge.Models.DTOs.Screening
{
    public class ScreeningResponseDTO
    {
        public string Status { get; set; } = "success";
        public ScreeningDTO? Data { get; set; }
    }
}

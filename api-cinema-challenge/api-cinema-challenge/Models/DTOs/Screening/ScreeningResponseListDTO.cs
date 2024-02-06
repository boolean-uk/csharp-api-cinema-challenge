namespace api_cinema_challenge.Models.DTOs.Screening
{
    public class ScreeningResponseListDTO
    {
        public string Status { get; set; } = "success";
        public ICollection<ScreeningDTO>? Data { get; set; }
    }
}

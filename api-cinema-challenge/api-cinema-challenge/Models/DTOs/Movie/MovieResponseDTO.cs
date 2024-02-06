namespace api_cinema_challenge.Models.DTOs.Movie
{
    public class MovieResponseDTO
    {
        public string Status { get; set; } = "success";
        public MovieDTO? Data { get; set; }
    }
}

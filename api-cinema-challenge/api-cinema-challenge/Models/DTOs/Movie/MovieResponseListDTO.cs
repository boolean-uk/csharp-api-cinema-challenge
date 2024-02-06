namespace api_cinema_challenge.Models.DTOs.Movie
{
    public class MovieResponseListDTO
    {
        public string Status { get; set; } = "success";
        public ICollection<MovieDTO>? Data { get; set; }
    }
}

namespace api_cinema_challenge.Models.DTOs
{
    public class MovieResponseListDTO
    {
        public string Status { get; set; }
        public ICollection<MovieDTO> Data { get; set; } = new List<MovieDTO>();
    }
}

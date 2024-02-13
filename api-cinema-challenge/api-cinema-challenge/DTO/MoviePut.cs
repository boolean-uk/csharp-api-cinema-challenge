using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MoviePut
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Length { get; set; }
    }
}

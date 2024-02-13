using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class MovieDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Length { get; set; }
        public MovieDto(Movie movie)
        {
            Name = movie.MovieName;
            Desc = movie.MovieDesc;
            Length = movie.MovieLength;
        }

        public MovieDto()
        {
            
        }
    }
}

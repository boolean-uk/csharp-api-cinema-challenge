using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {
    public class MovieScreeningDTO : MovieDTO
    {
        List<ScreeningBaseDTO> Screening {get; set;}


        public MovieScreeningDTO(Movie movie) : base(movie) 
        {
            Screening = ScreeningBaseDTO.FromRepository(movie.Screenings);
        }
    }
}
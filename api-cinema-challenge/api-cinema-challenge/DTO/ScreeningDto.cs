using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDto
    {
        public DateTime StartTime { get; set; }
        public MovieDto Movie { get; set; }
        public HallDto Hall { get; set; }

        public ScreeningDto(Screening screening)
        {
            if(screening == null)
            {
                StartTime = DateTime.MinValue;
                Movie = null;
                Hall = null;
            }else
            {
                StartTime = screening.StartTime;
                Movie = new MovieDto(screening.Movie);
                Hall = new HallDto(screening.Hall);
            }
            
        }
        public ScreeningDto()
        {
             
        }
    }
}

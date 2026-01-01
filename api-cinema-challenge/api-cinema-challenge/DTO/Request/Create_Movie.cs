using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Movie : IDTO_Request_create<Create_Movie, Movie>
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<Create_Screening> Screenings { get; set; }

        public static Movie create(Create_Movie dto, params object[] pathargs)
        {
            return new Movie
            {
                Title = dto.Title,
                Rating = dto.Rating,
                Description = dto.Description,
                RuntimeMins = dto.RuntimeMins
            };
        }
        public static List<Screening> create_screenings(Create_Movie dto, int movieId)
        {
            return dto.Screenings.Select(
                x => Create_Screening.create(x, movieId)).ToList();

        }
    }
}

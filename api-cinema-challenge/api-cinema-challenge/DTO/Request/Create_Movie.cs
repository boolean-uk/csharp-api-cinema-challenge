using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Movie : IDTO_Request_create<Create_Movie, Movies>
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<Create_Screening> Screenings { get; set; }

        public static Movies create(Create_Movie dto, params object[] pathargs)
        {
            return new Movies
            {
                Title = dto.Title,
                Rating = dto.Rating,
                Description = dto.Description,
                RuntimeMins = dto.RuntimeMins
            };
        }
        public static List<Screenings> create_screenings(Create_Movie dto, int movieId)
        {
            return dto.Screenings.Select(
                x => Create_Screening.create(x)).ToList();
            //,
            //    x => new Screenings
            //{
            //    MovieId = movieId,
            //    ScreenNumber = x.ScreenNumber,
            //    Capacity = x.Capacity,
            //    StartsAt = x.StartsAt,

            //}).ToList();
        }
    }
}

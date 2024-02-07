using api_cinema_challenge.Application.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Presentation.DTOs.Movies
{
    public class GetMovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public RatingsEnum Rating { get; set; }

        public int RuntimeMins { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }
    }
}

using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Enums;
using Npgsql.PostgresTypes;

namespace api_cinema_challenge.DataTransfer.Requests
{
    public class MoviePostRequest
    {
        public string Title { get; set; }
        public MovieRating Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<Screening> screenings { get; set; }
    }
}

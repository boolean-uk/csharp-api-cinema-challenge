using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int id { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public int movieId { get; set; }
        public MovieDTO movie { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public ScreeningDTO(Screening screening) 
        {
            id = screening.id;
            screenNumber = screening.screenNumber;
            capacity = screening.capacity;
            movieId = screening.movieId;
            movie = new MovieDTO(screening.movie);
            startsAt = screening.startsAt;
            createdAt = screening.createdAt;
            updatedAt = screening.updatedAt;
        }


    }
}
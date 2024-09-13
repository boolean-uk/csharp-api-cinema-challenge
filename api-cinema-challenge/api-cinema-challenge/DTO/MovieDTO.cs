using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public MovieDTO(Movie model)
        {
            Id = model.Id;
            Title = model.Title;
            Rating = model.Rating;
            Description = model.Description;
            RuntimeMins = model.RuntimeMins;
            CreatedAt = model.CreatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = model.UpdatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}

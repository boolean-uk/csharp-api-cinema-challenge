using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    public class Movie
    {
        [Required] public int Id { get; set; }
        [Required] public string title { get; set; }
        [Required] public string rating { get; set; }
        [Required] public string description { get; set; }
        [Required] public int runtimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

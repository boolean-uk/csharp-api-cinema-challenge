using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO.Response
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int runtimeMins { get; set; }
        public string rating { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

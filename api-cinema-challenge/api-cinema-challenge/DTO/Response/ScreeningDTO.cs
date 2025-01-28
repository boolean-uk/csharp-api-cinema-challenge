using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO.Response
{
    public class ScreeningDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int capacity { get; set; }
        public int screenNumber { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}

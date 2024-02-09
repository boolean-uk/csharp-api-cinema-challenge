using api_cinema_challenge.Models.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure
{
    [Table("auditoriums")]
    public class Auditorium : ICreatedAndUpdatedTimeStamping
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}

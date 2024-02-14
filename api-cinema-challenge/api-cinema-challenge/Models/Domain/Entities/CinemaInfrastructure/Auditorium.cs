using api_cinema_challenge.Models.Domain.AbstractClasses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure
{
    [Table("auditoriums")]
    public class Auditorium : TimestampedEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public ICollection<Seat> Seats { get; set; }
    }
}

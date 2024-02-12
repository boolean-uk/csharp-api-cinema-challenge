using api_cinema_challenge.Models.Domain.AbstractClasses;
using api_cinema_challenge.Models.Domain.Entities.Junctions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure
{
    [Table("seats")]
    public class Seat : TimestampedEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("auditorium_id")]
        [ForeignKey("AuditoriumId")]
        public int AuditoriumId { get; set; }
        public Auditorium Auditorium { get; set; }

        [Column("row_number")]
        public int RowNumber { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }

        [Column("max_weight_in_kg")]
        public int MaxWeight { get; set; }

        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}

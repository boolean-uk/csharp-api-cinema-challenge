using api_cinema_challenge.Models.Domain.Interfaces;
using api_cinema_challenge.Models.Domain.Junctions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure
{
    [Table("seats")]
    public class Seat : ICreatedAndUpdatedTimeStamping
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

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}

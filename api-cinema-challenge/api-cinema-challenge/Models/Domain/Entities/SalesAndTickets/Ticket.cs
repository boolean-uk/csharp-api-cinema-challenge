using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.Domain.Interfaces;
using api_cinema_challenge.Models.Domain.Junctions;

namespace api_cinema_challenge.Models.Domain.Entities.SalesAndTickets
{
    [Table("tickets")]
    public class Ticket : ICreatedAndUpdatedTimeStamping
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}

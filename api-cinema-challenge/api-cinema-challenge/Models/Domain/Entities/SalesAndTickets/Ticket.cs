using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models.Domain.AbstractClasses;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Models.Domain.Entities.SalesAndTickets
{
    [Table("tickets")]
    public class Ticket : TimestampedEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ScreeningSeat> ScreeningSeats { get; set; }
    }
}

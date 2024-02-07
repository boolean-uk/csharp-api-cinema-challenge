using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Models.Domain.Entities
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("screening_id")]
        [ForeignKey("ScreeningId")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [Column("customer_id")]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}

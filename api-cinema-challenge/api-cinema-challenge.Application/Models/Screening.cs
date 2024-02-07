using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Application.Models
{
    [Table("screenings")]
    public class Screening : IEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Column("movie_id")]
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at", TypeName = "date")]
        public DateTime StartsAt { get; set; }
        [Column("created_at", TypeName = "date")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }
        [Column("customer_id")]
        public List<Customer> Customers { get; } = [];
    }
}

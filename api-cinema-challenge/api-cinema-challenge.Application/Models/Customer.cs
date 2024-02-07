using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Application.Models
{
    [Table("customers")]
    public class Customer : IEntity
    {
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
        [Column("created_at", TypeName = "date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Column("updated_at", TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }
        [Column("screening_id")]
        public List<Screening> Screenings { get; } = [];
    }
}

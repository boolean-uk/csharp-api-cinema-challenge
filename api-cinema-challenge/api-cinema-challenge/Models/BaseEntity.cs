using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public abstract class BaseEntity
    {
        [Column("createdAt")]
        public DateTime? CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
    }
}

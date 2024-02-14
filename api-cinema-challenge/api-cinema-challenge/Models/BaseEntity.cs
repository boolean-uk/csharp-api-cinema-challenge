using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public abstract class BaseEntity
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }

    }
}

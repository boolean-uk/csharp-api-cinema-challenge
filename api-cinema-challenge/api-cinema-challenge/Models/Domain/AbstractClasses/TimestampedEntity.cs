using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.AbstractClasses
{
    public abstract class TimestampedEntity
    {
        protected TimestampedEntity()
        {
            this.CreatedAt = this.UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}

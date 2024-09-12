using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Screen")]
    public class Screen
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("ScreenNumber")]
        public int ScreenNumber { get; set; }
        [Column("CreatedAt")]
        public DateTime createdAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        public DateTime updatedAt { get; set; } = DateTime.UtcNow;
    }
}

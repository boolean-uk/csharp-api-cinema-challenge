using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("created_at")]
        public DateTime createdAt { get; set; } = DateTime.Now;

        [Column("updated_at")]
        public DateTime updatedAt { get; set; }
    }
}

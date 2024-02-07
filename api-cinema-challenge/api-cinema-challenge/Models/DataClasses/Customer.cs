using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.NewFolder
{
    public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }
        [Column("customer_name")]
        public string Name { get; set; }
        [Column("customer_email")]
        public string Email { get; set; }
        [Column("customer_phone")]
        public string Phone { get; set; }
        [Column("customer_created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("customer_updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}

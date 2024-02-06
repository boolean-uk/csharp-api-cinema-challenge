using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.PureModels
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("name")]
        [MaxLength(255)]
        public string CustomerName { get; set; }

        [Column("email")]
        [MaxLength(255)]
        public string Email { get; set; }

        [Column("phoneNumber")]
        [MaxLength(31)]
        public string PhoneNumber { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set;}
    }
}

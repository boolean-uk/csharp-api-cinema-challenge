using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Column("customer_id")]
        public int Id { get; set; }

        [Column("customer_name")]
        public string CustomerName { get; set; }

        [Column("email_adr")]
        public string EmailAdress {  get; set; }

        [Column("phone_nr")]
        public string PhoneNumber { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}

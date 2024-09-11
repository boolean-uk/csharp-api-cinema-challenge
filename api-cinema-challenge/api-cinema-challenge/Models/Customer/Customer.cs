using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Customer
{
    [Table("CUSTOMER")]
    public class Customer
    {
        [Key]
        [Required]
        [Column("ID")]
        public int id { get; set; }
        [Column("NAME")]
        public string name { get; set; }
        [Column("EMAIL")]
        public string email { get; set; }
        [Column("PHONE")]
        public string phone { get; set; }
        [Column("CREATEDAT")]
        public DateTime createdAt { get; set; }
        [Column("UPDATEDAT")]
        public DateTime updatedAt { get; set; }
    }
}

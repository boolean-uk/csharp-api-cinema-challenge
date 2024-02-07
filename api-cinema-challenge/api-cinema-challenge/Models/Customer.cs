using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer : AbstractModel
    {
        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [Column("phone")]
        public string Phone { get; set; }
    }
}

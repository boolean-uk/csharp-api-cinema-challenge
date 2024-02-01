using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{


    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int UserId { get; set; }

        [Column("names")]
        public string Name { get; set; }
        [Column("emails")]
        public string Email { get; set; }
        [Column("phonenumbers")]
        public string Phone { get; set; }

        [Column("created_at")]
        public DateTime Created_at { get; set; }
        [Column("updated_at")]
        public DateTime Updated_at { get; set; }

    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Security;

namespace api_cinema_challenge.Models
{
    [Table("halls")]
    public class Hall
    {
        [Column("hall_id")]
        public int Id { get; set; }

        [Column("hall_name")]
        public string HallName { get; set; }

        [Column("hall_desc")]
        public string HallDesc { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get;set; }
    }
}

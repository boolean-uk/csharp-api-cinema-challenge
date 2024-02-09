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
        public string Hall_Name { get; set; }

        [Column("hall_desc")]
        public string Hall_Desc { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; }

        [Column("updated_at")]
        public DateTime Updated_At { get;set; }
    }
}

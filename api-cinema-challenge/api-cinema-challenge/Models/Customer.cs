using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }

    }
}

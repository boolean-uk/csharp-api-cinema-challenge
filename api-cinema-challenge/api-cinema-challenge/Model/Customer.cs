using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model {
    
    [Table("customers")]
    public class Customer {
        [Column("Id")]
        public int Id {get; set;}
        [Column("name")]
        public required string Name {get; set;}
        [Column("email")]
        public required string Email {get; set;}
        [Column("phone")]
        public required string Phone {get; set;}
        [Column("created_at")]
        public DateTime CreatedAt {get; set;}
        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;}
        public ICollection<Ticket> Tickets {get; set;} = [];
    }
}
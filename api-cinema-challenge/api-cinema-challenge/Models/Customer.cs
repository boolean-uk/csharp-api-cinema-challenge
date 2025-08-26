using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;


namespace api_cinema_challenge.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int Id {  get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("createdat")]
        public DateTime CreatedAt { get; set; }

        [Column("updatedat")]
        public DateTime UpdatedAt { get; set; }

        public IEnumerable<Ticket> Tickets { get; set; }= new List<Ticket>(); 

    }
}

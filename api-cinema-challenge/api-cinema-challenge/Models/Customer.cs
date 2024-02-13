using api_cinema_challenge.Models.Base;
using api_cinema_challenge.User_Requests;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customer")]
    public class Customer : ModelBase
    {
        [Key, Required, Column("id")]
        public int Id { get; internal set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public List<Ticket> Tickets;

        public Customer() { }
        public Customer(CustomerRequest request)
        {
            if (request == default(CustomerRequest)) return;

            Name = request.Name;
            Email = request.Email;
            Phone = request.Phone;
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("customers")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone_number")]
        public string Phone { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }
        [Column("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }

    public record CustomerPayload(string Name, string Email, string Phone);

    public class CustomerOutput
    {
        public string status { get;}
        public Customer data { get; }
        public CustomerOutput(string status, Customer data)
        {
            this.status = status;
            this.data = data;
        }
    }
    public class CustomerListOutput
    {
        public string status { get; }
        public IEnumerable<Customer> data { get; }
        public CustomerListOutput(string status, IEnumerable<Customer> data)
        {
            this.status = status;
            this.data = data;
        }
    }

}

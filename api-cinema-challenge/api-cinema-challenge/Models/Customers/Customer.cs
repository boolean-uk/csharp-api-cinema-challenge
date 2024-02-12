using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Customers
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

        [Column("phone")]
        public string Phone { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Customer Update (CustomerInput newData)
        {
            Name = newData.Name;
            Email = newData.Email;
            Phone = newData.Phone;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }
    }
}

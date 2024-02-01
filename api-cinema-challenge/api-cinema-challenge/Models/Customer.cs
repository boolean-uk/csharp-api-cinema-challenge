using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public record NewCustomer(string Name, string Email, int PhoneNr, int ScreeningId);
    public record UpdateCustomer(string? Name, string? Email, int? PhoneNr, int? ScreeningId);
    [Table("customers")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("phone_nr")]
        public int PhoneNr { get; set; }
        [Column("screening_id")]
        public int ScreeningId { get; set; }
        public Screenings Screening { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Customer()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}

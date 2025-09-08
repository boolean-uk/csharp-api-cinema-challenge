using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

[Table("customers")]
public class Customer
{
    [Column("id", TypeName = "int")]
    public int Id { get; set; }
    
    [Column("name", TypeName = "varchar(100)")]
    public string Name { get; set; }
    
    [Column("email", TypeName = "varchar(100)")]
    public string Email { get; set; }
    
    [Column("phone", TypeName = "varchar(20)")]
    public string Phone { get; set; }
    
    [Column("created_at", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at", TypeName = "timestamp with time zone")]
    public DateTime UpdatedAt { get; set; }
}
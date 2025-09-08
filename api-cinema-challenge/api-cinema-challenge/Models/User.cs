using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("username", TypeName = "varchar(100)")]
    public string Username { get; set; }
    
    [Column("password_hash", TypeName = "varchar(100)")]
    public string PasswordHash { get; set; }
}
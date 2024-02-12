using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO
{
    public class Customer_dto
    {        
        public int Id { get; set; }
        public string Name { get; set; }        
        public string Email { get; set; }        
        public string Phone { get; set; }       
        public string CreatedAt { get; set; }        
        public string UpdatedAt { get; set; }
    }
}

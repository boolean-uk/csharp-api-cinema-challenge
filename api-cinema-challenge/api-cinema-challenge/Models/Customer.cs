using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
               /* {
        "id": 1,
        "name": "Chris Wolstenholme",
        "email": "chris@muse.mu",
        "phone": "+44729388192",
        "createdAt": "2023-03-14T11:01:56.633+00:00",
        "updatedAt": "2023-03-14T11:01:56.633+00:00"
        }*/
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


}
}

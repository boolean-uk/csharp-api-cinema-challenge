using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTO.Response
{
    public class Get_Customer : DTO_Response<Get_Customer, Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public override void Initialize(Customer model)
        {
            Id = model.Id;
            Name = model.Name;
            Email = model.Email;
            Phone = model.Phone;
            CreatedAt = model.CreatedAt;
            UpdatedAt = model.UpdatedAt;
        }
    }
}

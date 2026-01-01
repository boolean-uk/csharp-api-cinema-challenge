using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Customer : IDTO_Request_create<Create_Customer, Customer>
    {
        public string name {  get; set; }
        public string email {  get; set; }
        public string phone{  get; set; }

        public static Customer create(Create_Customer dto, params object[] pathargs)
        {
            return new Customer
            {
                Name = dto.name,
                Phone= dto.phone,
                Email= dto.email
            };
        }

    }
}

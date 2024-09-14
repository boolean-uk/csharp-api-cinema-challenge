using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO.ViewModel
{
    public class CustomerPostPutModel
    { 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}

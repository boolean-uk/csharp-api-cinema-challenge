using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public DateTime Created {  get; set; }


    }
}

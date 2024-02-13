using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.User_Requests
{
    public class CustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
    public class TicketRequest
    {
        public int NumSeats { get; set; }
        public int FK_Id_Customer { get; set; }
        public int FK_Id_Screening { get; set; }
    }
    public class MovieRequest
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
    public class ScreeningRequest
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public int FK_Id_Movie { get; set; }
    }
}

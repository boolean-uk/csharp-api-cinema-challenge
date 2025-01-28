using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Ticket : IDTO_Request_create<Create_Ticket, Tickets>
    {
        public int NumSeats {  get; set; }

        public static Tickets create(Create_Ticket dto, params object[] pathargs)
        {
            return new Tickets
            {
                ScreeningId = (int)pathargs[0],
                CustomerId = (int)pathargs[1],
                NumSeats  = dto.NumSeats
            };
        }

    }
}

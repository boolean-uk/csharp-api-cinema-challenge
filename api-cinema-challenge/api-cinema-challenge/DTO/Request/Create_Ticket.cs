using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Ticket : IDTO_Request_create<Create_Ticket, Ticket>
    {
        public int NumSeats {  get; set; }

        public static Ticket create(Create_Ticket dto, params object[] pathargs)
        {
            return new Ticket
            {
                ScreeningId = (int)pathargs[0],
                CustomerId = (int)pathargs[1],
                NumSeats  = dto.NumSeats
            };
        }

    }
}

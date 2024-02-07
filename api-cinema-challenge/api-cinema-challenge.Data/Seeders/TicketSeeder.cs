using api_cinema_challenge.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_cinema_challenge.Data.Seeders
{
    public static class TicketSeeder
    {

        public static List<Ticket> Generate()
        {
            List<Ticket> tickets = [
                new Ticket()
                {
                    Id = 1,
                    CustomerId = 1,
                    ScreeningId = 3,
                    NumSeats = 4,
                },
                new Ticket()
                {
                    Id = 2,
                    CustomerId = 3,
                    ScreeningId = 4,
                    NumSeats = 2,
                },
                new Ticket()
                {
                    Id = 3,
                    CustomerId = 2, 
                    ScreeningId = 1, 
                    NumSeats = 1,
                }
            ];
            return tickets;
        }
    }
}

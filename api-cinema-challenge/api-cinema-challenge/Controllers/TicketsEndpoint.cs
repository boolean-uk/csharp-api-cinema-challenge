using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Models.TransferModels.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketsEndpoint
    {
        public static void ConfigureTicketsEndpoint(this WebApplication app) 
        {
            var ticketGroup = app.MapGroup("tickets/");

            //ticketGroup.MapGet();
        }


    }
}

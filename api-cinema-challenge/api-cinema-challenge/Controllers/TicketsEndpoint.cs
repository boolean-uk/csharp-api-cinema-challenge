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

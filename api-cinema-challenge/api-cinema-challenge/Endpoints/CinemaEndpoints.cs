using System;

namespace api_cinema_challenge.Endpoints;

public static class CinemaEndpoints
{
    public static void ConfigureEndpoints(this WebApplication app)
    {
        app.MapCustomerEndpoints();
        app.MapMovieEndpoints();
        app.MapScreeningEndpoints();
        app.MapTicketEndpoints();
    }
}

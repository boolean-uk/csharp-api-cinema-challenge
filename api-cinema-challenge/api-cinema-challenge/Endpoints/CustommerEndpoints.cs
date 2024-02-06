namespace api_cinema_challenge.Endpoints
{
    public static class CustommerEndpoints
    {
        public static void ConfigureAppointmentEndpoint(this WebApplication app)
        {
            var appointmentGroup = app.MapGroup("appointment");

            //appointmentGroup.MapGet("/", GetAppointments);
            

        }

        //[ProducesResponseType(StatusCodes.Status200OK)]


    }
}

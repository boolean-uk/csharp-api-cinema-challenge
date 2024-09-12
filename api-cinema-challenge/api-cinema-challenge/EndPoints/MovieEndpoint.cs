namespace api_cinema_challenge.EndPoints
{
    public static class MovieEndpoint
    {
        public static void configureMovieEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("movie");

        }
    }
}

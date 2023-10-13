namespace api_cinema_challenge.Extensions
{
    public static class ResponseExtensions
    {
        public static IResult StandardizedOk<T>(this T data) where T : class
        {
            return Results.Ok(new
            {
                Status = "success",
                Data = data
            });
        }

        public static IResult StandardizedCreated<T>(this T data, string location) where T : class
        {
            return Results.Created(location, new
            {
                Status = "success",
                Data = data
            });
        }
    }
}
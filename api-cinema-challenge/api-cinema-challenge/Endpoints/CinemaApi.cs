using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Endpoints;

public static class CinemaApi
{
    public static void ConfigureCinemaApi(this WebApplication app)
    {
        var cinema = app.MapGroup("cinema");

        cinema.MapGet("/customers", GetCustomer);
        cinema.MapGet("/movies", GetMovies);
        cinema.MapGet("/screenings", GetScreenings);
    }

    private async static Task<IResult> GetCustomer(IRepository<Customer> repo)
    {
        return TypedResults.Ok(await repo.GetAll());
    }
    
    
    private async static Task<IResult> GetMovies(IRepository<Movie> repo)
    {
        return TypedResults.Ok(await repo.GetAll());
    }
    
    
    private async static Task<IResult> GetScreenings(IRepository<Screening> repo)
    {
        return TypedResults.Ok(await repo.GetAll());
    }
}
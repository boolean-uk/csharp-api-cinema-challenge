using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Mvc;


// https://learn.microsoft.com/en-us/aspnet/core/web-api/advanced/formatting?view=aspnetcore-8.0
namespace api_cinema_challenge.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    [FormatFilter]
    public class CinemaController : ControllerBase
    {
    }
}

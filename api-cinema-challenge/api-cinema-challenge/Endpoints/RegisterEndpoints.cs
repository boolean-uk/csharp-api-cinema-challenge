using api_cinema_challenge.Data;
using Microsoft.AspNetCore.Mvc;

public static class RegisterEndpoints
{
    public static void MapRegisterEndpoints(this WebApplication app)
    {
        app.MapPost("/register", async (RegisterCustomerDto dto, CinemaContext db) =>
        {
            var customer = new Customer
            {
                Name = dto.Name,
                Email = dto.Email,
                Password = dto.Password,
                Phonenumber = dto.Phonenumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            db.Customers.Add(customer);
            await db.SaveChangesAsync();

            return Results.Ok(new { customer.Id, customer.Name, customer.Email });
        });
    }
}

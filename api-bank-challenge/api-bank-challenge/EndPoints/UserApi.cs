using BankApp.Repository;
using BankApp.Models;

namespace BankApp.EndPoints
{
    public static class UserApi
    {
        public static void ConfigureUserApi(this WebApplication app)
        {
            app.MapGet("/users", GetUsers);
            app.MapPost("/users", AddUser);
            app.MapPut("/users", UpdateUser);
            app.MapDelete("/users/{id}", DeleteUser);
        }

        public static async Task<IResult> GetUsers(iRepositoryBank repository)
        {
            try
            {
                var users = repository.GetUsers();
                return users != null ? Results.Ok(users) : Results.Problem("There are no users yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddUser(iRepositoryBank repository, User user)
        {
            try
            {
                var item = repository.AddUser(user);
                return item != null ? Results.Created("https://localhost:7174/users", user) : Results.Problem("There is no user to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateUser(iRepositoryBank repository, User user)
        {
            try
            {
                var item = repository.UpdateUser(user);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no user with id of {user.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteUser(iRepositoryBank repository, int id)
        {
            try
            {
                var user = repository.DeleteUser(id);
                return user != null ? Results.Ok(user) : Results.Problem($"There is no user with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}

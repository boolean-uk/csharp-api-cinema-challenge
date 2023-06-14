using BankApp.Models;
using BankApp.Repository;

namespace BankApp.EndPoints
{
    public static class AccountApi
    {
        public static void ConfigureAccountApi(this WebApplication app)
        {
            app.MapGet("/account", GetAccounts);
            app.MapPost("/account", AddAccount);
            app.MapPut("/account", UpdateAccount);
            app.MapDelete("/account/{id}", DeleteAccount);
        }

        public static async Task<IResult> GetAccounts(iRepositoryBank repository)
        {
            try
            {
                var accounts = repository.GetAccounts();
                return accounts != null ? Results.Ok(accounts) : Results.Problem("There are no accounts yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddAccount(iRepositoryBank repository, Account account)
        {
            try
            {
                var item = repository.AddAccount(account);
                return item != null ? Results.Created("https://localhost:7174/users", account) : Results.Problem("There is no account to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateAccount(iRepositoryBank repository, Account account)
        {
            try
            {
                var item = repository.UpdateAccount(account);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no user with id of {account.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteAccount(iRepositoryBank repository, int id)
        {
            try
            {
                var account = repository.DeleteAccount(id);
                return account != null ? Results.Ok(account) : Results.Problem($"There is no account with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}

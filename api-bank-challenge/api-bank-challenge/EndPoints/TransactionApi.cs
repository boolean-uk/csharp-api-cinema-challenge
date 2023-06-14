using BankApp.Models;
using BankApp.Repository;

namespace BankApp.EndPoints
{
    public static class TransactionApi
    {
        public static void ConfigureTransactionApi(this WebApplication app)
        {
            app.MapGet("/transaction", GetTransactions);
            app.MapPost("/transaction", AddTransaction);
            app.MapPut("/transaction", UpdateTransaction);
            app.MapDelete("/transaction/{id}", DeleteTransaction);
        }

        public static async Task<IResult> GetTransactions(iRepositoryBank repository)
        {
            try
            {
                var transactions = repository.GetTransactions();
                return transactions != null ? Results.Ok(transactions) : Results.Problem("There are no transactions yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddTransaction(iRepositoryBank repository, Transaction transaction)
        {
            try
            {
                var item = repository.AddTransaction(transaction);
                return item != null ? Results.Created("https://localhost:7174/users", transaction) : Results.Problem("There is no transaction to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateTransaction(iRepositoryBank repository, Transaction transaction)
        {
            try
            {
                var item = repository.UpdateTransaction(transaction);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no transaction with id of {transaction.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteTransaction(iRepositoryBank repository, int id)
        {
            try
            {
                var transaction = repository.DeleteTransaction(id);
                return transaction != null ? Results.Ok(transaction) : Results.Problem($"There is no transaction with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}

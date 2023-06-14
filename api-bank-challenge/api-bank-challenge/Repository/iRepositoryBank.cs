using BankApp.Models;

namespace BankApp.Repository
{
    public interface iRepositoryBank
    {
        IEnumerable<User> GetUsers();
        User AddUser(User user);
        User UpdateUser(User user);
        User DeleteUser(int id);

        IEnumerable<Account> GetAccounts();
        Account AddAccount(Account account);
        Account UpdateAccount(Account account);
        Account DeleteAccount(int id);

        IEnumerable<Transaction> GetTransactions();
        Transaction AddTransaction(Transaction transaction);
        Transaction UpdateTransaction(Transaction transaction);
        Transaction DeleteTransaction(int id);

    }
}

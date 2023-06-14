using BankApp.Data;
using BankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repository
{
    public class RepositoryBank : iRepositoryBank
    {
        public RepositoryBank() { }

        public Account AddAccount(Account account)
        {
            using (var db = new BankContext())
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return account;
            }
        }

        public Transaction AddTransaction(Transaction transaction)
        {
            using (var db = new BankContext())
            {
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return transaction;
            }
        }

        public User AddUser(User user)
        {
            using (var db = new BankContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }

        public Account DeleteAccount(int id)
        {
            using (var db = new BankContext())
            {
                var account = db.Accounts.SingleOrDefault(x => x.Id == id);
                db.Accounts.Remove(account);
                db.SaveChanges();
                return account;
            }
        }

        public Transaction DeleteTransaction(int id)
        {
            using (var db = new BankContext())
            {
                var transaction = db.Transactions.SingleOrDefault(x => x.Id == id);
                db.Transactions.Remove(transaction);
                db.SaveChanges();
                return transaction;
            }
        }

        public User DeleteUser(int id)
        {
            using (var db = new BankContext())
            {
                var user = db.Users.SingleOrDefault(x => x.Id == id);
                db.Users.Remove(user);
                db.SaveChanges();
                return user;
            }
        }

        public IEnumerable<Account> GetAccounts()
        {
            using (var db = new BankContext())
            {
                return db.Accounts.Include(a => a.transactions).ToList();
            }
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            using (var db = new BankContext())
            {
                return db.Transactions.ToList();
            }
        }

        public IEnumerable<User> GetUsers()
        {
            using (var db = new BankContext())
            {
                return db.Users.ToList();
            }
        }

        public Account UpdateAccount(Account account)
        {
            using (var db = new BankContext())
            {
  
                db.Accounts.Update(account);
                db.SaveChanges();
                return account;
            }
        }

        public Transaction UpdateTransaction(Transaction transaction)
        {
            using (var db = new BankContext())
            {

                db.Transactions.Update(transaction);
                db.SaveChanges();
                return transaction;
            }
        }

        public User UpdateUser(User user)
        {
            using (var db = new BankContext())
            {
                db.Users.Update(user);
                db.SaveChanges();
                return user;
            }
        }
    }
}

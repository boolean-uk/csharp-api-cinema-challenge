using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.DTO.Request
{
    public class Delete_Customer : IDTO_Request_delete<Delete_Customer, Customers>
    {
        public static async Task<Customers?> delete(IRepository<Customers> repo, params object[] id)
        {
            var customer =  await repo.DeleteEntry(x => x.Where( x => x.Id == (int)id[0]));
            if (customer == null) throw new Exception("Not found");
            return customer;
        }
    }
}

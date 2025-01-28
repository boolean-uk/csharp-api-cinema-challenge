using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Mail;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.DTO.Request
{
    public class Update_Customer : IDTO_Request_update<Update_Customer, Customers>
    {
        public string? name {  get; set; }
        public string? email {  get; set; }
        public string? phone{  get; set; }

        public static async Task<Customers?> update(Update_Customer dto, IRepository<Customers> repo, params object[] id)
        {
            var customer =  await repo.GetEntry(x => x.Where(x => (int)id[0] == x.Id));
            if (customer == null) throw new Exception("Not found");

            return await repo.UpdateEntry(
                x => x.Where(x => (int)id[0] == x.Id),
                new Customers
                {
                    Id = customer.Id,
                    Name = dto.name ?? customer.Name,
                    Phone = dto.phone ?? customer.Phone,
                    Email = dto.email ?? customer.Email,
                    CreatedAt = customer.CreatedAt

                });
        }
    }
}

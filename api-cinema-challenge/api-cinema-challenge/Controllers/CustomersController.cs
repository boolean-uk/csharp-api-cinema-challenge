using api_cinema_challenge.Dtos;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repo;
        public CustomersController(ICustomerRepository repo) => _repo = repo;

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CustomerDto>> Create(CreateCustomer req)
        {
            var c = await _repo.AddAsync(new Customer { Name = req.Name, Email = req.Email, Phone = req.Phone });
            return CreatedAtAction(nameof(GetAll), null,
                new CustomerDto(c.Id, c.Name, c.Email, c.Phone, c.CreatedAt, c.UpdatedAt));
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll()
        {
            var list = await _repo.GetAllAsync();
            return Ok(list.Select(c => new CustomerDto(c.Id, c.Name, c.Email, c.Phone, c.CreatedAt, c.UpdatedAt)));
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CustomerDto>> Update(int id, CreateCustomer req)
        {
            var updated = await _repo.UpdateAsync(id, new Customer { Name = req.Name, Email = req.Email, Phone = req.Phone });
            if (updated == null) return NotFound();
            return Ok(new CustomerDto(updated.Id, updated.Name, updated.Email, updated.Phone, updated.CreatedAt, updated.UpdatedAt));
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CustomerDto>> Delete(int id)
        {
            var deleted = await _repo.DeleteAsync(id);
            if (deleted == null) return NotFound();
            return Ok(new CustomerDto(deleted.Id, deleted.Name, deleted.Email, deleted.Phone, deleted.CreatedAt, deleted.UpdatedAt));
        }
    }
}

using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Text;


namespace api_cinema_tests
{
    public class CustomerTest
    {
        private HttpClient _client;
        [SetUp]
        public void Setup()
        {
            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
            _client = factory.CreateClient();
        }

        [TearDown]
        public void Cleanup()
        {

        }

        [Test]
        public async Task GetUsersTest()
        {
            //Act
            var response = await _client.GetAsync("/customers");

            var responseContent = await response.Content.ReadAsStringAsync();

            List<Customer> responseCustomers = JsonConvert.DeserializeObject<List<Customer>>(responseContent);

            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
            Assert.That(responseCustomers[0].Name, Is.EqualTo("Jon Doe"));
            Assert.That(responseCustomers[0].Email, Is.EqualTo("jon@example.com"));
            Assert.That(responseCustomers[0].Phone, Is.EqualTo("+123"));
            Assert.That(responseCustomers[0].CreatedAt, Is.LessThan(DateTime.UtcNow));
            Assert.That(responseCustomers[0].UpdatedAt, Is.LessThan(DateTime.UtcNow));
        }

        [Test]
        public async Task CreateAndDeleteUser()
        {
            //Act
            var expectedPayload = new Customer()
            {
                Name = "Johanna Dose",
                Email = "johanna@mail.com",
                Phone = "+123123"
            };

            var content = new StringContent(JsonConvert.SerializeObject(expectedPayload), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("/customers", content);

            //Assert
            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));

            var responseContent = await response.Content.ReadAsStringAsync();
            var createdCustomer = JsonConvert.DeserializeObject<Customer>(responseContent);

            Assert.That(createdCustomer.Name, Is.EqualTo(expectedPayload.Name));
            Assert.That(createdCustomer.Email, Is.EqualTo(expectedPayload.Email));
            Assert.That(createdCustomer.Phone, Is.EqualTo(expectedPayload.Phone));
            Assert.That(createdCustomer.CreatedAt, Is.LessThan(DateTime.UtcNow));
            Assert.That(createdCustomer.UpdatedAt, Is.LessThan(DateTime.UtcNow));
            Assert.That(createdCustomer.Id, Is.Positive);

            var deleteRespone = await _client.DeleteAsync($"/customers/{createdCustomer.Id}");
            Assert.That(deleteRespone.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.OK));
        }
    }
}
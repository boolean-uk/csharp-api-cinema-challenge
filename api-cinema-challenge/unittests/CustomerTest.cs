using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net.Http.Json;
using api_cinema_challenge;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Numerics;



namespace unittests
{
    public class CustomerTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public async Task CustomerEndpointStatus()
        {
            // Arrange
            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
            var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync("/cinema/customers");

            // Assert
            Assert.IsTrue(response.StatusCode == System.Net.HttpStatusCode.OK);
        }




        [Test]
        public async Task CreateCustomer()
        {

            var factory = new WebApplicationFactory<Program>().WithWebHostBuilder(builder => { });
            var client = factory.CreateClient();

            var res = await client.GetAsync("/cinema/customers");
            //int amount = res.Content.ReadFromJsonAsync<List<Customer>>().Result.Count;

            // int amount = res.Content.ReadFromJsonAsync<IEnumerable<Customer>>().Result.Count();

            var expectedPayload = new List<Customer>()
            {
                new Customer { Id = 5, Name = "Gary Way", Email = "gary@gmail.com", Phone = "+12345678" }
            };

            var obj = new
            {
                name = "Gary Way",
                email = "gary@gmail.com",
                phone = "+12345678"
            };

            JsonContent content = JsonContent.Create(obj);

            var response = await client.PostAsync("/cinema/customers", content);

            var responsePayload = response.Content.ReadFromJsonAsync<Customer>();

            Assert.That(response.StatusCode, Is.EqualTo(System.Net.HttpStatusCode.Created));

            Assert.That(responsePayload.Result.Name, Is.EqualTo(expectedPayload[0].Name));
            Assert.That(responsePayload.Result.Email, Is.EqualTo(expectedPayload[0].Email));
            Assert.That(responsePayload.Result.Phone, Is.EqualTo(expectedPayload[0].Phone));

        }
    }
}
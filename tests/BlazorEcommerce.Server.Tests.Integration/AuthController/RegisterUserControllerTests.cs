using BlazorEcommerce.Shared;
using Bogus;
using FluentAssertions;
using System.Net;
using System.Net.Http.Json;
using Xunit;

namespace BlazorEcommerce.Server.Tests.Integration.AuthController
{
    public class RegisterUserControllerTests : IClassFixture<BlazorEcommerceApiFactory>
    {
        public const string Password = "password";

        private readonly BlazorEcommerceApiFactory _apiFactory;
        private readonly HttpClient _client;


        private readonly Faker<UserRegister> _userGenerator = new Faker<UserRegister>()
            .RuleFor(x => x.Email, faker => faker.Person.Email)
            .RuleFor(x => x.Password, Password)
            .RuleFor(x => x.ConfirmPassword, Password);

        public RegisterUserControllerTests(BlazorEcommerceApiFactory apiFactory)
        {
            _apiFactory = apiFactory;
            _client = apiFactory.CreateClient();
        }

        [Fact]
        public async Task ReturnValidationError_WhenEmailIsInvalid()
        {
            var user = _userGenerator.Clone().RuleFor(x => x.Email, "asdsjakdasbd");

            var response = await _client.PostAsJsonAsync("register", user);

            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Register_CreatesUser_WhenDataIsValid()
        {
            //Arrange
            var user = _userGenerator.Generate();

            var response = await _client.PostAsJsonAsync("register", user);

            var userResponse = await response.Content.ReadFromJsonAsync<ServiceResponse<int>>();

           response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    
    }
}

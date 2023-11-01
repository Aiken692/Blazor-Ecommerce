using BlazorEcommerce.Server.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Testcontainers.PostgreSql;
using Xunit;

namespace BlazorEcommerce.Server.Tests.Integration
{
    public class BlazorEcommerceApiFactory : WebApplicationFactory<IApiMarker>, IAsyncLifetime
    {
        //Method Two    
        private readonly PostgreSqlContainer _dbContainer =
            new PostgreSqlBuilder()
            .WithDatabase("Blazor_Ecommerce")
            .WithUsername("postgres")
            .WithPassword("postgres")
            .Build();

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            var connectionString = _dbContainer.GetConnectionString();

            builder.ConfigureLogging(logging =>
            {
                logging.ClearProviders();
            });

            //configuring the database
            builder.ConfigureTestServices(services =>
            {
                // Remove DbContext
                services.RemoveAll<DataContext>();

                // Add DB dbContext pointing to test container
                services.AddDbContext<DataContext>(options =>
                {
                    options.UseNpgsql(connectionString);
                });
            });
        }

        public async Task InitializeAsync()
        {
            await _dbContainer.StartAsync();
        }

        public new async Task DisposeAsync()
        {
            await _dbContainer.DisposeAsync();
        }
    }
}

//Method One 
//private readonly TestcontainersContainer _dbContainer = 
//    new TestcontainersBuilder<TestcontainersContainer>()
//    .WithImage("postgres:latest")
//    .WithEnvironment("POSTGRES_USER", "postgres")
//    .WithEnvironment("POSTGRES_PASSWORD", "postgres")
//    .WithEnvironment("POSTGRES_DB", "Blazor_Ecommerce")
//    .WithPortBinding(5555, 5432)
//    .WithWaitStrategy(Wait.ForUnixContainer().UntilPortIsAvailable(5432))
//    .Build();

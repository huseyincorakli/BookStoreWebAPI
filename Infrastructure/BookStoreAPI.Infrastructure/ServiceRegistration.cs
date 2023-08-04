using BookStoreAPI.Application.Services;
using BookStoreAPI.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFileService, FileService>();
        }
    }
}

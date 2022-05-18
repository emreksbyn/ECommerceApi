using ECommerceApi.Application.Abstractions;
using ECommerceApi.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ECommerceApi.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerceApi.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceApiDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }
    }
}
using Microsoft.Extensions.Configuration;

namespace ECommerceApi.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                // ConfigurationManager nesnesi için Microsoft.Extensions.Configuration paketi indirildi.
                ConfigurationManager configurationManager = new();
                // Aşağıdaki property' ler için ise Microsoft.Extensions.Configuration.Json paketi indirildi.
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceApi.Api"));
                configurationManager.AddJsonFile("appsettings.json");

                //return configurationManager.GetConnectionString("MsSqlConnectionString");
                return configurationManager.GetConnectionString("PostgreSqlConnectionString");
            }
        }
    }
}
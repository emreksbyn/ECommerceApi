using ECommerceApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerceApi.Persistence
{
    // Bu sınıfı PowerShell' den migration yapmak istiyorum diyorsak kullanıyoruz. Package Manager Console üzerinden migration yapacaksak gerek yoktur.
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceApiDbContext>
    {
        public ECommerceApiDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString);
            //dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
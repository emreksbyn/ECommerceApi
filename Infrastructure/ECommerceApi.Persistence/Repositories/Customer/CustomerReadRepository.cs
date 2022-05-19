using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistence.Contexts;

namespace ECommerceApi.Persistence.Repositories
{
    // ReadRepository<Customer> nesnesi ile CustomerReadRepository nesnesine Customer' e özel method' ları uygulamış oluyoruz. (Uygulayıcısı)
    // ICustomerReadRepository nesnesi ile de Dependency Injection' ı uygulayacağım ... (Doğrulayıcısı)
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        // ReadRepository<Customer> nesnesi Constractor' ında bir Context nesnesi ister bunuda aşağıdaki şekilde uygulamış oluyoruz.
        public CustomerReadRepository(ECommerceApiDbContext dbContext) : base(dbContext) { }
    }
}
using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistence.Contexts;

namespace ECommerceApi.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceApiDbContext dbContext) : base(dbContext) { }
    }
}
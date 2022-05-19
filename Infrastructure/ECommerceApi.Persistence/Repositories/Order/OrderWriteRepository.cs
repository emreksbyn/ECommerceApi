using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistence.Contexts;

namespace ECommerceApi.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceApiDbContext dbContext) : base(dbContext) { }
    }
}
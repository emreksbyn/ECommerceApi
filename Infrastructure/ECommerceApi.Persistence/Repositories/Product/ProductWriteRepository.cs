using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistence.Contexts;

namespace ECommerceApi.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceApiDbContext dbContext) : base(dbContext) { }
    }
}
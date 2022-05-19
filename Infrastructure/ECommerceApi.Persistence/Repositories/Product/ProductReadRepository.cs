using ECommerceApi.Application.Repositories;
using ECommerceApi.Domain.Entities;
using ECommerceApi.Persistence.Contexts;

namespace ECommerceApi.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceApiDbContext dbContext) : base(dbContext) { }
    }
}